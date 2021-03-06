using System.Collections.Generic;
using DIP.Domain;

namespace DIP
{
    internal class KitService
    {
        private KitRepository repository;

        public KitService()
        {
            repository = new KitRepository();
        }

        internal double CalculateKitPriceWithTax(Kit kit)
        {
            if (kit == null) return 0;

            const double Tax = 0.21;
            return kit.Price * Tax;
        }

        internal bool SaveKit(Kit kit)
        {
            //Validate product
            if (kit == null || kit.KitId < 0 || string.IsNullOrEmpty(kit.Code))
            {
                return false;
            }

            repository.SaveKit(kit);

            return true;
        }

        internal List<Kit> ListKits()
        {
            return repository.ListKits();
        }
    }
}