namespace OCP_Refactor.Domain
{
    internal class Kit : Element
    {
        public Kit()
        {
            this.ElementType = Type.Kit;
        }

        public override double CalculateCost()
        {
            return Total;
        }
    }
}
