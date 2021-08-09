using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Desktop.Navigation
{
    public interface ITabViewModelFactory
    {
        TabViewModelBase CreateTabViewModel(TabViewType tabViewType, EntityDTO entity = null);
    }
}
