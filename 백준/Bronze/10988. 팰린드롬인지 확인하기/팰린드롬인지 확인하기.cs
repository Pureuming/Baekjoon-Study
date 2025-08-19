class Backjoon
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        char[] characters = input.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i] != characters[characters.Length - 1 - i])
            {
                Console.Write("0");
                break;
            }
            else if (i == characters.Length / 2)
            {
                Console.Write("1");
                break;
            }
        }
    }
}