class Backjoon
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 1; i < number; i++)
        {
            int sum = i;
            int temp = i;

            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            if (sum == number)
            {
                result = i;
                break;
            }
        }
        Console.Write(result);
    }
}