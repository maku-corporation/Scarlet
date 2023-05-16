using Interfaces.DataInterfaces;

namespace Domain.Entities
{
    public class Barcode : IEntity
    {
        public int ID { get; set; }
        public string BarcodeText { get; set; }
    }
}
