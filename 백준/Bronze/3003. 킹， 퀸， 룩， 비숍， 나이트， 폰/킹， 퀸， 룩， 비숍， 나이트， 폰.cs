using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string[] input = Console.ReadLine().Split();
        int[] chess = new int[] { 1, 1, 2, 2, 2, 8 };

        for (int i = 0; i < input.Length; i++)
        {
            int pieceCount = int.Parse(input[i]);
            sb.Append(chess[i] - pieceCount).Append(" ");
        }
        Console.Write(sb.ToString().Trim());
    }
}