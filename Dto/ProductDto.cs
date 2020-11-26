using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class ProductDto
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public int categoryId { get; set; }
        public bool active { get; set; }
        public int order { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string image { get; set; }

        public ProductDto(Product p)
        {
            productId = p.productId;
            productName = p.productName;
            description = p.description;
            categoryId = p.categoryId;
            active = p.active;
            order = p.order;
            createDate = p.createDate;
            updateDate = p.updateDate;
            image = p.image;
        }
        public ProductDto()
        {

        }
        //public static Category Todal(CategoryDto catg)
        //{
        //    return new Category
        //    {
        //        categoryId = catg.categoryId,
        //        categoryName = catg.categoryName,
        //        categoryType = catg.categoryType,
        //        freeToppingsForSaucesAmount = catg.freeToppingsForSaucesAmount,
        //        freeToppingsForOthersAmount = catg.freeToppingsForOthersAmount,
        //        active = catg.active,
        //        order = catg.order,
        //        createDate = catg.createDate,
        //    };
        //}
}
}
