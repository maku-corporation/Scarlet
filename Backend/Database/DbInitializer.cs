using Database.Context;
using Domain.Entities;
using Domain.Entities.VOne;

namespace Database
{
    public static class DbInitializer
    {
        public static void Initialize(ScarletContext context)
        {
            context.Database.EnsureCreated();

            if(context.Coupons.Any())
            {
                return;
            }

            var coupons = new Coupon[]
            {
                GenerateCoupon("DMSL"),
                GenerateCoupon("FADS"),
                GenerateCoupon("EWDQ"),
                GenerateCoupon("GGRE"),
                GenerateCoupon("PLDM")
            };

            context.AddRange(coupons);
            context.SaveChanges();
        }

        public static Coupon GenerateCoupon(string code)
        {
            return new Coupon()
            {
                Code = code,
                Category = "E-mail targets",
                Value = new Value()
                {
                    Amount = 100,
                    Balance = 100,
                    Currency = "DKK"
                },
                StartDate = DateTime.Now,
                ExpirationDate = DateTime.Now,
                Active = true,
                Customer = new Customer()
                {
                    Address = new Address()
                    {
                        City = "Glostrup",
                        Country = "Denmark",
                        Line1 = "Stadionvej 93",
                        Line2 = "1. tv.",
                        PostalCode = "2600",
                        State = "København"
                    },
                    Description = "Lorem ipsum",
                    Email = "abrek.okur@hotmail.com",
                    Name = "Abrek Okur",
                    Phone = "+4530867038"
                },
                CouponAssets = new CouponAssets()
                {
                    Barcode = new Barcode()
                    {
                        BarcodeText = "r12r23rmkl2nbrj1kb234r"
                    },
                    QRCode = new QRCode()
                    {
                        Url = "https://www.google.dk"
                    },
                },
                AdditionalInfo = "Lorem ipsum",
                Metadata = new Metadata(),
                IsReferralCode = true
            };
        }
    }
}
