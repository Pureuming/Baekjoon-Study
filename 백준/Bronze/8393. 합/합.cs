class Backjoon
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int count = int.Parse(input);
        int answer = 0;

        for (int i = 1; i < count + 1; i++)
        {
            answer += i;
        }
        Console.WriteLine(answer);
    }
}