class Backjoon
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int square = 1;

        for (int i = 0; i < count; i++)
        {
            square *= 4;
        }

        int width = (int)Math.Sqrt(square) + 1;

        Console.Write(width * width);
    }
}