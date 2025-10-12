class Backjoon
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());        
        int count = 0;
        int number = 666;

        while (true)
        {
            string str = number.ToString();

            for (int i = str.Length - 2; i > 0; i--)
            {
                if (str[i - 1] == '6' && str[i] == '6' && str[i + 1] == '6')
                {
                    count++;
                    break;
                }
            }

            if (count == input)
            {
                Console.Write(number);
                break;
            }
            number++;
        }        
    }
}