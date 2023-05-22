using System.Runtime.Serialization;

namespace Database.Repositories
{
    [Serializable]
    internal class RapositoryNullException : Exception
    {
        public RapositoryNullException()
        {
        }

        public RapositoryNullException(string? message) : base(message)
        {
        }

        public RapositoryNullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RapositoryNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}