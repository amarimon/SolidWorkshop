using System.Collections.Generic;
using DIP_Refactor.Domain;

namespace DIP_Refactor
{
    internal class KitService
    {
        private IKitRepository repository;

        public KitService(IKitRepository repository)
        {
            this.repository = repository; //<-- ULL no fem new, injectem la dependència, de fet, la invertim
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