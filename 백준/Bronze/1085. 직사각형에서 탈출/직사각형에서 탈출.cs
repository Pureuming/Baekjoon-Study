class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);
        int w = int.Parse(input[2]);
        int h = int.Parse(input[3]);
        int minX = 0;
        int minY = 0;

        minX = h - y > y ? y : h - y;
        minY = w - x > x ? x : w - x;

        Console.Write(minX > minY ? minY : minX);
    }
}