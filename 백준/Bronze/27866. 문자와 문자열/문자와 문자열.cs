class Backjoon
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string input = Console.ReadLine();
        int index = int.Parse(input) - 1;
        Console.WriteLine(str.Substring(index, 1));
    }
}