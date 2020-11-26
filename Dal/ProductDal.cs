using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ProductDal
    {
        public static List<Product> GetProducts(int catgId)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var products = db.GetProductsByCatgIdFun(catgId);
                return products.ToList<Product>();
            }
        }
        public static Product GetProduct(int id)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {
                var product = db.GetProductByIdFun(id);
                return product.FirstOrDefault();
            }
        }
    }
}
