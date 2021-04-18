using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.Navigation.History;
using System;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels.Base
{
    public delegate TTabViewModel CreateTabViewModel<TTabViewModel>(object args = null) where TTabViewModel : TabViewModelBase;

    public abstract class TabViewModelBase : ViewModelBase
    {
        private readonly ITabItemHistory _tabItemHistory;

        private string _header;
        public string Header { get => _header; set => Set(ref _header, value); }

        private string _shortHeader;
        public string ShortHeader { get => _shortHeader; set => Set(ref _shortHeader, value); }

        public TabViewModelBase CurrentViewModel => _tabItemHistory.Current.ViewModel;

        public ICommand MovePreviousTabNodeCommand { get; init; }
        public ICommand MoveNextTabNodeCommand { get; init; }

        protected TabViewModelBase()
        {
            _tabItemHistory = new TabItemHistory(this);
            _tabItemHistory.HistoryChanged += OnTabNodeChanged;
            MovePreviousTabNodeCommand = new MovePreviousTabNodeCommand(_tabItemHistory);
            MoveNextTabNodeCommand = new MoveNextTabNodeCommand(_tabItemHistory);
        }

        private void OnTabNodeChanged(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public override void Dispose()
        {
            _tabItemHistory.HistoryChanged -= OnTabNodeChanged;
            base.Dispose();
        }
    }
}