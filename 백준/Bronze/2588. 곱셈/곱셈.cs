class Backjoon
{
    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        int a = int.Parse(input1);
        int b = int.Parse(input2);

        int hundreds = b / 100;
        int tens = (b / 10) % 10;
        int ones = b % 10;

        Console.WriteLine(a * ones);
        Console.WriteLine(a * tens);
        Console.WriteLine(a * hundreds);
        Console.WriteLine(a * b);
    }
}