using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string word = Console.ReadLine();
        int askii = 97; // ASCII 'a' == 97
        int[] arr = new int[26];
        for (int i = 0; i < 26; i++)
        {
            arr[i] = askii + i;
        }

        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < word.Length; j++)
            {
                char alphabet = Convert.ToChar(word.Substring(j, 1));
                int number = Convert.ToInt32(alphabet);

                if (arr[i] == number)
                {
                    sb.Append(j + " ");
                    break;
                }
                else if (j == word.Length - 1 && arr[i] != number)
                {
                    sb.Append("-1 ");
                }
            }
        }
        Console.Write(sb.ToString().TrimEnd());
    }
}