using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());

        while (N != 1)
        {
            for (int i = 2; i <= N; i++)
            {
                if (N % i == 0)
                {
                    N /= i;
                    sb.AppendLine(i.ToString());
                    break;
                }
            }
        }
        Console.Write(sb.ToString());
    }
}