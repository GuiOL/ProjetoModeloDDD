using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> FindByName(string name);
    }
}
