using LSP.Domain;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            const double InitialDistance = 10000;
            
            Vehicle vehicle = new Vehicle("ABC123", InitialDistance);

            //Change the instantiated class to Truck to see LSP violation.
            //Truck vehicle = new Truck("ABC123", InitialDistance);

            vehicle.AddTrack(new Track
            {
                OriginCoordinate = new Coordinate(0,0),
                DestinationCoordinate = new Coordinate(10,15),
                Distance = 60
            });

            if (vehicle.Odometer == InitialDistance)
            {
                Console.WriteLine("Odometer is correct.");
            }
            else
            {
                Console.WriteLine("Odometer has been modified.");
            }

            Console.ReadLine();
        }
    }
}
