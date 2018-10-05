using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order : ISeotable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(512)]
        public string CustomerAddress { get; set; }
        [Required]
        [MaxLength(512)]
        public string CustomerEmail { get; set; }
        [MaxLength(1024)]
        public string CustomerMessage { get; set; }
        [MaxLength(256)]
        public string PaymentMethod { get; set; }
        [MaxLength(256)]
        public string PaymentStatus { get; set; }
    }
}