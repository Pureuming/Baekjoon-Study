class Backjoon
{
    static void Main(string[] args)
    {
        string result = "";
        
        while (true)
        {
            string[] input = Console.ReadLine().Split();
            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[1]);

            if (num1 == 0 && num2 == 0)
                break;

            if (num1 > num2)
            {
                result = num1 % num2 == 0 ? "multiple" : "neither";
                Console.WriteLine(result);
            }
            else
            {
                result = num2 % num1 == 0 ? "factor" : "neither";
                Console.WriteLine(result);
            }
        }
    }
}