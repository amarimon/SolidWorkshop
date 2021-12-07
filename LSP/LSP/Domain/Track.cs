using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Domain
{
    class Track
    {
        public Coordinate OriginCoordinate { get; set; }

        public Coordinate DestinationCoordinate { get; set; }

        public double Distance { get; set; }
    }
}
