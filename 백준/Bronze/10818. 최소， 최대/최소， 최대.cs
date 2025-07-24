using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string input = Console.ReadLine();
        int count = int.Parse(input);
        string[] arrString = Console.ReadLine().Split(' ');
        int[] arr = new int[count];
        int min = 1000001;
        int max = -1000001;
        for (int i = 0; i < count; i++)
        {
            arr[i] = int.Parse(arrString[i]);
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }
        sb.Append(min + " " + max);
        Console.Write(sb.ToString());
    }
}