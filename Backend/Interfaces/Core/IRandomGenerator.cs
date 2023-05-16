namespace Interfaces.Core
{
    public interface IRandomGenerator
    {
        void GetBytes(byte[] data);
        void GetNonZeroBytes(byte[] data);
        int Next();
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
        double NextDouble();
    }
}