using System.IO;
using System.Text;

class Backjoon
{
    static string[] temp;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        
        int count = int.Parse(sr.ReadLine());
        string[] arr = new string[count];
        temp = new string[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = sr.ReadLine();
        }
        
        MergeSort(arr, 0, count - 1);

        for (int i = 0; i < count; i++)
        {
            if (i != count - 1 && arr[i] == arr[i + 1])
                continue;
            
            sb.AppendLine(arr[i]);
        }
        sw.Write(sb);
    }

    static void MergeSort(string[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(string[] arr, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i].Length < arr[j].Length)
                temp[k++] = arr[i++];
            else if (arr[i].Length == arr[j].Length)
            {
                if (arr[i].CompareTo(arr[j]) <= 0)
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }
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