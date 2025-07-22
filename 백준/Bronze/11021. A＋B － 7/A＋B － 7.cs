using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder answer = new StringBuilder();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            answer.Append("Case #" + (i + 1) + ": ");
            answer.AppendLine((a + b).ToString());
        }

        Console.WriteLine(answer.ToString());
    }
}