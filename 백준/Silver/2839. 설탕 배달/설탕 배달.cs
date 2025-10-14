class Backjoon
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int result = -1;

        for (int i = input / 5; i >= 0; i--)
        {
            int remain = input - i * 5;
            
            if (remain % 3 == 0)
            {
                result = i + remain / 3;
                break;
            }
        }
        Console.Write(result);
    }
}