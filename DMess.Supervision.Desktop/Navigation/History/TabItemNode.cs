using DMess.Supervision.Desktop.ViewModels.Base;
using System;
using System.Collections.Generic;

namespace DMess.Supervision.Desktop.Navigation.History
{

    public class TabItemNode
    {
        public TabItemNode PreviousNode { get; set; }
        public TabItemNode NextNode { get; set; }
        public TabViewModelBase ViewModel { get; }

        public TabItemNode(TabViewModelBase viewModel)
        {
            ViewModel = viewModel;
        }
    }
}
