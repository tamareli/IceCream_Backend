using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Bl;


namespace IceCream_Back.Controllers
{
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("categories")]
        public IHttpActionResult GetProductsCategories()
        {
            var categories = CategoryBl.GetProductsCategories();
            if (categories != null)
                return Ok(categories);
            else
                return BadRequest();
        }

        [HttpGet]
        [Route("toppingsCategoriesForProductCategory/{id}")]
        public IHttpActionResult GetCatgsToppingsForCatgProduct(int id)
        {
            var categories = CategoryBl.GetCatgsToppingsForCatgProduct(id);
            if (categories != null)
                return Ok(categories);
            else
                return BadRequest();
        }
    }
}
