using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DomainModel;

namespace WebAPI.Repositories.RepositoryInterface
{
   public interface IProductRepository
    {
       void AddNewProduct(ProductModel product);
       List<ProductModel> GetAllProducts();
    }
}
