class Backjoon
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int result = 0;

        for (int i = 0; i < count; i++)
        {
            int num = int.Parse(input[i]);
            int factors = 0;

            for (int j = 1; j <= num; j++)
            {
                if (num % j == 0)
                    factors++;
            }

            if (factors == 2)
                result++;
        }
        Console.Write(result);
    }
}