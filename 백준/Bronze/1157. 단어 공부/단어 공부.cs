class Backjoon
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string upperInput = input.ToUpper();
        char[] characters = upperInput.ToCharArray();
        int[] counts = new int[26];
        int maxCount = 0;
        int index = -1;

        foreach (char c in characters)
        {
            counts[c - 'A']++;
        }

        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                index = i;
            }
        }

        for (int i = 0; i < counts.Length; i++)
        {
            if (i != index && counts[i] == maxCount)
            {
                Console.Write('?');
                return;
            }
        }
        Console.Write((char)(index + 'A'));
    }
}