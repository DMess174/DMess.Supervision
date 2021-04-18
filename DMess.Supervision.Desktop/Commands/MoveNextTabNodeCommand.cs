using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.Navigation.History;

namespace DMess.Supervision.Desktop.Commands
{
    public class MoveNextTabNodeCommand : CommandBase
    {
        private readonly ITabItemHistory _tabItemHistory;

        public MoveNextTabNodeCommand(ITabItemHistory tabItemHistory)
        {
            _tabItemHistory = tabItemHistory;
        }

        public override bool CanExecute(object parameter)
        {
            return _tabItemHistory.CanMoveForward;
            //return true;
        }

        public override void Execute(object parameter)
        {
            _tabItemHistory.MoveForward();
        }
    }
}
