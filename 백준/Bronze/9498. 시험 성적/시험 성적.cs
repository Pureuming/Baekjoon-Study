class Backjoon
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        if (input >= 90 && input <= 100 )
        {
            Console.WriteLine("A");
        }
        else if (input >= 80 && input < 90)
        {
            Console.WriteLine("B");
        }
        else if (input >= 70 && input < 80)
        {
            Console.WriteLine("C");
        }
        else if (input >= 60 && input < 70)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}