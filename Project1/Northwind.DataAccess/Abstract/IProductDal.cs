using Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GettAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
