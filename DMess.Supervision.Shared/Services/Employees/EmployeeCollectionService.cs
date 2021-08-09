using AutoMapper;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.Shared.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Employees
{
    public class EmployeeCollectionService : IEmployeeCollectionService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeCollectionService(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDTO>> LoadDataAsync()
        {
            var result = await _employeeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EmployeeDTO>>(result);
        }
    }
}
