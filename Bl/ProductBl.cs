using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;

namespace Bl
{
    public class ProductBl
    {
        public static List<ProductDto> GetProducts(int catgId)
        {
            //products from dataBase for certain category
            List<Product> products = ProductDal.GetProducts(catgId);
            List<ProductDto> dtoProducts = new List<ProductDto>();
            //converting Dal Object to Dto
            for (int i = 0; i < products.Count; i++)
            {
                dtoProducts.Add(new ProductDto(products[i]));
            }
            return dtoProducts;
        }
        public static ProductDto GetProduct(int id)
        {
            //products from dataBase for certain category
            Product product = ProductDal.GetProduct(id);
            ProductDto dtoProduct = new ProductDto(product);
            //converting Dal Object to Dto
            return dtoProduct;
        }

    }
}
