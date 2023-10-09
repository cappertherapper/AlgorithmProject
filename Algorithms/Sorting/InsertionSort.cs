/// <summary>
/// InsertionSort Algorithm
/// </summary>
/// <remarks>
/// Advantages:
/// - Simple to understand and implement.
/// - In-place sorting with O(1) additional space.
/// - Adaptive for nearly sorted lists (can become O(n) if the list is almost sorted).
/// - Stable sort (retains order of equal elements).
/// - Works well for small lists.
///
/// Disadvantages:
/// - Inefficient for large lists with O(n^2) worst-case time complexity.
/// </remarks>


namespace AlgorithmComparison.Algorithms.Sorting
{
    public class InsertionSort : BaseSort
    {
        public override void Sort(int[] array)
        {
            ValidateInput(array);
            int len = array.Length;
            for (int current = 1; current < len; current++)
            {
                int currentValue = array[current];
                int previous = current - 1;

                // Move elements of array[0...current-1] that are greater than currentValue
                // to one position ahead of their current position
                while (previous >= 0 && array[previous] > currentValue)
                {
                    array[previous + 1] = array[previous];
                    previous--;
                }
                array[previous + 1] = currentValue;
            }
        }
    }
}
