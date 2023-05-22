using Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.VOne
{
    [Table("CouponAssets")]
    public class CouponAssets : IEntity
    {
        [Key]
        public int CouponAssetsID { get; set; }
        public QRCode QRCode { get; set; }
        public Barcode Barcode { get; set; }

        [ForeignKey("CouponID")]
        public int CouponID { get; init; }
        public Coupon Coupon { get; set; }
    }
}
