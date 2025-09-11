class Backjoon
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int line = 1;

        while (num > line)
        {
            num -= line;
            line++;
        }

        if (line % 2 == 1)
        {
            Console.Write($"{line - num + 1}/{num}");
        }
        else
        {
            Console.Write($"{num}/{line - num + 1}");
        }
    }
}