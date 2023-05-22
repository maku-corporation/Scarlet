using Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.VOne
{
    [Table("Address")]
    public class Address : IEntity
    {
        [Key]
        public int AddressID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; init; }
        public Customer Customer { get; set; }
    }
}
