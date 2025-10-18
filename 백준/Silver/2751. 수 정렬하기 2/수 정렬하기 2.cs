using System.Text;

class Backjoon
{
    static Random rand = new Random();
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        MyQuickSort(arr, 0, count - 1);

        foreach (var t in arr)
            sb.AppendLine($"{t}");
        Console.Write(sb.ToString().TrimEnd());
    }

    private static int Partition(int[] arr, int l, int h)
    {
        int randomPivot = rand.Next(l, h + 1);
        (arr[l], arr[randomPivot]) = (arr[randomPivot], arr[l]);

        int pivot = arr[l];
        int low = l + 1;
        int high = h;

        while (low <= high)
        {
            if (arr[low] < pivot)
            {
                low++;
                continue;
            }

            if (arr[high] > pivot)
            {
                high--;
                continue;
            }

            if (low < high)
                (arr[low], arr[high]) = (arr[high], arr[low]);
        }

        (arr[l], arr[high]) = (arr[high], arr[l]);
        return high;
    }

    public static void MyQuickSort(int[] arr, int l, int h)
    {
        if (l < h)
        {
            int pivot = Partition(arr, l, h);
            MyQuickSort(arr, l, pivot - 1);
            MyQuickSort(arr, pivot + 1, h);
        }
    }
}