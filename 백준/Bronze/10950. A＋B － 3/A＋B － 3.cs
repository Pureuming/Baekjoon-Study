class Backjoon
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int count = int.Parse(input);

        for (int i = 0; i < count; i++)
        {
            string[] num = Console.ReadLine().Split();
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            Console.WriteLine(a + b);
        }
    }
}