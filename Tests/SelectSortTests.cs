namespace Tests {
    using System.Collections.Generic;
    using Implementations;
    using Xunit;

    public class SelectSortTests
    {
        [Fact]
        public void SelectSort_UnorderedList_Sorted()
        {
            var result = SelectSort.Sort(new List<int> {0, 10, -5, 4, 2, 8});
            Assert.Equal(new List<int> {-5, 0, 2, 4, 8 ,10}, result);
        }

        [Fact]
        public void SelectSort_ShortList_Sorted()
        {
            var result = SelectSort.Sort(new List<int> {10, -10});
            Assert.Equal(new List<int> {-10, 10}, result);
        }

        [Fact]
        public void SelectSort_EmptyList_Sorted()
        {
            var result = SelectSort.Sort(new List<int> ());
            Assert.Empty(result);
        }
    }
}
