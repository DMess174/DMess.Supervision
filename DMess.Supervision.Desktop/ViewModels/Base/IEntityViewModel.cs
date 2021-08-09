using System.Windows.Input;
using DMess.Supervision.Shared.Models;

namespace DMess.Supervision.Desktop.ViewModels.Base
{
    public interface IEntityViewModel<T> where T : ValidatableObject
    {
        T Item { get; set; }

        bool IsLoaded { get; set; }

        ICommand LoadDataCommand { get; init; }
    }
}
