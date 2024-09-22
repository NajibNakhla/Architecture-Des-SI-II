using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boeing,
        Airbus
    }
    public class Plane
    {
        public int PlaneId { get; set; }
        public int Capacity { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public IList<Flight> Flights { get; set; }
        //constructeur parametre
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            MyPlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
            Flights = new List<Flight>();
        }


        //methods
        public override string ToString()
        {
            return $"PlaneId: {PlaneId}, Capacity: {Capacity}, PlaneType: {MyPlaneType}, " +
                   $"ManufactureDate: {ManufactureDate.ToShortDateString()}";
        }



    }

}
