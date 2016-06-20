using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DataAccess;
using WebAPI.DomainModel;
using WebAPI.Repositories.RepositoryInterface;

namespace WebAPI.Repositories.RepositoryDefinition
{
    public class ProductRepository : IProductRepository
    {
        SqlConnection con = new SqlConnection(Configuration.ConnectionString);
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter();




        public int AddNewProduct(ProductModel product)
        {
            return 0;
        }


        public List<ProductModel> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
