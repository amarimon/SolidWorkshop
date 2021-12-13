using System.Collections.Generic;

namespace ISP.Domain
{
    internal interface IImputablePartsElement
    {
        public double CalculateLaboursPrice(IEnumerable<Labour> labours);

        public double CalculateSparepartsPrice(IEnumerable<Sparepart> labours);
    }
}