using DMess.Supervision.Desktop.ViewModels.Base;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DMess.Supervision.Desktop.Navigation.History
{
    public class TabItemHistory : ITabItemHistory
    {
        public bool CanMoveBack => Current.PreviousNode != null;

        public bool CanMoveForward => Current.NextNode != null;

        public TabItemNode Current { get; private set; }

        public event EventHandler HistoryChanged;

        public TabItemHistory(TabViewModelBase viewModel)
        {
            var head = new TabItemNode(viewModel);
            Current = head;
        }

        public void Add(TabViewModelBase viewModel)
        {
            var newNode = new TabItemNode(viewModel);

            Current.NextNode = newNode;
            newNode.PreviousNode = Current;

            Current = newNode;

            OnHistoryChanged();
        }

        public void MoveBack()
        {
            var previousNode = Current.PreviousNode;

            Current = previousNode;

            OnHistoryChanged();
        }

        public void MoveForward()
        {
            var nextNode = Current.NextNode;

            Current = nextNode;

            OnHistoryChanged();
        }

        public IEnumerator<TabItemNode> GetEnumerator()
        {
            yield return Current;
        }

        private void OnHistoryChanged() => HistoryChanged?.Invoke(this, EventArgs.Empty);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}