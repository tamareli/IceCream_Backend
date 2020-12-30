using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CategoryDal
    {
        public static List<Category> GetProductsCategories()
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {

                var categories = db.GetProductsCategoriesFun();//stored Procedure
                return categories.ToList<Category>();
            }
        }
        public static List<Category> GetCatgsToppingsForCatgProduct(int catgProductId)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {

                var categories = db.GetCatgsToppingsForCatgProductFun(catgProductId);//storedProcedure
                return categories.ToList<Category>();
            }
        }
        public static Category GetCategory(int id)
        {
            using (IceCreamEntities db = new IceCreamEntities())
            {

                var category = db.GetCategoryFun(id);
                return category.FirstOrDefault();
            }
        }
    }
}
