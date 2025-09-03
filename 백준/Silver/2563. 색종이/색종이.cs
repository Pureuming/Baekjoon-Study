class Backjoon
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[,] arr = new int[100, 100];
        int result = 0;

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            for (int j = y; j < y + 10; j++)
            {
                for (int k = x; k < x + 10; k++)
                {
                    if (arr[j, k] == 1) continue;
                    arr[j, k] = 1;
                }
            }
        }

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                if (arr[i, j] == 1) result++;
            }
        }
        Console.Write(result);
    }
}