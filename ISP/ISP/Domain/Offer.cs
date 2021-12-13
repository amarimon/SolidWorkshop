using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Domain
{
    class Offer : IImputableElement
    {
        string code { get; set; }
        string description { get; set; }
        double units { get; set; }
        double price { get; set; }

        public double CalculateLaboursPrice(IEnumerable<Labour> labours)
        {
            //return 0;
            throw new NotImplementedException();
        }

        public double CalculateSparepartsPrice(IEnumerable<Sparepart> labours)
        {
            //return 0;
            throw new NotImplementedException();
        }

        public double CalculateTotalPrice()
        {
            return units * price;
        }
    }
}
