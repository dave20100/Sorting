using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting
{
    class SortingAlgorithms
    {
        public static event EventHandler<ElementsEventArgs> OnChange;
        public static bool IsCanceled = false;

        private static bool IsSorted(List<int> array)
        {
            for(int i = 0; i < array.Count-1; i++)
            {
                if(array[i] > array[i+1])
                {
                    return false;
                }
            }
            return true;
        }


        static public async Task<List<int>> Bubble (List<int> array)
        {
            IsCanceled = false;
            int iterationCount = 1;
            while(!IsSorted(array))
            {
                for(int i = 0; i < array.Count - 1; i++)
                {
                    if(IsCanceled)
                    {
                        return null;
                    }
                    if (array[i] > array[i + 1])
                    {
                        (array[i + 1], array[i]) = (array[i], array[i + 1]);
                        OnChange?.Invoke(null, new ElementsEventArgs(array, iterationCount));
                        await Task.Delay(1);
                    }
                }
                iterationCount++;
            }
            return array;
        }

        static public async Task<List<int>> Insertion(List<int> array)
        {
            IsCanceled = false;
            int iterationCount = 1;
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (IsCanceled)
                    {
                        return null;
                    }
                    if (array[j - 1] > array[j])
                    {
                        (array[j - 1], array[j]) = (array[j], array[j - 1]);
                        OnChange?.Invoke(null, new ElementsEventArgs(array, iterationCount));
                        await Task.Delay(1);
                    }
                }
                iterationCount++;
            }
            return array;
        }

        static public async Task<List<int>> Bogo(List<int> array)
        {
            IsCanceled = false;
            int iterationCount = 1;
            while (!IsSorted(array))
            {
                if (IsCanceled)
                {
                    return null;
                }
                array = array.OrderBy(x => Guid.NewGuid()).ToList();
                OnChange?.Invoke(null, new ElementsEventArgs(array, iterationCount));
                await Task.Delay(1);
                iterationCount++;
            }
            return array;
        }

        
    }
}
