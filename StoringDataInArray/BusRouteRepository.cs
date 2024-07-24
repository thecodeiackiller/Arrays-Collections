using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringDataInArray
{
    public class BusRouteRepository
    {
        public static List<BusRoute> InitializeRoutes()
        {
            List<BusRoute> result = new List<BusRoute>();
            result.Add(new BusRoute(40, new string[] {"Morecambe", "Lancaster", "Garstang", "Preston" }));
            result.Add(new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }));
            result.Add(new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" }));
            result.Add(new BusRoute(555, new string[] { "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }));
            result.Add(new BusRoute(1000, new string[] {"Test origin", "Test destination"}));
   
              
            return result;
        }
    }
}
