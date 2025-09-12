class Backjoon
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int up = int.Parse(input[0]);
        int down = int.Parse(input[1]);
        int height = int.Parse(input[2]);
        int day = 0;

        if (height <= up)
        {
            day = 1;
        }
        else
        {
            day = (height - up) % (up - down) == 0 ?
            (height - up) / (up - down) + 1 :
            (height - up) / (up - down) + 2;
        }
        Console.Write(day);
    }

}
