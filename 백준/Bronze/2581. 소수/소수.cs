class Backjoon
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        int min = 0;

        for (int i = M; i <= N; i++)
        {
            int factorCount = 0;
            for (int j = 1; j <= i; j++)
            {
                if (factorCount > 2) break;
                
                if (i % j == 0)
                {
                    factorCount++;
                }
            }

            if (factorCount == 2)
            {
                if (sum == 0) min = i;
                sum += i;
            }
        }
        
        if (min == 0)
            Console.Write("-1");
        else
        {
            Console.WriteLine(sum);
            Console.Write(min);
        }
    }
}