using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page:ISeotable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name{ get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { get; set; }
        [Required]
        public string Content{ get; set; }
        
    }
}
