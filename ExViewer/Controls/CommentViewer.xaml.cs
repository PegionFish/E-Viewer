﻿using ExClient;
using ExClient.Commenting;
using ExViewer.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ExViewer.Controls
{
    public sealed partial class CommentViewer : UserControl
    {
        public CommentViewer()
        {
            this.InitializeComponent();
        }

        private static EditCommentDialog editDialog = new EditCommentDialog();

        public Comment Comment
        {
            get => (Comment)GetValue(CommentProperty);
            set => SetValue(CommentProperty, value);
        }

        // Using a DependencyProperty as the backing store for Comment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommentProperty =
            DependencyProperty.Register("Comment", typeof(Comment), typeof(CommentViewer), new PropertyMetadata(null, CommentPropertyChanged));

        private static void CommentPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var sender = (CommentViewer)d;
            if (e.NewValue is Comment c)
            {
                if (c.CanEdit)
                {
                    sender.FindName(nameof(AttentionHeader));
                }
            }
            if (sender.Translated != null)
                sender.Translated.HtmlContent = null;
        }

        protected override void OnDisconnectVisualChildren()
        {
            this.ClearValue(CommentProperty);
            base.OnDisconnectVisualChildren();
        }

        private void UserControl_FocusEngaged(Control sender, FocusEngagedEventArgs args)
        {
            FindName(nameof(this.EngagementIndicator));
        }

        private async void VoteUp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await this.Comment.VoteAsync(ExClient.Api.VoteCommand.Up);
            }
            catch (Exception ex)
            {
                RootControl.RootController.SendToast(ex, typeof(GalleryPage));
            }
        }

        private async void VoteDown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await this.Comment.VoteAsync(ExClient.Api.VoteCommand.Down);
            }
            catch (Exception ex)
            {
                RootControl.RootController.SendToast(ex, typeof(GalleryPage));
            }
        }

        private void VotePopUp_Opened(object sender, object e)
        {
            ((Popup)sender).Child.DescendantsAndSelf<Control>().First().Focus(FocusState.Programmatic);
        }

        private async void Edit_Click(object sender, RoutedEventArgs e)
        {
            editDialog.EditableComment = this.Comment;
            await editDialog.ShowAsync();
        }

        private void WithdrawVote_Click(object sender, RoutedEventArgs e)
        {
            switch (this.Comment.Status)
            {
            case CommentStatus.VotedUp:
                VoteUp_Click(sender, e);
                break;
            case CommentStatus.VotedDown:
                VoteDown_Click(sender, e);
                break;
            }
        }
        
        private void Reply_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Translate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var r = await this.Comment.TranslateAsync(Strings.Resources.Controls.CommentViewer.TranslateLanguageCode);
                FindName(nameof(Translated));
                this.Bindings.Update();
                this.Translated.HtmlContent = r;
            }
            catch (Exception ex)
            {
                RootControl.RootController.SendToast(ex, null);
            }
        }
    }
}
