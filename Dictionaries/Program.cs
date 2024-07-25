namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays and Lists are great for index based lookups
            // Dictionaries are great for finding items
            // Arrays can be thought of as a list of objects
            // Dictionaries can be thought of as like a "bag" of objects
            // Using TryGetValue over ContainsKey will probably have a performance benefit because it only looks up the key once

            // If were enumerating through the dictionary, its almost always because we want to see the values within the collection
            // There is a SortedDictionary, but our lives will typically be much easier if we use an ordinary Dictionary.
            // There is also a SortedList, which is basically the same as SortedDictionary. Or, they return the same result.
            // SortedList has, for specific scenarios, a slight performance benefit over SortedDictionary 
            // SortedList, generally speaking, is more efficient is we have already sorted our items before instantiating the SortedList
        }
    }
}
