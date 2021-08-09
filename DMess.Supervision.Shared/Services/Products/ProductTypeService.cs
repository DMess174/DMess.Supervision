using AutoMapper;
using DMess.Supervision.CommonModel.Models.Products;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.Shared.Models.DTOs;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Products
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IProductTypeRepository _productTypeRepository;
        private readonly IMapper _mapper;

        public ProductTypeService(IProductTypeRepository productTypeRepository, IMapper mapper)
        {
            _productTypeRepository = productTypeRepository;
            _mapper = mapper;
        }
        public async Task<ProductTypeDTO> LoadDataAsync(string id)
        {
            var result = await _productTypeRepository.GetByIdAsync(id);

            return _mapper.Map<ProductTypeDTO>(result);
        }

        public async Task<ProductTypeDTO> SaveDataAsync(ProductTypeDTO productType)
        {
            var productTypeToUpsert = _mapper.Map<ProductType>(productType);

            if (string.IsNullOrWhiteSpace(productType.Id))
                productTypeToUpsert = await CreateAsync(productTypeToUpsert);
            else
                productTypeToUpsert = await UpdateAsync(productTypeToUpsert);

            return _mapper.Map<ProductTypeDTO>(productTypeToUpsert);
        }

        private async Task<ProductType> UpdateAsync(ProductType productType)
        {
            await _productTypeRepository.UpdateAsync(productType);
            return productType;
        }

        private async Task<ProductType> CreateAsync(ProductType productType)
        {
            return await _productTypeRepository.CreateAsync(productType);
        }
    }
}
