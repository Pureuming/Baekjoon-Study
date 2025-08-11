class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int num1 = int.Parse(ReverseWord(input[0]));
        int num2 = int.Parse(ReverseWord(input[1]));
        Console.WriteLine(num1 > num2 ? num1 : num2);
    }

    static string ReverseWord(string word)
    {
        char[] charArray = word.ToCharArray();
        (charArray[0], charArray[charArray.Length - 1]) = (charArray[charArray.Length - 1], charArray[0]);
        return new string(charArray);
    }
}