class Backjoon
{
    static void Main(string[] args)
    {
        int[] arr = new int[3];
        int sum = 0;
        int largest = 0;
        
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < 3; i++)
        {
            arr[i] = int.Parse(input[i]);
            sum += arr[i];
            if (arr[i] > largest) largest = arr[i];
        }

        if (sum - largest <= largest)
        {
            sum = 2 * (sum - largest) - 1;
            Console.Write(sum);
        }
        else
        {
            Console.Write(sum);
        }
    }
}