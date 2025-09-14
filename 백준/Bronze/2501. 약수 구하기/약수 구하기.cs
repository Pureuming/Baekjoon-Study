class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        int count = 0;

        for (int i = 1; i <= N; i++)
        {
            if (N % i == 0)
            {
                count++;
                if (count == K)
                {
                    Console.Write(i);
                    return;
                }
            }
        }
        Console.Write(0);
    }
}