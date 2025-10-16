class Backjoon
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (arr[j] < arr[j - 1])
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
            }
        }

        Console.WriteLine(sum / 5);
        Console.Write(arr[2]);
    }
}