class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        string arr = input[0];
        int formation = int.Parse(input[1]);
        int result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int temp = 0;
            if (arr[i] >= 'A' && arr[i] <= 'Z')
            {
                temp = arr[i] - 55;
            }
            else
            {
                temp = int.Parse(arr[i].ToString());
            }

            result += temp * (int)Math.Pow(formation, arr.Length - 1 - i);
        }
        Console.Write(result);
    }
}