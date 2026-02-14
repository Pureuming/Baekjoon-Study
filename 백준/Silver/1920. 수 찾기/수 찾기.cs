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
        string[] inputA = sr.ReadLine().Split();
        int[] arrA = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrA[i] = int.Parse(inputA[i]);
        }
        Array.Sort(arrA);
        
        int m = int.Parse(sr.ReadLine());
        string[] inputM = sr.ReadLine().Split();
        for (int i = 0; i < m; i++)
        {
            int num = int.Parse(inputM[i]);
            sb.AppendLine(Binary(arrA, num).ToString());
        }
        
        sw.Write(sb);
    }

    static int Binary(int[] arr, int num)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == num) return 1;
            else if (arr[mid] < num)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return 0;
    }
}