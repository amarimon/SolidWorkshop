namespace OCP_Refactor
{
    abstract class Element : ICalculateCost
    {
        public enum Type : short //<--- potser ja no caldria
        { 
            Kit = 1,
            Offer = 2,
            ManualKit = 3
        }

        public Type ElementType { get; set; }
        public double Total { get; set; }
        public string Code { get; set; }

        public abstract double CalculateCost();
    }
}