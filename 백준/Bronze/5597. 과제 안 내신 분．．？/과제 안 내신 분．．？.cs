using System.Text;

class Backjoon
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        bool[] students = new bool[31];
        for (int i = 1; i <= 30; i++)
            students[i] = true;

        for (int i = 0; i < 28; i++)
        {
            string input = Console.ReadLine();
            int studentNumber = int.Parse(input);
            if (studentNumber >= 1 && studentNumber <= 30)
                students[studentNumber] = false;
        }

        for (int i = 1; i <= 30; i++)
        {
            if (students[i])
            {
                sb.AppendLine(i.ToString());
            }
        }
        Console.Write(sb.ToString());
    }
}