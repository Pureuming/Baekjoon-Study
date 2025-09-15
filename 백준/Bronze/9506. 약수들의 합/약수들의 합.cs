using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            List<int> factors = new List<int>();
            int sum = 0;
            int input = int.Parse(Console.ReadLine());

            if (input == -1) break;

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0 && i != input)
                {
                    sum += i;
                    factors.Add(i);
                    if (i == 1)
                        sb.Append($"{input} = {i}");
                    else
                        sb.Append($" + {i}");
                }
            }

            if (input == sum)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine($"{input} is NOT perfect.");
            }
            sb.Clear();
        }
    }
}