using AutoMapper;
using DMess.Supervision.CommonModel.Models.Customers;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDTO>();

            CreateMap<CustomerDTO, Customer>();
        }
    }
}
