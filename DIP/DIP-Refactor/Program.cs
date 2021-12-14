using DIP_Refactor.Domain;
using System;

namespace DIP_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = KitRepositoryFactory.Instance.Get("postgresql");

            var service = new KitService(repository);

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
