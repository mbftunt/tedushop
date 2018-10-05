﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag> { }
    public class TagRepository:RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(DbFactory db):base(db){ }
    }
}
