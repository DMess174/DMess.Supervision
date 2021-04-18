using DMess.Supervision.Shared.Models.DTOs;
using System;

namespace DMess.Supervision.Desktop.State.Accounts
{
    public interface IAccountStore
    {
        AccountDTO CurrentAccount { get; set; }
        FactoryDTO CurrentFactory { get; set; }
        
        event Action StateChanged;
    }
}
