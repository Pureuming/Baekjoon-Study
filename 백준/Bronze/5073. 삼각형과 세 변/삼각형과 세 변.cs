class Backjoon
{
    static void Main(string[] args)
    {
        while (true)
        {
            int[] arr = new int[3];
            int largest = 0;
            int sum = 0;
            
            string[] input = Console.ReadLine().Split();
            arr[0] = int.Parse(input[0]);
            arr[1] = int.Parse(input[1]);
            arr[2] = int.Parse(input[2]);

            if (arr[0] == 0 && arr[1] == 0 && arr[2] == 0) break;

            for (int i = 0; i < 3; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
                sum += arr[i];
            }

            if (sum - largest <= largest)
                Console.WriteLine("Invalid");
            else if (arr[0] == arr[1] && arr[1] == arr[2])
                Console.WriteLine("Equilateral");
            else if (arr[0] == arr[1] || arr[0] == arr[2] || arr[1] == arr[2])
                Console.WriteLine("Isosceles");
            else
                Console.WriteLine("Scalene");
        }
    }
}