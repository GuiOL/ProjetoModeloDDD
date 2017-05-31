using System.Collections.Generic;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productSerivce;

        public ProductAppService(IProductService productSerivce)
            : base(productSerivce)
        {
            _productSerivce = productSerivce;
        }

        public IEnumerable<Product> FindByName(string name)
        {
            return _productSerivce.FindByName(name);
        }
    }
}
