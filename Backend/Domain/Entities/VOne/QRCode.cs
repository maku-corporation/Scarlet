using Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.VOne
{
    [Table("QRCode")]
    public class QRCode : IEntity
    {
        [Key]
        public int QRCodeID { get; set; }
        public string Url { get; set; }
    }
}
