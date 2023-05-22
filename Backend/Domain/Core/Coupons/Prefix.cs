using Interfaces.Core;

namespace Domain.Core.Coupons
{
    public class Prefix : IPrefix
    {
        private readonly IList<string> _wordList = new List<string>()
            {
                "SHPX", "PHAG", "JNAX", "JNAT", "CVFF",
                "PBPX", "FUVG", "GJNG", "GVGF", "SNEG",
                "URYY", "ZHSS", "QVPX", "XABO", "NEFR",
                "FUNT", "GBFF", "FYHG", "GHEQ", "FYNT",
                "PENC", "CBBC", "OHGG", "SRPX", "OBBO",
                "WVFZ", "WVMM", "CUNG", "17PX", "26BO",
                "1HPX", "11AG", "12AX", "21AT", "22FF",
                "2BPX", "9UVG", "13NG", "20GF", "23EG",
                "3RYY", "8HSS", "14PX", "19BO", "24FR",
                "4UNT", "7BFF", "15HG", "18EQ", "25NT",
                "5ENC", "6BBC", "16GG", "26PX", "27BO",
            };

        public virtual string NextPrefix()
        {
            Random random = new Random();
            int randomNumber = random.Next(minValue: 0, maxValue: _wordList.Count);

            return _wordList[randomNumber];
        }
    }
}
