using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int[,] arr = new int[9, 9];
        int max = -1;

        for (int i = 0; i < 9; i++)
        {
            string[] input = Console.ReadLine().Split();

            for (int j = 0; j < 9; j++)
            {
                arr[i, j] = int.Parse(input[j]);

                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    sb.Clear();
                    sb.AppendLine(max.ToString());
                    sb.Append((i + 1) + " " + (j + 1));
                }
            }
        }
        Console.Write(sb.ToString());
    }
}