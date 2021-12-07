namespace OCP
{
    internal class Element
    {
        public enum Type : short 
        { 
            Kit = 1,
            Offer = 2
        }


        public Type ElementType { get; set; }
        public double Total { get; set; }
        public string Code { get; set; }
    }
}