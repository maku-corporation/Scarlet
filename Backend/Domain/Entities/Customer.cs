using Interfaces.DataInterfaces;

namespace Domain.Entities
{
    public class Customer : IEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public Address Address { get; private set; } = new Address();
        public BillingAddress BillingAddress { get; set; } = new BillingAddress();
        public Metadata Metadata { get; private set; } = new Metadata();
    }
}
