﻿using ExClient;
using ExViewer.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.ComponentModel;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ExViewer.Controls
{
    public sealed partial class ImagePresenter : UserControl
    {
        public ImagePresenter()
        {
            this.InitializeComponent();
        }

        public GalleryImage Image
        {
            get => (GalleryImage)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static DependencyProperty ImageProperty
        {
            get;
        } = DependencyProperty.Register("Image", typeof(GalleryImage), typeof(ImagePresenter), new PropertyMetadata(null, ImagePropertyChangedCallback));

        private static void ImagePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var sender = (ImagePresenter)d;

            if(!sender.loaded)
            {
                if(e.OldValue != null)
                {
                    stopTrackImage(sender, (GalleryImage)e.OldValue);
                }
            }
            else
            {
                if(e.NewValue != null)
                {
                    startTrackImage(sender, (GalleryImage)e.NewValue);
                }
            }
        }

        private bool loaded;

        private static void startTrackImage(ImagePresenter sender, GalleryImage image)
        {
            image.PropertyChanged += sender.Image_PropertyChanged;
            if(image.State == ImageLoadingState.Waiting)
            {
                var ignore = image.LoadImageAsync(false, SettingCollection.Current.GetStrategy(), false);
            }
        }

        private static void stopTrackImage(ImagePresenter sender, GalleryImage image)
        {
            image.PropertyChanged -= sender.Image_PropertyChanged;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if(this.Image != null)
            {
                startTrackImage(this, this.Image);
            }
            this.loaded = true;
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            if(this.Image != null)
                stopTrackImage(this, this.Image);
            this.loaded = false;
        }

        private void Image_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(GalleryImage.ImageFile))
            {
                this.cc_Image.ClearValue(ContentControl.ContentProperty);
                this.cc_Image.Content = this.Image;
            }
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            this.gd_ContentRoot.MaxWidth = availableSize.Width;
            this.gd_ContentRoot.MaxHeight = availableSize.Height;
            Task.Yield().GetAwaiter().OnCompleted(() => this.sv.ChangeView(null, null, 1, true));
            return base.MeasureOverride(availableSize);
        }

        private void sv_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var dx = e.Delta.Translation.X;
            var dy = e.Delta.Translation.Y;
            this.sv.ChangeView(this.sv.HorizontalOffset - dx, this.sv.VerticalOffset - dy, null, true);
        }

        private void setSvManipulationMode(object sender, PointerRoutedEventArgs e)
        {
            switch(e.Pointer.PointerDeviceType)
            {
            case Windows.Devices.Input.PointerDeviceType.Touch:
                this.sv.ManipulationMode = ManipulationModes.System;
                break;
            case Windows.Devices.Input.PointerDeviceType.Pen:
            case Windows.Devices.Input.PointerDeviceType.Mouse:
                var mode = ManipulationModes.System | ManipulationModes.TranslateX | ManipulationModes.TranslateY |ManipulationModes.TranslateInertia;
                this.sv.ManipulationMode = mode;
                break;
            default:
                break;
            }
        }

        private void sv_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            setSvManipulationMode(sender, e);
        }

        private void sv_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            setSvManipulationMode(sender, e);
        }

        private void sv_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            setSvManipulationMode(sender, e);
        }

        public void ZoomTo(Point point, float factor)
        {
            if(factor > this.sv.MaxZoomFactor)
                factor = this.sv.MaxZoomFactor;
            else if(factor < this.sv.MinZoomFactor)
                factor = this.sv.MinZoomFactor;
            var pi = point;
            var psX = point.X * this.sv.ZoomFactor;
            var psY = point.Y * this.sv.ZoomFactor;
            if(this.sv.ScrollableWidth > 0)
                psX -= this.sv.HorizontalOffset;
            else
                psX += (this.sv.ActualWidth - this.sv.ExtentWidth) / 2;
            if(this.sv.ScrollableHeight > 0)
                psY -= this.sv.VerticalOffset;
            else
                psY += (this.sv.ActualHeight - this.sv.ExtentHeight) / 2;
            this.sv.ChangeView(pi.X * factor - psX, pi.Y * factor - psY, factor);
        }

        public void ZoomTo(Point point)
        {
            this.ZoomTo(point, 2);
        }

        public void ZoomTo(float factor)
        {
            double w, h;
            if(this.sv.ScrollableWidth > 0)
                w = (this.sv.ActualWidth / 2 + this.sv.HorizontalOffset) / this.sv.ZoomFactor;
            else
                w = this.gd_ContentRoot.ActualWidth / 2;
            if(this.sv.ScrollableHeight > 0)
                h = (this.sv.ActualHeight / 2 + this.sv.VerticalOffset) / this.sv.ZoomFactor;
            else
                h = this.gd_ContentRoot.ActualHeight / 2;
            this.ZoomTo(new Point(w, h), factor);
        }

        private void Zoom(Point p)
        {
            if(this.sv.ZoomFactor > 1.001)
                ResetZoom();
            else
                this.ZoomTo(p);
        }

        public void ResetZoom()
        {
            this.sv.ChangeView(null, null, 1);
        }

        protected override async void OnDoubleTapped(DoubleTappedRoutedEventArgs e)
        {
            base.OnDoubleTapped(e);
            var point = e.GetPosition(this.gd_ContentRoot);
            await Task.Yield();
            this.Zoom(point);
        }

        protected override void OnKeyDown(KeyRoutedEventArgs e)
        {
            base.OnKeyDown(e);
            e.Handled = true;
            switch(e.Key)
            {
            case Windows.System.VirtualKey.GamepadY:
            case (Windows.System.VirtualKey)221:
                ZoomTo(this.sv.ZoomFactor * 1.2f);
                break;
            case Windows.System.VirtualKey.GamepadX:
            case (Windows.System.VirtualKey)219:
                ZoomTo(this.sv.ZoomFactor / 1.2f);
                break;
            case Windows.System.VirtualKey.Up:
            case Windows.System.VirtualKey.Down:
                if(this.sv.ScrollableHeight < 1)
                    e.Handled = false;
                break;
            case Windows.System.VirtualKey.Left:
            case Windows.System.VirtualKey.Right:
                if(this.sv.ScrollableWidth < 1)
                    e.Handled = false;
                break;
            case Windows.System.VirtualKey.Space:
                if(this.spacePressed)
                    e.Handled = false;
                else
                {
                    Zoom(new Point(this.gd_ContentRoot.ActualWidth / 2, this.gd_ContentRoot.ActualHeight / 2));
                    this.spacePressed = true;
                    e.Handled = true;
                }
                break;
            default:
                e.Handled = false;
                break;
            }
        }

        protected override void OnKeyUp(KeyRoutedEventArgs e)
        {
            base.OnKeyUp(e);
            e.Handled = true;
            switch(e.Key)
            {
            case (Windows.System.VirtualKey)187:
                ZoomTo(this.sv.MaxZoomFactor);
                break;
            case (Windows.System.VirtualKey)189:
                ResetZoom();
                break;
            case Windows.System.VirtualKey.Space:
                this.spacePressed = false;
                e.Handled = false;
                break;
            default:
                e.Handled = false;
                break;
            }
        }

        private bool spacePressed;
    }
}
