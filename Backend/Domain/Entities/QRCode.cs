using Interfaces.DataInterfaces;

namespace Domain.Entities
{
    public class QRCode : IEntity
    {
        public string Url { get; private set; }
    }
}
