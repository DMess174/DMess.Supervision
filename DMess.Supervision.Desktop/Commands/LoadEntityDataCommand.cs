using System.Threading.Tasks;
using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Models;
using DMess.Supervision.Shared.Services.Base;

namespace DMess.Supervision.Desktop.Commands
{
    public class LoadEntityDataCommand<T> : AsyncCommand where T : ValidatableObject, new()
    {
        private readonly IEntityViewModel<T> _viewModel;
        private readonly ILoadEntityService<T> _loadEntityService;
        private readonly string _entityId;

        public LoadEntityDataCommand(ILoadEntityService<T> loadEntityService, IEntityViewModel<T> viewModel, string entityId)
        {
            _viewModel = viewModel;
            _entityId = entityId;
            _loadEntityService = loadEntityService;
        }

        public override bool CanExecute(object parameter)
        {
            return _viewModel.IsLoaded;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _viewModel.IsLoaded = false;

            if (_entityId is null)
            {
                _viewModel.Item = new T();
                _viewModel.IsLoaded = true;
                return;
            }

            _viewModel.Item = await _loadEntityService.LoadDataAsync(_entityId).ConfigureAwait(false);

            _viewModel.IsLoaded = true;
        }
    }
}
