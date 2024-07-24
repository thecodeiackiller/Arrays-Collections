//using System.Security.Cryptography.X509Certificates;

//namespace StoringDataInArray
//{
//    internal class Program
//    {
//        // Looked into different properties and methods within the base .NET class array including Find, FindAll, Length, and Exists
//        static void Main(string[] args)
//        {
//            List<BusRoute> Allroutes = BusRouteRepository.InitializeRoutes();
//            Console.WriteLine("Where do you want to go?");
//            string location = Console.ReadLine();


//            // BusRoute[] routes = FindBusesRoute(Allroutes,location);

//            if(routes.Length > 0)
//            {
//                foreach(BusRoute route in routes)
//                {
//                    Console.WriteLine($"Go ahead and get on {route}!");
//                }
                
//            }
//            else
//            {
//                Console.WriteLine($"Sorry, you're stuck. No routes go to {location}");
//            }

//        }
//        // Finding data in an array
//        public static BusRoute[] FindBusesRoute(BusRoute[] routes, string location)
//        {
//            // All C# arrays provide a property called Find(), which allows us to do exactly what we've done below with the foreach loop. 
//            // The Find() method can take in a lambda expression, as seen below.
//            // The reason for lambdas is that it makes code easier to read? Less typing?

//            return Array.FindAll(routes,route => route.Serves(location));

//            //foreach(var route in routes)
//            //{
//            //    if(route.Destination == location || route.Origin == location)
//            //    {
//            //        return route;
//            //    }
//            //}
//            //return null;
//        }
//    }
//}
