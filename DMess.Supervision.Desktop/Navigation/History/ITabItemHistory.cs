using DMess.Supervision.Desktop.ViewModels.Base;
using System;
using System.Collections.Generic;

namespace DMess.Supervision.Desktop.Navigation.History
{
    public interface ITabItemHistory : IEnumerable<TabItemNode>
    {
        bool CanMoveBack { get; }

        bool CanMoveForward { get; }

        TabItemNode Current { get; }

        event EventHandler HistoryChanged;

        void MoveBack();

        void MoveForward();

        void Add(TabViewModelBase viewModel);
    }
}
