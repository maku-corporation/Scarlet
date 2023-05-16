using Interfaces.DataInterfaces;

namespace Domain.Entities
{
    public class Address : IEntity
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
