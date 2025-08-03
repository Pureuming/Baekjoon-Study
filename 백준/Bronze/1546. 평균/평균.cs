class Backjoon
{
    static void Main(string[] args)
    {
        string count = Console.ReadLine();
        int n = int.Parse(count);
        float[] scores = new float[n];
        float max = 0f;
        float sum = 0f;
        string[] input = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            scores[i] = float.Parse(input[i]);
            if (scores[i] > max)
                max = scores[i];
        }

        for (int i = 0; i < n; i++)
        {
            sum += scores[i] / max * 100.0f;
        }
        float average = sum / n;
        Console.Write($"{average:0.0#####}");
    }
}