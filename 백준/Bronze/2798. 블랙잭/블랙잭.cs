class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int M = int.Parse(input[1]);
        string[] input2 = Console.ReadLine().Split();
        int[] arr = new int[input2.Length];

        for (int i = 0; i < input2.Length; i++)
        {
            arr[i] = int.Parse(input2[i]);
        }

        int result = 0;
        for (int i = 0; i < input2.Length - 2; i++)
        {
            for (int j = i + 1; j < input2.Length - 1; j++)
            {
                for (int k = j + 1; k < input2.Length; k++)
                {
                    if (arr[i] + arr[j] + arr[k] <= M && arr[i] + arr[j] + arr[k] > result )
                        result = arr[i] + arr[j] + arr[k];
                }
            }
        }

        Console.WriteLine(result);
    }
}