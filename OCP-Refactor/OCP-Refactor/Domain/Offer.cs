using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Refactor.Domain
{
    internal class Offer : Element
    {
        public Offer()
        {
            this.ElementType = Type.Offer;
        }

        public override double CalculateCost()
        {
            return Total * 0.9;
        }
    }
}
