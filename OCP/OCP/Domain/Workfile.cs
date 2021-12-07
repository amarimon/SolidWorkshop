using System;

namespace OCP
{
    internal class Workfile
    {
        public Workfile()
        {
        }

        internal double CalculateTotal(Element element)
        {
            if (element == null) return -1;

            double result = 0;

            switch (element.ElementType)
            {
                case Element.Type.Kit:
                    result = element.Total;

                    break;
                case Element.Type.Offer:
                    result = element.Total*0.9;
                    break;

                /// Cada vegada que afegim un nou tipus d'element... hem de modificar-la classe
            }

            return result;
        }
    }
}