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

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        HashSet<string> hash = new HashSet<string>();
        List<string> list = new List<string>();

        for (int i = 0; i < n; i++)
        {
            hash.Add(sr.ReadLine());
        }

        for (int i = 0; i < m; i++)
        {
            string name = sr.ReadLine();
            if (hash.Contains(name))
                list.Add(name);
        }
        
        string[] arr = list.ToArray();
        temp = new string[arr.Length];
        
        MergeSort(arr, 0, arr.Length - 1);

        sb.AppendLine(arr.Length.ToString());
        foreach (var name in arr)
        {
            sb.AppendLine(name);
        }
        sw.Write(sb.ToString());
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
            if (String.Compare(arr[i], arr[j], StringComparison.Ordinal) <= 0)
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