using DMess.Supervision.Shared.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels.Base
{
    /// <summary>
    /// View model contract to have a collection of entity
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    public interface ICollectionViewModel<T> where T: ValidatableObject
    {
        IEnumerable<T> Items { get; set; }

        bool IsLoaded { get; set; }

        ICommand LoadDataCommand { get; init; }
    }
}
