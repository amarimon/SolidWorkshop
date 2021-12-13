using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Domain
{
    class Kit : IImputableElement, IImputablePartsElement
    {
        string code { get; set; }
        string description { get; set; }
        double units { get; set; }
        double price { get; set; }

        IEnumerable<Sparepart> spareparts { get; set; }
        IEnumerable<Labour> labours { get; set; }

        public double CalculateLaboursPrice(IEnumerable<Labour> labours)
        {
            return labours.Sum(item => item.GetTotalAmount());

        }

        public double CalculateSparepartsPrice(IEnumerable<Sparepart> labours)
        {
            return spareparts.Sum(item => item.GetTotalAmount());
        }

        public double CalculateTotalPrice()
        {
            return units * price;
        }
    }
}
