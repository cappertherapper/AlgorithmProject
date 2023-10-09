namespace AlgorithmComparison.Algorithms.Sorting
{
    public abstract class BaseSort : ISort
    {
        protected void ValidateInput(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Input array cannot be null.");
            }
            if (array.Length == 0)
            {
                return; // Nothing to sort.
            }
        }

        public abstract void Sort(int[] array);
    }
}