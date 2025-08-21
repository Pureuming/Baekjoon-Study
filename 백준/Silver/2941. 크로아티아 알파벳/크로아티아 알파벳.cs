class Backjoon
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] characters = input.ToCharArray();
        int count = 0;

        for (int i = 0; i < characters.Length; i++)
        {
            if (i == characters.Length - 1)
            {
                count++;
                break;
            }

            if (characters[i] == 'c')
            {
                if (characters[i + 1] == '=' || characters[i + 1] == '-')
                {
                    i++;
                }
            }
            else if (characters[i] == 'd')
            {
                if (i + 2 < characters.Length && characters[i + 1] == 'z' && characters[i + 2] == '=')
                {
                    i += 2;
                }
                else if (characters[i + 1] == '-')
                {
                    i++;
                }
            }
            else if (characters[i] == 'l' || characters[i] == 'n')
            {
                if (characters[i + 1] == 'j')
                {
                    i++;
                }
            }
            else if (characters[i] == 's' || characters[i] == 'z')
            {
                if (characters[i + 1] == '=')
                {
                    i++;
                }
            }
            count++;
        }
        Console.Write(count);
    }
}