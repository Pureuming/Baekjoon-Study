class Backjoon
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int minX = 10001;
        int minY = 10001;
        int maxX = -10001;
        int maxY = -10001;

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            
            if (x < minX) minX = x;
            if (y < minY) minY = y;
            if (x > maxX) maxX = x;
            if (y > maxY) maxY = y;
        }
        Console.Write((maxX - minX) * (maxY - minY));
    }
}