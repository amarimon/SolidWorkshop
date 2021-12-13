namespace ISP.Domain
{
    public class Labour
    {
        string code { get; set; }
        string description { get; set; }
        double units{ get; set; }
        double price { get; set; }

        public double GetTotalAmount()
        {
            if (this.units == null || this.units == 0)
                return 0;

            return (double)(this.price * this.units);
        }
    }
}