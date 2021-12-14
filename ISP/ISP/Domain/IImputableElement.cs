using System.Collections.Generic;

namespace ISP.Domain
{
    internal interface IImputableElement
    {
        public double CalculateLaboursPrice(IEnumerable<Labour> labours);

        public double CalculateSparepartsPrice(IEnumerable<Sparepart> spareparts);

        public double CalculateTotalPrice();
    }
}