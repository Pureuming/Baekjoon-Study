using System.IO;
using System.Text;

class Backjoon
{
    static (int, string, int)[] temp;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        
        int count = int.Parse(sr.ReadLine());
        (int age, string name, int index)[] arr = new (int, string, int)[count];
        temp = new (int, string, int)[count];

        for (int i = 0; i < count; i++)
        {
            string[] input = sr.ReadLine().Split();
            arr[i] = (int.Parse(input[0]), input[1], i);
        }
        
        MergeSort(arr, 0, count - 1);

        for (int i = 0; i < count; i++)
        {
            sb.Append(arr[i].age).Append(' ').Append(arr[i].name).Append('\n');
        }
        sw.Write(sb);
    }

    static void MergeSort((int age, string name, int index)[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge((int age, string name, int index)[] arr, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i].age < arr[j].age)
                temp[k++] = arr[i++];
            else if (arr[i].age == arr[j].age)
            {
                if (arr[i].index < arr[j].index)
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