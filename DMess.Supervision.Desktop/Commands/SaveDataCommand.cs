using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Services.Base;
using System.Threading.Tasks;

namespace DMess.Supervision.Desktop.Commands
{
    public class SaveDataCommand<T> : AsyncCommand
    {
        private ViewModelBase _viewModel;
        private ISaveDataService<T> _saveDataService;

        public SaveDataCommand(ViewModelBase viewModel, ISaveDataService<T> saveDataService)
        {
            _viewModel = viewModel;
            _saveDataService = saveDataService;
        }

        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter);
        }
        public override async Task ExecuteAsync(object parameter)
        {
            if (parameter is T entity)
                await _saveDataService.SaveDataAsync(entity);
        }
    }
}
