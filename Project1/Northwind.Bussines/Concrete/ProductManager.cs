using System.Collections.Generic;
using Northwind.Bussines.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.Bussines.Concrete
{
   public class ProductManager:IProductService
   {
       private IProductDal _productDal;

       public ProductManager(IProductDal productDal)
       {
           _productDal = productDal;
       }

       public List<Product> GettAll()
        {//Business code
            return _productDal.GettAll();
        }
   }
}
