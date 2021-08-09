using AutoMapper;
using DMess.Supervision.CommonModel.Models;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class SubdivisionProfile : Profile
    {
        public SubdivisionProfile()
        {
            CreateMap<Subdivision, SubdivisionDTO>();

            CreateMap<SubdivisionDTO, Subdivision>();
        }
    }
}
