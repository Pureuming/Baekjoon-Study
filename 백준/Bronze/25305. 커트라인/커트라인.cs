class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int count = int.Parse(input[0]);
        int cutoff = int.Parse(input[1]);
        int[] arr = new int[count];
        
        string[] scores = Console.ReadLine().Split();
        for (int i = 0; i < count; i++)
        {
            arr[i] = int.Parse(scores[i]);
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }
        
        Console.Write(arr[arr.Length - cutoff]);
    }
}