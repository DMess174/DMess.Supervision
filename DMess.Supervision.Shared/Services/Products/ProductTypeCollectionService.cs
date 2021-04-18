using AutoMapper;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.Shared.Models.DTOs;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Products
{
    public class ProductTypeCollectionService : IProductTypeCollectionService
    {
        private readonly IMapper _mapper;
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypeCollectionService(IMapper mapper, IProductTypeRepository productTypeRepository)
        {
            _mapper = mapper;
            _productTypeRepository = productTypeRepository;
        }

        public async Task<IEnumerable<ProductTypeDTO>> LoadDataAsync()
        {
            var result = await _productTypeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductTypeDTO>>(result);
        }

        //TODO : Произвести проверку работоспособности метода и сравнить производительность с аналогичным
        //public async IAsyncEnumerable<ProductTypeDTO> GetAllAsync()
        //{
        //    var result = await _productTypeRepository.GetAllAsync();

        //    foreach(var item in result)
        //    {
        //        yield return _mapper.Map<ProductTypeDTO>(item);
        //    }
        //}
    }
}
