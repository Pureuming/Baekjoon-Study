using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string[] input = Console.ReadLine().Split();
        int basketCount = int.Parse(input[0]);
        int count = int.Parse(input[1]);
        int[] baskets = new int[basketCount + 1];

        for (int i = 1; i <= basketCount; i++)
        {
            baskets[i] = i;
        }

        for (int i = 1; i <= count; i++)
        {
            string[] command = Console.ReadLine().Split();
            int start = int.Parse(command[0]);
            int end = int.Parse(command[1]);

            while (start < end)
            {
                (baskets[start], baskets[end]) = (baskets[end], baskets[start]);
                start++;
                end--;
            }
        }

        for (int i = 1; i <= basketCount; i++)
        {
            sb.Append(baskets[i] + " ");
        }
        Console.Write(sb.ToString());
    }
}