using Interfaces.Core;
using System.Security.Cryptography;

namespace Domain.Core.Coupons
{
    /// <summary>
    /// https://github.com/rebeccapowell/csharp-algorithm-coupon-code/blob/master/src/Powells.CouponCode/SecureRandom.cs
    /// </summary>
    public class RandomGenerator : IRandomGenerator
    {
        /// <summary>
        /// The random number generator.
        /// </summary>
        private readonly RandomNumberGenerator rng = RandomNumberGenerator.Create();

        /// <summary>
        /// The next.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public virtual int Next()
        {
            var data = new byte[sizeof(int)];
            this.rng.GetBytes(data);
            return BitConverter.ToInt32(data, 0) & (int.MaxValue - 1);
        }

        /// <summary>
        /// The next.
        /// </summary>
        /// <param name="maxValue">
        /// The max value.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public virtual int Next(int maxValue)
        {
            return this.Next(0, maxValue);
        }

        /// <summary>
        /// The next.
        /// </summary>
        /// <param name="minValue">The min value.</param>
        /// <param name="maxValue">The max value.</param>
        /// <returns>
        /// The <see cref="int" />.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">minValue cannot be greater than maxValue</exception>
        public virtual int Next(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                throw new RandomGeneratorException("minValue", minValue, "minValue cannot be greater than maxValue");
            }

            return (int)Math.Floor((minValue + ((double)maxValue) - minValue) * this.NextDouble());
        }

        /// <summary>
        /// The next double.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public virtual double NextDouble()
        {
            var data = new byte[sizeof(uint)];
            this.rng.GetBytes(data);
            var randUint = BitConverter.ToUInt32(data, 0);
            return randUint / (uint.MaxValue + 1.0);
        }

        /// <summary>
        /// The get bytes.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public virtual void GetBytes(byte[] data)
        {
            this.rng.GetBytes(data);
        }

        /// <summary>
        /// The get non zero bytes.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public virtual void GetNonZeroBytes(byte[] data)
        {
            this.rng.GetNonZeroBytes(data);
        }
    }
}
