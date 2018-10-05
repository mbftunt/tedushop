﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IMenuRespository : IRepository<Menu> { }
    public class MenuRespository:RepositoryBase<Menu>, IMenuRespository
    {
        public MenuRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
