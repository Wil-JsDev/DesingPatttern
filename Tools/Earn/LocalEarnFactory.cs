
namespace Tools.Earn
{
    public class LocalEarnFactory : EarnFactory
    {
        private decimal _percentage;

        public LocalEarnFactory(decimal percentage)
        {
            _percentage = percentage;
        }

        public override IEarn GetEarn()
        {
            return new LocalEarn(_percentage);
        }
    }
}
