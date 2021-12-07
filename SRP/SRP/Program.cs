using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new KitService();

            var kit = new Kit
            {
                KitId = 1,
                Code = "KIT001",
                Price = 10.0
            };

            Console.WriteLine(service.CalculateKitPriceWithTax(kit));

            service.SaveKit(kit);

            var kits = service.ListKits();
            foreach (var currentKit in kits)
            {
                Console.WriteLine($"Id: {kit.KitId}, name: {kit.Code}");
            }

            Console.ReadKey();
        }
    }
}
