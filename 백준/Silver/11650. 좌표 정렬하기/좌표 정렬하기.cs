using System.IO;
using System.Text;

class Backjoon
{
    static (int x, int y)[] temp;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        int count = int.Parse(sr.ReadLine());
        (int x, int y)[] arr = new (int, int)[count];
        temp = new (int, int)[count];

        for (int i = 0; i < count; i++)
        {
            string[] input = sr.ReadLine().Split();
            arr[i] = (int.Parse(input[0]), int.Parse(input[1]));
        }

        MergeSort(arr, 0, count - 1);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append(arr[i].x).Append(' ').Append(arr[i].y).Append('\n');
        }
        sw.Write(sb);
    }

    static void MergeSort((int x, int y)[] arr, int left, int right)
    {
        if (left >= right) return;
        
        int mid = (left + right) / 2;

        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    static void Merge((int x, int y)[] arr, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (Compare(arr[i], arr[j]) <= 0)
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while (i <= mid)
            temp[k++] = arr[i++];

        while (j <= right)
            temp[k++] = arr[j++];

        for (int l = left; l <= right; l++)
            arr[l] = temp[l];
    }
    
    static int Compare((int x, int y) a, (int x, int y) b)
    {
        if (a.x != b.x)
            return a.x.CompareTo(b.x);
        return a.y.CompareTo(b.y);
    }
}