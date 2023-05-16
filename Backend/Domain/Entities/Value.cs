using Interfaces.DataInterfaces;

namespace Domain.Entities
{
    public class Value : IEntity
    {
        public int ID { get; set; }
        public long Amount { get; set; }
        public long Balance { get; set; }
        public string Currency { get; set; }
    }
}
