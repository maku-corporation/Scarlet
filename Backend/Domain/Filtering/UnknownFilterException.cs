using System.Runtime.Serialization;

namespace Domain.Filtering
{
    [Serializable]
    internal class UnknownFilterException : Exception
    {
        public UnknownFilterException()
        {
        }

        public UnknownFilterException(string? message) : base(message)
        {
        }

        public UnknownFilterException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UnknownFilterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}