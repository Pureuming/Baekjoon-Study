class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int h = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        if (m < 45)
        {
            if (h == 0) h = 23;
            else h -= 1;
            m = m - 45 + 60;
        }
        else
        {
            m -= 45;
        }

        Console.WriteLine($"{h} {m}");
    }
}