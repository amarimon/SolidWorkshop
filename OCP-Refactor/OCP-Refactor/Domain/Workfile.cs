namespace OCP_Refactor
{
    internal class Workfile
    {
        public Workfile()
        {
        }

        internal double CalculateTotal(Element element)
        {
            if (element == null) return -1;

            return element.CalculateCost();
        }
    }
}