using System.IO;

class Backjoon
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        
        sw.Write(Factorial(n)/(Factorial(k)*Factorial(n - k)));
    }

    static int Factorial(int n)
    {
        return n == 0 ? 1 : n * Factorial(n - 1);
    }
}