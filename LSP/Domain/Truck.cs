using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Domain
{
    class Truck : Vehicle
    {
        public Truck(string plateNumber, double odometer) : base(plateNumber, odometer)
        {
        }

        public override void AddTrack(Track newTrack)
        {
            base.AddTrack(newTrack);

            //Update odometer.
            foreach (var trip in tracks)
            {
                Odometer += trip.Distance;
            }
        }
    }
}
