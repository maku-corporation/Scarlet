using Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.VOne
{
    [Table("Barcode")]
    public class Barcode : IEntity
    {
        [Key]
        public int BarcodeID { get; set; }
        public string BarcodeText { get; set; }
    }
}
