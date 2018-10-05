﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRespository { }
   public class OrderRespository:RepositoryBase<Order>, IOrderRespository
    {
        public OrderRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
