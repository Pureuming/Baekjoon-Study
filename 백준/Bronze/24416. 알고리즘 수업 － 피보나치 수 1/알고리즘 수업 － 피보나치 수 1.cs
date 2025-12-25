using System.IO;

class Backjoon
{
    static int Method1, Method2;
    
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        
        Fib(n);
        Fibonacci(n);
        
        sw.Write(Method1 + " " + Method2);
    }

    static int Fib(int n)
    {
        if (n == 1 || n == 2)
        {
            Method1++;
            return 1;
        }
        return Fib(n - 1) + Fib(n - 2);
    }

    static int Fibonacci(int n)
    {
        int[] f = new int[n + 1];
        f[1] = 1;
        f[2] = 1;
        
        for (int i = 3; i <= n; i++)
        {
            f[i] = f[i - 1] + f[i - 2];
            Method2++;
        }

        return f[n];
    }
}