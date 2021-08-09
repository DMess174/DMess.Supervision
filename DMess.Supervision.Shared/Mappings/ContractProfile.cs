using AutoMapper;
using DMess.Supervision.CommonModel.Models.Contracts;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<Contract, ContractDTO>();

            CreateMap<ContractDTO, Contract>();
        }
    }
}
