﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IceCreamEntities : DbContext
    {
        public IceCreamEntities()
            : base("name=IceCreamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<DeliveriesType> DeliveriesTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderToProduct> OrderToProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }
        public virtual DbSet<ToppingsForProduct> ToppingsForProducts { get; set; }
    
        public virtual ObjectResult<GetProductsCategories_Result> GetProductsCategories()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProductsCategories_Result>("GetProductsCategories");
        }
    
        public virtual ObjectResult<Category> GetProductsCategoriesFun()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Category>("GetProductsCategoriesFun");
        }
    
        public virtual ObjectResult<Category> GetProductsCategoriesFun(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Category>("GetProductsCategoriesFun", mergeOption);
        }
    
        public virtual ObjectResult<GetProductsByCatgId_Result> GetProductsByCatgId(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProductsByCatgId_Result>("GetProductsByCatgId", categoryIdParameter);
        }
    
        public virtual ObjectResult<Product> GetProductsByCatgIdFun(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("GetProductsByCatgIdFun", categoryIdParameter);
        }
    
        public virtual ObjectResult<Product> GetProductsByCatgIdFun(Nullable<int> categoryId, MergeOption mergeOption)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("GetProductsByCatgIdFun", mergeOption, categoryIdParameter);
        }
    
        public virtual ObjectResult<GetProductById_Result> GetProductById(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("productId", productId) :
                new ObjectParameter("productId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProductById_Result>("GetProductById", productIdParameter);
        }
    
        public virtual ObjectResult<Product> GetProductByIdFun(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("productId", productId) :
                new ObjectParameter("productId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("GetProductByIdFun", productIdParameter);
        }
    
        public virtual ObjectResult<Product> GetProductByIdFun(Nullable<int> productId, MergeOption mergeOption)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("productId", productId) :
                new ObjectParameter("productId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("GetProductByIdFun", mergeOption, productIdParameter);
        }
    
        public virtual ObjectResult<GetCatgsToppingsForCatgProduct_Result1> GetCatgsToppingsForCatgProduct(Nullable<int> categoryProduct)
        {
            var categoryProductParameter = categoryProduct.HasValue ?
                new ObjectParameter("categoryProduct", categoryProduct) :
                new ObjectParameter("categoryProduct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCatgsToppingsForCatgProduct_Result1>("GetCatgsToppingsForCatgProduct", categoryProductParameter);
        }
    
        public virtual ObjectResult<Category> GetCatgsToppingsForCatgProductFun(Nullable<int> categoryProduct)
        {
            var categoryProductParameter = categoryProduct.HasValue ?
                new ObjectParameter("categoryProduct", categoryProduct) :
                new ObjectParameter("categoryProduct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Category>("GetCatgsToppingsForCatgProductFun", categoryProductParameter);
        }
    
        public virtual ObjectResult<Category> GetCatgsToppingsForCatgProductFun(Nullable<int> categoryProduct, MergeOption mergeOption)
        {
            var categoryProductParameter = categoryProduct.HasValue ?
                new ObjectParameter("categoryProduct", categoryProduct) :
                new ObjectParameter("categoryProduct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Category>("GetCatgsToppingsForCatgProductFun", mergeOption, categoryProductParameter);
        }
    
        public virtual ObjectResult<GetToppingsById_Result> GetToppingsById(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetToppingsById_Result>("GetToppingsById", categoryIdParameter);
        }
    
        public virtual ObjectResult<Topping> GetToppingsbyIdFun(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Topping>("GetToppingsbyIdFun", categoryIdParameter);
        }
    
        public virtual ObjectResult<Topping> GetToppingsbyIdFun(Nullable<int> categoryId, MergeOption mergeOption)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Topping>("GetToppingsbyIdFun", mergeOption, categoryIdParameter);
        }
    
        public virtual ObjectResult<GetToppingsForCatgProduct_Result> GetToppingsForCatgProduct(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetToppingsForCatgProduct_Result>("GetToppingsForCatgProduct", categoryIdParameter);
        }
    
        public virtual ObjectResult<Topping> GetToppingsForCatgProductFun(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Topping>("GetToppingsForCatgProductFun", categoryIdParameter);
        }
    
        public virtual ObjectResult<Topping> GetToppingsForCatgProductFun(Nullable<int> categoryId, MergeOption mergeOption)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Topping>("GetToppingsForCatgProductFun", mergeOption, categoryIdParameter);
        }
    
        public virtual ObjectResult<GetSizesByCatgId_Result> GetSizesByCatgId(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSizesByCatgId_Result>("GetSizesByCatgId", categoryIdParameter);
        }
    
        public virtual ObjectResult<Size> GetSizesByCatgIdFun(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Size>("GetSizesByCatgIdFun", categoryIdParameter);
        }
    
        public virtual ObjectResult<Size> GetSizesByCatgIdFun(Nullable<int> categoryId, MergeOption mergeOption)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Size>("GetSizesByCatgIdFun", mergeOption, categoryIdParameter);
        }
    }
}