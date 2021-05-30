using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dto
{
    public class CategoryDto
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string categoryType { get; set; }
        public Nullable<int> freeToppingsForSaucesAmount { get; set; }
        public Nullable<int> freeToppingsForOthersAmount { get; set; }
        public bool active { get; set; }
        public int order { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
        public string image { get; set; }

        public CategoryDto(Category catg)
        {
            categoryId = catg.categoryId;
            categoryName = catg.categoryName;
            categoryType = catg.categoryType;
            freeToppingsForSaucesAmount = catg.freeToppingsForSaucesAmount;
            freeToppingsForOthersAmount = catg.freeToppingsForOthersAmount;
            active = catg.active;
            order = catg.order;
            createDate = catg.createDate;
            updateDate = catg.updateDate;
            image = catg.image;
        }
        public CategoryDto()
        {

        }
        public static Category Todal(CategoryDto catg)
        {
            return new Category
            {
            categoryId = catg.categoryId,
            categoryName = catg.categoryName,
            categoryType = catg.categoryType,
            freeToppingsForSaucesAmount = catg.freeToppingsForSaucesAmount,
            freeToppingsForOthersAmount = catg.freeToppingsForOthersAmount,
            active = catg.active,
            order = catg.order,
            createDate = catg.createDate,
        };
        }
        }
    }

