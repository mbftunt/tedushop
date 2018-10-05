using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductCategoryRespository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRespository : RepositoryBase<ProductCategory>, IProductCategoryRespository
    {
        public ProductCategoryRespository(IDbFactory dbFactory) 
            : base(dbFactory) 
        {

        }
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(_ => _.Alias == alias);
        }
    }
}