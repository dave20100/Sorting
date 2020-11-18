using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sorting
{
    class Sorter
    {
        private Func<List<int>, Task<List<int>>> SortingAlgorithm;

        public Sorter()
        {
            this.SortingAlgorithm = SortingAlgorithms.Bogo;
        }

        public void SetSortingAlgorithm(Func<List<int>, Task<List<int>>> sortingAlgorithm)
        {
            this.SortingAlgorithm = sortingAlgorithm;
        }

        public Task<List<int>> Sort(List<int> array)
        {
            return SortingAlgorithm?.Invoke(array);
        }
    }
}
