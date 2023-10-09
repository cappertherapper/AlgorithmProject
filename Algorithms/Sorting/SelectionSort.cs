
namespace AlgorithmComparison.Algorithms.Sorting
{
    public class SelectionSort : BaseSort
    {
        public override void Sort(int[] array)
        {
            ValidateInput(array);
            int len = array.Length;
            for (int j = 0; j < len - 1; j++)
            {
                int minIndex = j;

                for (int i = j + 1; i < len; i++)
                {
                    if (array[i] <= array[minIndex])
                    {
                        minIndex = i;
                    }
                }

                // Swap the found minimum element with the first element
                if (minIndex != j)
                {
                    (array[j], array[minIndex]) = (array[minIndex], array[j]);
                }
            }
        }
    }
}