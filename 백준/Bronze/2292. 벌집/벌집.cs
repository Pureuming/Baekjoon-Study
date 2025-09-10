class Backjoon
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int range = 1;
        int count = 6;

        if (num == 1)
        {
            Console.Write(range);
            return;
        }

        while (num > 1)
        {
            num -= count;
            count += 6;
            range++;
        }

        Console.Write(range);
    }
}