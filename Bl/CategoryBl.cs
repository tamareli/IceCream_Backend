using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bl
{
    public class CategoryBl
    {
        public static List<CategoryDto> GetProductsCategories()
        {
            //categories from dataBase
            List<Category> categories = CategoryDal.GetProductsCategories();
            List<CategoryDto> dtoCategories = new List<CategoryDto>();
            for (int i = 0; i < categories.Count; i++)
            {
                dtoCategories.Add(new CategoryDto(categories[i]));
            }
            return dtoCategories;
        }
        public static List<CategoryDto> GetCatgsToppingsForCatgProduct(int catgProductId)
        {
            //categories from dataBase
            List<Category> categories = CategoryDal.GetCatgsToppingsForCatgProduct(catgProductId);
            List<CategoryDto> dtoCategories = new List<CategoryDto>();
            for (int i = 0; i < categories.Count; i++)
            {
                dtoCategories.Add(new CategoryDto(categories[i]));
            }
            return dtoCategories;
        }
        public static CategoryDto GetCategory(int id)
        {
            Category category = CategoryDal.GetCategory(id);
            CategoryDto dtoCategory = new CategoryDto(category);
            //converting Dal Object to Dto
            return dtoCategory;
        }

    }
}
