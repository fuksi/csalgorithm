namespace Implementations
{
    using System.Collections.Generic;

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

                var min = input[imin];
                input[imin] = input[i];
                input[i] = min;
            }
            return input;
        }
    }
}
