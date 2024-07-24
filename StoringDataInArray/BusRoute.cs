using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringDataInArray
{
    public class BusRoute
    {
        public int Number { get; }
        public string Origin => PlacesServed[0];
        public string Destination => PlacesServed[PlacesServed.Length - 1];
        public string[] PlacesServed { get; }

        public BusRoute(int number, string[] placesServed)
        {
            this.Number = number;
            this.PlacesServed = placesServed;
        }

        public bool Serves(string destination)
        {
            return Array.Exists(PlacesServed, places => places == Destination);
            // Rather than returning the value it finds, Exists returns only whether or not it could find the value in the array
            //foreach (string place in PlacesServed)
            //{
            //    if(place == destination)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
        public override string ToString() => $"{Number}: {Origin} -> {Destination}";
    }
}
