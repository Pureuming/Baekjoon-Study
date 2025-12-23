using System.IO;

class Backjoon
{
    static int N, Min, Max;
    static int Plus, Minus, Multiply, Divide;
    static int[] arr;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        N = int.Parse(sr.ReadLine());
        arr = sr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] operators = sr.ReadLine().Split().Select(int.Parse).ToArray();
        Min = int.MaxValue;
        Max = int.MinValue;

        Plus = operators[0];
        Minus = operators[1];
        Multiply = operators[2];
        Divide = operators[3];
        
        DFS(0, arr[0]);
        
        sw.WriteLine(Max);
        sw.Write(Min);
    }

    static void DFS(int depth, int result)
    {
        if (depth == N - 1)
        {
            if (result < Min) Min = result;
            if (result > Max) Max = result;
            return;
        }

        if (Plus > 0)
        {
            Plus--;
            DFS(depth + 1, result + arr[depth + 1]);
            Plus++;
        }

        if (Minus > 0)
        {
            Minus--;
            DFS(depth + 1, result - arr[depth + 1]);
            Minus++;
        }

        if (Multiply > 0)
        {
            Multiply--;
            DFS(depth + 1, result * arr[depth + 1]);
            Multiply++;
        }

        if (Divide > 0)
        {
            Divide--;
            DFS(depth + 1, result / arr[depth + 1]);
            Divide++;
        }
    }
}