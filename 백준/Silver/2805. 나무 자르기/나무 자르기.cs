using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int[] tree = new int[n];
        string[] trees = sr.ReadLine().Split();
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            tree[i] = int.Parse(trees[i]);
            if (tree[i] > max) max = tree[i];
        }
        
        sw.Write(Binary(tree, m, max));
    }

    static long Binary(int[] arr, int num, int max)
    {
        long low = 0;
        long high = max;
        long result = 0;

        while (low <= high)
        {
            long mid = (low + high) / 2;
            long sum = 0;

            foreach (var len in arr)
            {
                sum += len > mid ? len - mid : 0;
                if (sum >= num) break;
            }

            if (sum >= num)
            {
                low = mid + 1;
                result = mid;
            }
            else
                high = mid - 1;
        }

        return result;
    }
}