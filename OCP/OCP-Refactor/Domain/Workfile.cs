namespace OCP_Refactor
{
    internal class Workfile
    {
        public Workfile()
        {
        }

        internal double CalculateTotal(Element element)
        {
            if (element == null) return 0;

            return element.CalculateCost();
        }
    }
}