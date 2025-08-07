class Backjoon
{
    static void Main(string[] args)
    {
        int count = Convert.ToInt32(Console.ReadLine());
        string input = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < count; i++)
        {
            string num = input.Substring(i, 1);
            int number = int.Parse(num);
            sum += number;
        }
        Console.Write(sum);
    }
}