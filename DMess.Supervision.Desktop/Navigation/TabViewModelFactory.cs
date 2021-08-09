using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Desktop.ViewModels.Tabs.Employees;
using DMess.Supervision.Desktop.ViewModels.Tabs.Products;
using DMess.Supervision.Shared.Models.DTOs;
using System;

namespace DMess.Supervision.Desktop.Navigation
{
    public class TabViewModelFactory : ITabViewModelFactory
    {
        private readonly CreateTabViewModel<ProductTypesViewModel> _createProductTypesViewModel;
        private readonly CreateTabViewModel<EmployeeCollectionViewModel> _createEmployeeCollectionViewModel;

        public TabViewModelFactory(CreateTabViewModel<ProductTypesViewModel> createProductTypesViewModel, CreateTabViewModel<EmployeeCollectionViewModel> createEmployeeCollectionViewModel)
        {
            _createProductTypesViewModel = createProductTypesViewModel;
            _createEmployeeCollectionViewModel = createEmployeeCollectionViewModel;
        }

        public TabViewModelBase CreateTabViewModel(TabViewType tabViewType, EntityDTO entity = null)
        {
            return tabViewType switch
            {
                TabViewType.ProductTypes => _createProductTypesViewModel(entity),
                TabViewType.EmployeeList => _createEmployeeCollectionViewModel(entity),
                _ => throw new ArgumentException("The TabViewType does not have a ViewModel.", nameof(tabViewType)),
            };
        }
    }
}
