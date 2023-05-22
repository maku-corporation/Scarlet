using System.Runtime.Serialization;

namespace Domain.Core.Coupons
{
    [Serializable]
    internal class RandomGeneratorException : Exception
    {
        private string v1;
        private int minValue;
        private string v2;

        public RandomGeneratorException()
        {
        }

        public RandomGeneratorException(string? message) : base(message)
        {
        }

        public RandomGeneratorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public RandomGeneratorException(string v1, int minValue, string v2)
        {
            this.v1 = v1;
            this.minValue = minValue;
            this.v2 = v2;
        }

        protected RandomGeneratorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}