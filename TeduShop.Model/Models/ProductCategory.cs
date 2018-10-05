using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory:ISeotable 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public int ParrentID { get; set; }
        public int DisplayOrder { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Product> Product { get; set; }
    }
}
