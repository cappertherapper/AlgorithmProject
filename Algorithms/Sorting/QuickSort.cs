/// <summary>
/// QuickSort Algorithm
/// </summary>
/// <remarks>
/// Advantages:
/// - Often faster in practice than other O(n^2) algorithms like BubbleSort and InsertionSort.
/// - In-place sorting with O(log n) additional space (for the recursive stack).
/// - Has an average-case time complexity of O(n log n).
/// - Can be parallelized due to its divide-and-conquer nature.
///
/// Disadvantages:
/// - Worst-case time complexity is O(n^2), though this can be mostly avoided with a good pivot selection strategy.
/// - Not stable (might not retain order of equal elements).
/// - The depth of the recursive call stack can be O(n) in the worst case, which can lead to stack overflow for very large arrays unless a version with iterative partitioning is used.
/// </remarks>

namespace AlgorithmComparison.Algorithms.Sorting
{
    public class QuickSort : BaseSort
    {
        public override void Sort(int[] array)
        {
            ValidateInput(array);
            QuickSorter(array, 0, array.Length - 1);
        }
        public void QuickSorter(int[] array, int low, int hi)
        {
            if (low < hi)
            {
                int pivot_location = Partition(array, low, hi);
                QuickSorter(array, low, pivot_location - 1);
                QuickSorter(array, pivot_location + 1, hi);
            }
        }

        private int MedianOfThree(int[] array, int low, int hi)
        {
            int mid = (low + hi) / 2;
            if (array[low] > array[hi])
                (array[low], array[hi]) = (array[hi], array[low]);
            if (array[mid] > array[hi])
                (array[mid], array[hi]) = (array[hi], array[mid]);
            if (array[low] > array[mid])
                (array[low], array[mid]) = (array[mid], array[hi]);
            return mid;
        }

        public int Partition(int[] array, int low, int hi)
        {
            int medianIndex = MedianOfThree(array, low, hi);
            (array[low], array[medianIndex]) = (array[medianIndex], array[low]);  // Move median to the first position to act as pivot
            int pivot = array[low];
            int leftWall = low;

            for (int i = low + 1; i <= hi; i++)
            {
                if (array[i] < pivot)
                {
                    leftWall++;
                    (array[leftWall], array[i]) = (array[i], array[leftWall]);
                }
            }
            (array[leftWall], array[low]) = (array[low], array[leftWall]);
            return leftWall;

        }
    }
}