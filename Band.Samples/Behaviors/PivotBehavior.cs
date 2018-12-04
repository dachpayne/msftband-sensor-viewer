﻿using System.Linq;

using Band.Samples.Helpers;

using Microsoft.Xaml.Interactivity;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Behaviors
{
    public class PivotBehavior : Behavior<Pivot>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.SelectionChanged += OnSelectionChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.SelectionChanged -= OnSelectionChanged;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var removedItem = e.RemovedItems.Cast<PivotItem>()
                .Select(i => i.GetPage<IPivotPage>()).FirstOrDefault();

            var addedItem = e.AddedItems.Cast<PivotItem>()
                .Select(i => i.GetPage<IPivotPage>()).FirstOrDefault();

            if (removedItem != null)
            {
                await removedItem.OnPivotUnselectedAsync();
            }

            if (addedItem != null)
            {
                await addedItem?.OnPivotSelectedAsync();
            }
        }
    }
}
