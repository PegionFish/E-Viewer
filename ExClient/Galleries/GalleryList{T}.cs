﻿using Opportunity.MvvmUniverse.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Data;

namespace ExClient.Galleries
{
    internal abstract class GalleryList<TGallery, TModel> : ObservableList<Gallery>, IItemsRangeInfo
         where TGallery : Gallery
    {
        private int loadedCount;

        internal GalleryList(List<TModel> models)
            : base(Enumerable.Repeat<TGallery>(null, models.Count))
        {
            var end = Math.Min(models.Count, 10);
            for (var i = 0; i < end; i++)
            {
                this[i] = Load(models[i]);
                models[i] = default;
                loadedCount++;
            }
            this.models = models;
        }

        private readonly List<TModel> models;

        protected override void ClearItems()
        {
            models.Clear();
            loadedCount = 0;
            base.ClearItems();
        }

        protected override void RemoveItem(int index)
        {
            models.RemoveAt(index);
            if (this[index] != null)
            {
                loadedCount--;
            }

            base.RemoveItem(index);
        }

        void IItemsRangeInfo.RangesChanged(ItemIndexRange visibleRange, IReadOnlyList<ItemIndexRange> trackedItems)
        {
            if (loadedCount == models.Count)
            {
                return;
            }
            var ranges = trackedItems.Concat(Enumerable.Repeat(visibleRange, 1)).ToList();
            var start = ranges.Min(r => r.FirstIndex);
            var end = ranges.Max(r => r.LastIndex) + 1;
            if (start < 0)
            {
                start = 0;
            }

            if (end > Count)
            {
                end = Count;
            }

            for (var i = start; i < end; i++)
            {
                if (this[i] != null)
                {
                    continue;
                }

                this[i] = Load(models[i]);
                models[i] = default;
                loadedCount++;
            }
        }

        protected abstract TGallery Load(TModel model);

        void IDisposable.Dispose() { Clear(); }
    }
}
