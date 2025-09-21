class Backjoon
{
    static void Main(string[] args)
    {
        int[] x = new int[3];
        int[] y = new int[3];
        int resultX = 0;
        int resultY = 0;
        
        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split();
            x[i] = int.Parse(input[0]);
            y[i] = int.Parse(input[1]);
        }
        
        if (x[0] == x[1]) resultX = x[2];
        else if (x[0] == x[2]) resultX = x[1];
        else resultX = x[0];
        
        if (y[0] == y[1]) resultY = y[2];
        else if (y[0] == y[2]) resultY = y[1];
        else resultY = y[0];
        
        Console.Write(resultX + " " + resultY);
    }
}