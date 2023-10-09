using AlgorithmComparison.Algorithms.Sorting;


internal class Program
{
    private static void Main(string[] args)
    {
        ISort sorter = new QuickSort();

        int[] arr = { 5, 4, 8, 2, 1 };

        sorter.Sort(arr);

        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
    }
}