using System;
using System.Collections.Generic;

namespace ListConcat
{
    class Program
    {
        static readonly List<string> Collection = new List<string>
            {
                "call-log",
                "call-log",
                "call-log",
                "item_04",
                "item_05",
                "item_06",
                "some else data",
                "call-log",
                "item_09",
                "item_10",
                "string",
                "call-log",
                "call-log",
                "call-log",
                "call-log",
            };

        static void Main(string[] args)
        {
            // skip atual item and next two
            var skipNextItems = 3;
            // pattern to compare
            var pattern = "call-log";

            var result = Collection.HandleCollection(pattern, skipNextItems);

            Console.WriteLine("Hello World!");
        }
    }
}
