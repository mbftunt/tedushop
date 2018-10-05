using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostCategoryRespository:IRepository<PostCategory> { }
    public class PostCategoryRespository:RepositoryBase<PostCategory>, IPostCategoryRespository
    {
        public PostCategoryRespository(DbFactory db) : base(db) { }
    }
}
