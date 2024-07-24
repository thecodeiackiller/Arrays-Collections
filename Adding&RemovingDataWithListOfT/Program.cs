using StoringDataInArray;

namespace Adding_RemovingDataWithListOfT
{
    internal class Program
    {
        // We have referenced the StoringDataInArray Class Library after converting the initial project to a class library. 
        static void Main(string[] args)
        {
            List<BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();

            Console.WriteLine($"Before: There are {allRoutes.Count} routes:");
            foreach (BusRoute route in allRoutes)
                Console.WriteLine($"Route: {route}");

            // If we wanted to remove an particular element from the list, we could use allRoutes.RemoveAt(2)
            // Often, though, we won't know the particular index at which we want to remove something - will need to iterate here most likely but there is probably already a method for this
            allRoutes.RemoveAt(4);
            // What we really need is RemoveAll. This method takes in a predicate
            // Remove all removes every element that satisfies some condition
            // We need to pass a predicate to identity which element need to be removed
            allRoutes.RemoveAll(route => route.Origin.StartsWith("This "));


            Console.WriteLine($"\r\nAfter: There are {allRoutes.Count} routes:");
            foreach (BusRoute route in allRoutes)
                Console.WriteLine($"Route: {route}");
            // This code seems like it solved the problem upon running it in the console, but all is not what it seems.
        }
        // Notes: Adding and removing from Lists, because of how they're structures under the hood, can be slow.
        // This is because the List is actually implemented using an internal array
        // There are other collections in C# that are actually better than Lists and Arrays for frequently removing and adding items.
    }
}
