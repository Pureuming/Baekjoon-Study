class Backjoon
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int a = int.Parse(input);

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(a + " * " + i + " = " + a * i);
        }
    }
}