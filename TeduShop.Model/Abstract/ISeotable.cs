using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public class ISeotable
    {
        [MaxLength(256)]
        string MetaKeyword { get; set; }
        [MaxLength(256)]
        string MetaDescription { get; set; }
        DateTime? CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        Boolean Status { get; set; }

    }
}
