class Backjoon
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int result = count;

        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();

            bool isGroupWord = true;
            for (int j = 0; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (arr[j] == arr[k])
                    {
                        if (arr[k - 1] == arr[k]) continue;
                        else
                        {
                            isGroupWord = false;
                            result--;
                            break;
                        }
                    }
                }
                if (!isGroupWord) break;
            }
        }
        Console.Write(result);
    }
}