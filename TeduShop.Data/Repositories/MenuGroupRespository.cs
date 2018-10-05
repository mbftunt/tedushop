using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IMenuGroupRespository : IRepository<MenuGroup> { }
    public class MenuGroupRespository:RepositoryBase<MenuGroup>,IMenuGroupRespository
    {
        public MenuGroupRespository(IDbFactory dbFactory):base(dbFactory){ }
    }
}
