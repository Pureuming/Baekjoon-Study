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

        for (int i = 0; i < basket; i++)
        {
            arr[i] = i + 1;
        }

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            int basketOne = int.Parse(input[0]);
            int basketTwo = int.Parse(input[1]);

            int temp = arr[basketOne - 1];
            arr[basketOne - 1] = arr[basketTwo - 1];
            arr[basketTwo - 1] = temp;
        }

        for (int i = 0; i < basket; i++)
        {
            sb.Append(arr[i] + " ");
        }
        Console.Write(sb.ToString());
    }
}