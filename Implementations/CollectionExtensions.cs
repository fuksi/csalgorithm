using System.Collections.Generic;

namespace Implementation {
    public static class CollectionExtensions {
        public static void Swap<T>(this IList<T> list, int indexA, int indexB) {
            var temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
        }
    }
}