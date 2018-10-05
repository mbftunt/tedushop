using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisitorStatictisRepositoty : IRepository<VisitorStatistic> { }
    public class VisitorStatictisRepositoty:RepositoryBase<VisitorStatistic>
    {
        public VisitorStatictisRepositoty(DbFactory db) : base(db) { }
    }
}
