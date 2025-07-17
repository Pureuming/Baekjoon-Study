class Backjoon
{
    static void Main(string[] args)
    {
        string price = Console.ReadLine();
        int amount = int.Parse(price);
        string count = Console.ReadLine();
        int num = int.Parse(count);
        int totalPrice = 0;

        for (int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine().Split();
            int itemPrice = int.Parse(input[0]);
            int itemCount = int.Parse(input[1]);
            totalPrice += itemPrice * itemCount;
        }

        if (totalPrice == amount)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}