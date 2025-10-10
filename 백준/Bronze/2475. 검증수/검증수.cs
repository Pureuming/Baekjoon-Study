class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int d = int.Parse(input[3]);
        int e = int.Parse(input[4]);
        
        Console.Write((a * a + b * b + c * c + d * d + e * e) % 10);
    }
}