using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public Plane MyPlane { get; set; }
        public IList<Passenger> Passengers { get; set; }

        //methods
        public override string ToString()
        {
            return $"FlightId: {FlightId}, Departure: {Departure}, Destination: {Destination}, " +
                   $"FlightDate: {FlightDate.ToShortDateString()}, EffectiveArrival: {EffectiveArrival.ToShortDateString()}, " +
                   $"EstimatedDuration: {EstimatedDuration} minutes";
        }


    }
}
