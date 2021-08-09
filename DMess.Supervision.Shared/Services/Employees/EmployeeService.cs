using AutoMapper;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.Shared.Models.DTOs;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeDTO> LoadDataAsync(string id)
        {
            var result = await _employeeRepository.GetByIdAsync(id);
            return _mapper.Map<EmployeeDTO>(result);
        }

        public async Task<EmployeeDTO> SaveDataAsync(EmployeeDTO employee)
        {
            var employeeToUpsert = _mapper.Map<Employee>(employee);

            if (string.IsNullOrWhiteSpace(employee.Id))
                employeeToUpsert = await CreateAsync(employeeToUpsert);
            else
                employeeToUpsert = await UpdateAsync(employeeToUpsert);

            return _mapper.Map<EmployeeDTO>(employeeToUpsert);
        }

        private async Task<Employee> UpdateAsync(Employee employee)
        {
            await _employeeRepository.UpdateAsync(employee);
            return employee;
        }

        private async Task<Employee> CreateAsync(Employee employee)
        {
            return await _employeeRepository.CreateAsync(employee);
        }

        
    }
}
