class Backjoon
{
    static void Main(string[] args)
    {
        string[] time = Console.ReadLine().Split();
        int h = int.Parse(time[0]);
        int m = int.Parse(time[1]);

        string input = Console.ReadLine();
        int minute = int.Parse(input);

        if ((minute / 60) > 0)
        {
            h = h + (minute / 60);
            if (h >= 24) h -= 24;
            m = m + (minute % 60);
            if (m >= 60)
            {
                m -= 60;
                h++;
                if (h >= 24) h -= 24;
            }
        }
        else
        {
            m += minute;
            if (m >= 60)
            {
                h++;
                m -= 60;
                if (h >= 24) h -= 24;
            }
        }
        Console.WriteLine($"{h} {m}");
    }
}