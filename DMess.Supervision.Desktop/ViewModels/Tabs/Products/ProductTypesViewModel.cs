using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.Navigation.History;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Products;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels.Tabs.Products
{
    public class ProductTypesViewModel : TabViewModelBase, ICollectionViewModel<ProductTypeDTO>
    {
        #region Private Fields
        private readonly IProductTypeCollectionService _productTypeCollectionService;
        
        private IEnumerable<ProductTypeDTO> _items = new ObservableCollection<ProductTypeDTO>();
        
        private bool _isLoaded;
        
        private ProductTypeDTO _productType;
        #endregion

        #region Public Properties
        public IEnumerable<ProductTypeDTO> Items { get => _items; set => Set(ref _items, value); }
        
        public ProductTypeDTO ProductType { get => _productType; set => Set(ref _productType, value); }
        
        public bool IsLoaded { get => _isLoaded; set => Set(ref _isLoaded, value); }
        #endregion

        #region Commands
        public ICommand LoadDataCommand { get; init; }
        #endregion

        #region Constructors
        public ProductTypesViewModel(IProductTypeCollectionService productTypeCollectionService)
        {
            Header = "Продукция";
            _productTypeCollectionService = productTypeCollectionService;
            LoadDataCommand = new LoadCollectionDataCommand<ProductTypeDTO>(_productTypeCollectionService, this);
        }
        #endregion

        #region Static Methods
        public static ProductTypesViewModel LoadViewModel(IProductTypeCollectionService productTypeCollectionService)
        {
            var vm = new ProductTypesViewModel(productTypeCollectionService);
            vm.LoadDataCommand.Execute(null);
            return vm;
        }
        #endregion
    }
}