using AutoMapper;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class SubdivisionDepartmentProfile : Profile
    {
        public SubdivisionDepartmentProfile()
        {
            CreateMap<SubdivisionDepartment, SubdivisionDepartmentDTO>();

            CreateMap<SubdivisionDepartmentDTO, SubdivisionDepartment>();
        }
    }
}
