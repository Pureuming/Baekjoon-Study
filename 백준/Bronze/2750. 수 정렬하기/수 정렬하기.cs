class Backjoon
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] arr = new int[count];

        for (int i = 0; i < count; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 1; j < arr.Length - i; j++)
            {
                if (arr[j - 1] > arr[j])
                    (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
            }
        }

        foreach (var t in arr)
        {
            Console.WriteLine(t);
        }
    }
}