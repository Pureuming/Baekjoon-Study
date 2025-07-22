using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            if (i != count) Console.WriteLine();
        }
    }
}