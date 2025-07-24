class Backjoon
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        int count = int.Parse(num);
        string[] arrs = Console.ReadLine().Split(' ');
        string input = Console.ReadLine();
        int answer = 0;
        for (int i = 0; i < count; i++)
        {
            if (arrs[i] == input)
                answer++;
        }
        Console.Write(answer);
    }
}