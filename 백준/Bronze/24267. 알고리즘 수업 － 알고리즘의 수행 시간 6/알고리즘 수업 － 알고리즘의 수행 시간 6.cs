class Backjoon
{
    static void Main(string[] args)
    {
        ulong input = ulong.Parse(Console.ReadLine());
        Console.Write($"{(input - 2) * (input - 1) * input / 6}\n3");
    }
}