using Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.VOne
{
    [Table("Value")]
    public class Value : IEntity
    {
        [Key]
        public int ValueID { get; set; }
        public long Amount { get; set; }
        public long Balance { get; set; }
        public string Currency { get; set; }

        [ForeignKey("CouponID")]
        public int CouponID { get; init; }
        public Coupon Coupon { get; set; }
    }
}
