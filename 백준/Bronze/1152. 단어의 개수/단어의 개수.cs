class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int answer = input.Length;
        if (input[0] == "")
            answer--;
        if (input[input.Length - 1] == "")
            answer--;
        Console.Write(answer);
    }
}