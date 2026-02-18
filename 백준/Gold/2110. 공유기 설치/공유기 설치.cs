using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());
        
        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int c = int.Parse(input[1]);
        int[] home = new int[n];
        for (int i = 0; i < n; i++)
        {
            home[i] = int.Parse(sr.ReadLine());
        }
        Array.Sort(home);
        
        sw.Write(Binary(home, c));
    }

    static int Binary(int[] arr, int num)
    {
        int low = 1;
        int high = arr[arr.Length - 1] - arr[0];
        int result = 0;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int count = 1;
            int install = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (mid <= arr[i] - install)
                {
                    count++;
                    install = arr[i];
                }

                if (count >= num) break;
            }

            if (count >= num)
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