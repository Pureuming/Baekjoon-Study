class Backjoon
{
    static void Main(string[] args)
    {
        int[] remainders = new int[10];
        int count = 10;
        for (int i = 0; i < 10; i++)
        {
            remainders[i] = -1;
        }

        for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);
                remainders[i] = number % 42;
                for (int j = 0; j < 10; j++)
                {
                    if (i == j) continue;
                    if (remainders[i] == remainders[j])
                    {
                        count--;
                        break;
                    }
                }
            }
        Console.Write(count);
    }
}