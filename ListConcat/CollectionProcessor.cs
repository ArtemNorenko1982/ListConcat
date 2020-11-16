using System.Collections.Generic;
using System.Linq;

namespace ListConcat
{
    public static class CollectionProcessor
    {
        public static IEnumerable<string> HandleCollection(this ICollection<string> collection, string pattern, int countOption)
        {
            var resultCollection = new List<string>();
            for (var i = 0; i < collection.Count;)
            {
                if (collection.ElementAt(i).Contains(pattern))
                {
                    if (i + countOption <= collection.Count - 1)
                    {
                        resultCollection.Add(string.Concat(collection.Skip(i).Take(countOption)));
                        i += countOption;
                    }
                    else
                    {
                        var countToTake = collection.Count - i;
                        resultCollection.Add(string.Concat(collection.Skip(i).Take(countToTake)));
                        i += countToTake;
                    }
                }
                else
                {
                    resultCollection.Add(collection.ElementAt(i));
                    i++;
                }
            }

            return resultCollection;
        }
    }
}
