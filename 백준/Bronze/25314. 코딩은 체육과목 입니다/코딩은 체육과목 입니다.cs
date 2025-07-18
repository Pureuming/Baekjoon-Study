class Backjoon
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int count = int.Parse(input);

        for (int i = 0; i < count / 4; i++)
        {
            Console.Write("long ");
        }
        Console.WriteLine("int");
    }
}