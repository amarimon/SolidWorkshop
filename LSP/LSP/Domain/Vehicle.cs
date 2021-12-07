using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Domain
{
    class Vehicle
    {
        public string PlateNumber { get; private set; }
        public double Odometer { get; protected set; }
        protected List<Track> tracks;

        public Vehicle(string plateNumber, double odometer)
        {
            PlateNumber = plateNumber;
            Odometer = odometer;
            tracks = new List<Track>();
        }

        public virtual void AddTrack(Track newTrack)
        {
            tracks.Add(newTrack);
        }
    }
}
