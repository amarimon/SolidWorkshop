using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var workfile = new Workfile();

            var kit = new Element
            {
                ElementType = Element.Type.Kit,
                Total = 10.0,
                Code = "Kit1"
            };

            var offer = new Element
            {
                ElementType = Element.Type.Offer,
                Total = 7.5,
                Code = "Offer1"
            };

            double costOne = workfile.CalculateTotal(kit);
            Console.WriteLine($"Workfile element1 cost: {costOne} €");

            double costTwo = workfile.CalculateTotal(offer);
            Console.WriteLine($"Workfile element2 cost: {costTwo} €");

            Console.ReadLine();
        }
    }
}
