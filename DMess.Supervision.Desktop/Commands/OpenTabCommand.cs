using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.ViewModels;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Desktop.Commands
{
    public class OpenTabCommand : CommandBase
    {
        private readonly TabItemsViewModel _tabsViewModel;
        private readonly ITabViewModelFactory _tabViewModelFactory;

        public OpenTabCommand(ITabViewModelFactory tabViewModelFactory, TabItemsViewModel tabsViewModel)
        {
            _tabsViewModel = tabsViewModel;
            _tabViewModelFactory = tabViewModelFactory;
        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (parameter is object[] values)
            {
                if (values[0] is TabViewType tabViewType)
                {
                    if (values[1] is EntityDTO entity)
                        OpenTab(tabViewType, entity);
                    else
                        OpenTab(tabViewType);
                }
            }
            else if (parameter is TabViewType tabViewType)
            {
                OpenTab(tabViewType);
            }
        }

        public void OpenTab(TabViewType tabViewType, EntityDTO entity = null)
        {
            _tabsViewModel.Tabs.Add(_tabViewModelFactory.CreateTabViewModel(tabViewType, entity));
        }
    }
}
