using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Models;
using DMess.Supervision.Shared.Services.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace DMess.Supervision.Desktop.Commands
{
    /// <summary>
    /// Load collection of entities command implementation
    /// </summary>
    /// <typeparam name="T">Entity (ValidatableObject)</typeparam>
    public class LoadCollectionDataCommand<T> : AsyncCommand where T: ValidatableObject
    {
        private readonly ICollectionViewModel<T> _collectionViewModel;
        private readonly ILoadCollectionService<T> _loadCollectionService;

        public LoadCollectionDataCommand(ILoadCollectionService<T> loadCollectionService, ICollectionViewModel<T> collectionViewModel)
        {
            _loadCollectionService = loadCollectionService;
            _collectionViewModel = collectionViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return _collectionViewModel.IsLoaded;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _collectionViewModel.IsLoaded = false;

            _collectionViewModel.Items = new ObservableCollection<T>(await _loadCollectionService.LoadDataAsync());

            _collectionViewModel.IsLoaded = true;
        }
    }
}
