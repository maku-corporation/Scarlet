using Interfaces.DataInterfaces;

namespace Domain.Entities
{
    public class CouponAssets : IEntity
    {
        public int ID { get; set; }
        public QRCode QRCode { get; private set; } = new QRCode();
        public Barcode Barcode { get; private set; } = new Barcode();
    }
}
