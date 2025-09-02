using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        char[,] arr = new char[5, 15];

        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();

            for (int j = 0; j < input.Length; j++)
            {
                arr[i, j] = input[j];
            }
        }

        for (int j = 0; j < 15; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                if (arr[i, j] != '\0')
                {
                    sb.Append(arr[i, j]);
                }
            }
        }
        Console.Write(sb.ToString());
    }
}