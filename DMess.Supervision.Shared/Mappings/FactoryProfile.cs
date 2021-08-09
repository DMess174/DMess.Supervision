using AutoMapper;
using DMess.Supervision.CommonModel.Models.Factories;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class FactoryProfile : Profile
    {
        public FactoryProfile()
        {
            CreateMap<Factory, FactoryDTO>();

            CreateMap<FactoryDTO, Factory>();
        }
    }
}
