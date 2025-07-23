using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == null)
                break;
            string[] inputs = input.Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            sb.AppendLine((a + b).ToString());
        }
        Console.Write(sb.ToString());
    }
}