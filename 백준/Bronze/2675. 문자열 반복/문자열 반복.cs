using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            int repeatCount = int.Parse(input[0]);
            string str = input[1];

            foreach (char c in str)
            {
                for (int j = 0; j < repeatCount; j++)
                {
                    sb.Append(c);
                }
            }
            sb.AppendLine();
        }
        Console.Write(sb.ToString().TrimEnd());
    }
}