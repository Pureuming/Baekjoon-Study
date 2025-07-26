using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string[] num = Console.ReadLine().Split();
        int basket = int.Parse(num[0]);
        int count = int.Parse(num[1]);
        int[] arr = new int[basket];

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            int start = int.Parse(input[0]);
            int end = int.Parse(input[1]);
            int value = int.Parse(input[2]);

            for (int j = start - 1; j < end; j++)
            {
                arr[j] = value;
            }
        }

        for (int i = 0; i < basket; i++)
        {
            if (arr[i] == null)
            {
                arr[i] = 0;
            }
            sb.Append(arr[i] + " ");
        }
        Console.Write(sb.ToString());
    }
}