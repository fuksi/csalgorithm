namespace Implementations
{
    using System.Collections.Generic;
    using Implementation;

    public static class SelectSort
    {
        public static List<int> Sort(List<int> input)
        {
            for (var i = 0; i < input.Count - 1; i++)
            {
                var imin = i;
                for (var j = i + 1; j < input.Count; j++)
                {
                    if (input[j] < input[imin])
                    {
                        imin = j;
                    }
                }

                input.Swap(i, imin);
            }
            return input;
        }
    }
}
