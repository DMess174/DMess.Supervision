using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Base;

namespace DMess.Supervision.Shared.Services.Employees
{
    public interface IEmployeeService : ILoadEntityService<EmployeeDTO>, ISaveDataService<EmployeeDTO>
    {
    }
}