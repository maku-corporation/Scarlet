using Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.VOne
{
    [Table("Customer")]
    public class Customer : IEntity
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public Address? Address { get; set; }

        public ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();
    }
}
