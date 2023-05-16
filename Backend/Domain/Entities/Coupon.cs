using Interfaces.Core;
using Interfaces.DataInterfaces;

namespace Domain.Entities
{
    public class Coupon : ICoupon, IEntity
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public string Campaign { get; private set; }

        public string CampaignId { get; private set; }

        public string Category { get; private set; }

        public Value Value { get; private set; }

        public DateTime? StartDate { get; private set; }

        public DateTime? ExpirationDate { get; private set; }

        public bool Active { get; private set; }

        public CouponAssets Assets { get; private set; }

        public string AdditionalInfo { get; private set; }

        public Metadata Metadata { get; private set; }

        public bool IsReferralCode { get; private set; }
    }
}
