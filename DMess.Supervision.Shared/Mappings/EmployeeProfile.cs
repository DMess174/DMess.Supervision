using AutoMapper;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(x => x.FullName, o => o.Ignore());

            CreateMap<EmployeeDTO, Employee>();
        }
    }
}