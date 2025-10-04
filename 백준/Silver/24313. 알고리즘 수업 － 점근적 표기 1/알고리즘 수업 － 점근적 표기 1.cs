class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int a1 = int.Parse(input[0]);
        int a0 = int.Parse(input[1]);
        int c = int.Parse(Console.ReadLine());
        int n0 = int.Parse(Console.ReadLine());

        if (a1 > c)
        {
            Console.Write("0");
        }
        else if (a1 == c && a0 <= 0)
        {
            Console.Write("1");
        }
        else
        {
            Console.Write(a1 * n0 + a0 <= c * n0 ? "1" : "0");
        }
    }
}