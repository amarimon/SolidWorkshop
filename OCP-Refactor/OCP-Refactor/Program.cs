using OCP_Refactor.Domain;
using System;

namespace OCP_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var workfile = new Workfile();

            var kit = new Kit
            {
                Total = 10.0,
                Code = "Kit1"
            };

            var offer = new Offer
            {
                Total = 7.5,
                Code = "Offer1"
            };

            var manualKit = new ManualKit
            {
                Total = 15,
                Code = "ManualKit"
            };

            double costOne = workfile.CalculateTotal(kit);
            Console.WriteLine($"Workfile kit cost: {costOne} €");

            double costTwo = workfile.CalculateTotal(offer);
            Console.WriteLine($"Workfile offer cost: {costTwo} €");

            double costThree = workfile.CalculateTotal(manualKit);
            Console.WriteLine($"Workfile manualKit cost: {costThree} €");

            Console.ReadLine();
        }
    }
}
