using AutoMapper;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentDTO>();

            CreateMap<DepartmentDTO, Department>();
        }
    }
}
