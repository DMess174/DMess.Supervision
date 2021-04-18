using AutoMapper;
using DMess.Supervision.CommonModel.Models.Products;
using DMess.Supervision.Shared.Models.DTOs;

namespace DMess.Supervision.Shared.Mappings
{
    public class ProductTypeProfile : Profile
    {
        public ProductTypeProfile()
        {
            CreateMap<ProductType, ProductTypeDTO>();
            CreateMap<ProductTypeDTO, ProductType>();
        }
    }
}
