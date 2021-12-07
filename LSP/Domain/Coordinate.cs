namespace LSP.Domain
{
    public class Coordinate
    {
        private double latitude { get; set; }
        private double longitude { get; set; }

        public Coordinate(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}