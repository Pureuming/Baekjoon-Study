class Backjoon
{
    static void Main(string[] args)
    {
        int[] angles = new int[3];
        int sum = 0;
        
        for (int i = 0; i < 3; i++)
        {
            int degree = int.Parse(Console.ReadLine());

            angles[i] = degree;
            sum += degree;
        }

        if (sum != 180)
        {
            Console.Write("Error");
        }
        else if (angles[0] == angles[1] && angles[1] == angles[2])
        {
            Console.Write("Equilateral");
        }
        else if (angles[0] == angles[1] || angles[0] == angles[2] || angles[1] == angles[2])
        {
            Console.Write("Isosceles");
        }
        else
        {
            Console.Write("Scalene");
        }
    }
}