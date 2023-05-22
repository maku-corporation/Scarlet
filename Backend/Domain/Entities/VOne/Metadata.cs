using Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.VOne
{
    [Table("Metadata")]
    public class Metadata : IEntity
    {
        [Key]
        public int MetadataID { get; set; }

        [ForeignKey("CouponID")]
        public int CouponID { get; init; }
        public Coupon Coupon { get; set; }
    }
}
