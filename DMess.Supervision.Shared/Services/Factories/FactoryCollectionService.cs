using AutoMapper;
using DMess.Supervision.CommonModel.Repositories;
using DMess.Supervision.Shared.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Factories
{
    public class FactoryCollectionService : IFactoryCollectionService
    {
        private readonly IMapper _mapper;
        private readonly IFactoryRepository _factoryRepository;

        public FactoryCollectionService(IMapper mapper, IFactoryRepository factoryRepository)
        {
            _mapper = mapper;
            _factoryRepository = factoryRepository;
        }

        public async Task<IEnumerable<FactoryDTO>> LoadDataAsync()
        {
            var result = await _factoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<FactoryDTO>>(result);
        }
    }
}
