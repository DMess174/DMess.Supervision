using DMess.Supervision.Shared.Models.DTOs;
using DMess.Supervision.Shared.Services.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Products
{
    public interface IProductTypeService : ILoadEntityService<ProductTypeDTO>, ISaveDataService<ProductTypeDTO>
    {
    }
}
