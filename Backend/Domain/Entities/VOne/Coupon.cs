using Interfaces.Core;
using Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.VOne
{
    [Table("Coupon")]
    public class Coupon : ICoupon, IEntity
    {
        [Key]
        public int CouponID { get; set; }

        public string Code { get; set; }

        public string Category { get; set; }

        public virtual Value? Value { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public bool Active { get; set; }

        public virtual CouponAssets? CouponAssets { get; set; }

        public string AdditionalInfo { get; set; }

        public virtual Metadata? Metadata { get; set; }

        public bool IsReferralCode { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
