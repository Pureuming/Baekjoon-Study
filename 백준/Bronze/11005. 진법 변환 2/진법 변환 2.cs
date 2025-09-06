using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string[] input = Console.ReadLine().Split();
        int num = int.Parse(input[0]);
        int formation = int.Parse(input[1]);

        while (num / formation > 0)
        {
            if (num % formation < 10)
                sb.Insert(0, num % formation);
            else
            {
                char ch = (char)(num % formation + 55);
                sb.Insert(0, ch);
            }
            num /= formation;
        }

        if (num < 10)
            sb.Insert(0, num);
        else
        {
            char ch = (char)(num + 55);
            sb.Insert(0, ch);
        }

        Console.Write(sb.ToString());
    }
}