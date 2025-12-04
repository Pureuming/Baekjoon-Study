using System.IO;
using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(sr.ReadLine());
        int[] numbers = new int[n];
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(sr.ReadLine());
            sum += numbers[i];
        }
        
        MyQuickSort(numbers, 0, n - 1);
        
        double round = sum / n;
        round = Math.Round(round);
        if (round == 0) round = 0;

        int maxCount = 1;
        int count = 1;
        List<int> list = new List<int>();
        list.Add(numbers[0]);

        for (int i = 1; i < n; i++)
        {
            if (numbers[i - 1] == numbers[i])
                count++;
            else
                count = 1;
            
            if (count == maxCount)
                list.Add(numbers[i]);

            if (count > maxCount)
            {
                maxCount = count;
                list.Clear();
                list.Add(numbers[i]);
            }
        }
        
        sb.AppendLine($"{round}");
        sb.AppendLine($"{numbers[n / 2]}");
        sb.AppendLine(list.Count == 1 ? $"{list[0]}" : $"{list[1]}");
        sb.AppendLine($"{numbers[n - 1] - numbers[0]}");
        sw.Write(sb);
    }
    
    static int MedianOfThree(int[] arr, int l, int h)
    {
        int mid = (l + h) / 2;
    
        if (arr[mid] < arr[l])
            (arr[l], arr[mid]) = (arr[mid], arr[l]);
        if (arr[h] < arr[l])
            (arr[l], arr[h]) = (arr[h], arr[l]);
        if (arr[h] < arr[mid])
            (arr[mid], arr[h]) = (arr[h], arr[mid]);

        (arr[l], arr[mid]) = (arr[mid], arr[l]);
    
        return arr[l];
    }

    static int Partition(int[] arr, int l, int h)
    {
        int pivot = MedianOfThree(arr, l, h);
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

            if (low <= high)
            {
                (arr[low], arr[high]) = (arr[high], arr[low]);
                low++;
                high--;
            }
        }
        (arr[l], arr[high]) = (arr[high], arr[l]);
        return high;
    }

    static void MyQuickSort(int[] arr, int l, int h)
    {
        if (l < h)
        {
            int pivot = Partition(arr, l, h);
            MyQuickSort(arr, l, pivot - 1);
            MyQuickSort(arr, pivot + 1, h);
        }
    }
}