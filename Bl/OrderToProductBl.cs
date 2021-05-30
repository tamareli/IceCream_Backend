using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;

namespace Bl
{
    public class OrderToProductBl
    {
        public static bool addOrdersProducts(List<OrderToProductDto> orderItems, int orderId)
        {
            bool b = false;
            foreach (var item in orderItems)
            {
                OrderToProduct op = OrderToProductDto.ToDal(item, orderId);
                b = OrderToProductDal.addOrderItem(op);
                bool c = OrderToProductToToppingBl.addToppingsToProductInOrder(item.toppings, op.OrderToProductId);
            }
            return b;
        }
        public static List<OrderToProductDto> GetOrderToProduct(int orderId)
        {
            List<OrderToProduct> products = OrderToProductDal.GetProductsInOrder(orderId);
            List<OrderToProductDto> dtoProducts = new List<OrderToProductDto>();
            for (int i = 0; i < products.Count; i++)
            {
                OrderToProductDto product = new OrderToProductDto(products[i]);
                product.toppings = OrderToProductToToppingBl.GetOrderToProductToppings(products[i].OrderToProductId);
                using (IceCreamEntities db = new IceCreamEntities())
                {
                    product.productName = db.Products.Where(x => x.productId == product.productId).FirstOrDefault().productName;
                    product.sizeName = db.Sizes.Where(x => x.sizeId == product.sizeId).FirstOrDefault().sizeName;
                    product.image = db.Products.Where(x => x.productId == product.productId).FirstOrDefault().image;
                }
                dtoProducts.Add(product);
            }
            return dtoProducts;
        }
    }
}
