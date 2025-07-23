using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            if (a == 0 && b == 0)
                break;
            sb.AppendLine((a + b).ToString());
        }
        Console.Write(sb.ToString());
    }
}