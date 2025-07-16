class Backjoon
{
    static void Main(string[] args)
    {
        string[] dice = Console.ReadLine().Split();
        int a = int.Parse(dice[0]);
        int b = int.Parse(dice[1]);
        int c = int.Parse(dice[2]);

        if (a == b && b == c)
        {
            Console.WriteLine(10000 + a * 1000);
        }
        else if (a == b || b == c || a == c)
        {
            int sameNum = a == b ? a : (b == c ? b : c);
            Console.WriteLine(1000 + sameNum * 100);
        }
        else
        {
            int maxNum = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(maxNum * 100);
        }
    }
}