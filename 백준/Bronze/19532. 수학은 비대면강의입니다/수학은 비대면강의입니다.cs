class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int d = int.Parse(input[3]);
        int e = int.Parse(input[4]);
        int f = int.Parse(input[5]);

        for (int x = -999; x <= 999; x++)
        {
            for (int y = -999; y <= 999; y++)
            {
                if (a * x + b * y == c && d * x + e * y == f)
                {
                    Console.WriteLine($"{x} {y}");
                    return;
                }
            }
        }
    }
}