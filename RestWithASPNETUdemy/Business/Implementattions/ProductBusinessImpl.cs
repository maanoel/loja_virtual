using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Data.Converters;
using LojaVirtual.Data.VO;
using LojaVirtual.Model;
using LojaVirtual.Repository.Generic;

namespace LojaVirtual.Business.Implementations
{
    public class ProductBusinessImpl : IProductBusiness
    {
        private IProductRepository _repository;
        private readonly ProductConverter _converter;

        public ProductBusinessImpl(IProductRepository repository)
        {
            _repository = repository;
            _converter = new ProductConverter();
        }

        public ProductVO Create(ProductVO product)
        {
            var productEntity = _converter.Parse(product);
            productEntity = _repository.Create(productEntity);
            return _converter.Parse(productEntity);
        }

        public void Delete(long id)
        {
          
        }

        public List<ProductVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public ProductVO FindById(long id)
        {
            return null;
        }

        public ProductVO Update(ProductVO book)
        {
            return null;
        }
    }
}
