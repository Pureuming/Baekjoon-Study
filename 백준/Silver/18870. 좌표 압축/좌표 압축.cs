using System.IO;
using System.Text;

class Backjoon
{
    static (int num, int index)[] temp;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();

        int count = int.Parse(sr.ReadLine());
        (int num, int index)[] arr = new (int, int)[count];
        temp = new (int, int)[count];

        string[] input = sr.ReadLine().Split();
        for (int i = 0; i < count; i++)
        {
            arr[i] = (int.Parse(input[i]), i);
        }
        
        MergeSort(arr, 0, count - 1);

        int[] result = new int[count];
        int index = 0;
        
        for (int i = 1; i < count; i++)
        {
            if (arr[i - 1].num != arr[i].num)
            {
                index++;
            }

            result[arr[i].index] = index;
        }

        for (int i = 0; i < count; i++)
        {
            sb.Append(result[i]).Append(" ");
        }
        sw.Write(sb.ToString().TrimEnd());
    }

    static void MergeSort((int num, int index)[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge((int num, int index)[] arr, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i].num <= arr[j].num)
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }
        
        while (i <= mid)
            temp[k++] = arr[i++];
        while (j <= right)
            temp[k++] = arr[j++];

        for (int l = left; l <= right; l++)
        {
            arr[l] = temp[l];
        }
    }
}