using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int max = 0;
        int index = -1;

        for (int i = 0; i < 9; i++)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number > max)
            {
                max = number;
                index = i + 1;
            }
        }
        sb.AppendLine(max.ToString());
        sb.Append(index.ToString());
        Console.Write(sb.ToString());
    }
}