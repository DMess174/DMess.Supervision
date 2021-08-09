using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.ViewModels;
using DMess.Supervision.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace DMess.Supervision.Desktop.Commands
{
    public class CloseTabCommand : AsyncCommand
    {
        private readonly TabItemsViewModel _tabItemsViewModel;

        public CloseTabCommand(TabItemsViewModel tabItemsViewModel)
        {
            _tabItemsViewModel = tabItemsViewModel;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            if (parameter is TabViewModelBase viewModel)
            {
                int currentTabIndex = _tabItemsViewModel.Tabs.IndexOf(viewModel);

                if (currentTabIndex <= 0) return;

                _tabItemsViewModel.CurrentTab = _tabItemsViewModel.Tabs[currentTabIndex - 1];

                _tabItemsViewModel.Tabs.Remove(viewModel);
            }

        }
    }
}
