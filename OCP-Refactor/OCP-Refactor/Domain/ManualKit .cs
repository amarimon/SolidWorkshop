namespace OCP_Refactor.Domain
{
    internal class ManualKit : Element
    {
        public ManualKit()
        {
            this.ElementType = Type.ManualKit;
        }

        public override double CalculateCost()
        {
            return Total * 1.15;
        }
    }
}
