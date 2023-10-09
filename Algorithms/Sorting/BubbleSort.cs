/// <summary>
/// BubbleSort Algorithm
/// </summary>
/// <remarks>
/// Advantages:
/// - Simple to understand and implement.
/// - In-place sorting with O(1) additional space.
/// - Adaptive for partially sorted lists.
/// - Stable sort (retains order of equal elements).
/// - Can sort as it receives input (online).
///
/// Disadvantages:
/// - Inefficient for large lists with O(n^2) worst-case time complexity.
/// </remarks>


namespace AlgorithmComparison.Algorithms.Sorting
{
    public class BubbleSort : BaseSort
    {
        public override void Sort(int[] array)
        {
            ValidateInput(array);
            int maxLoop = array.Length - 1;

            for (int i = 0; i < maxLoop; i++)
            {
                bool swapped = false;
                for (int j = 0; j < maxLoop - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }
    }
}