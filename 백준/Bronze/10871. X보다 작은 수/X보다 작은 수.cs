using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string[] input = Console.ReadLine().Split(' ');
        int count = int.Parse(input[0]);
        int num = int.Parse(input[1]);
        string[] arrString = Console.ReadLine().Split(' ');
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = int.Parse(arrString[i]);
            if (arr[i] < num)
                sb.Append(arr[i] + " ");
        }
        Console.Write(sb.ToString());
    }
}