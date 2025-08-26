class Backjoon
{
    static void Main(string[] args)
    {
        float totalCredits = 0;
        float sum = 0;

        for (int i = 0; i < 20; i++)
        {
            string[] input = Console.ReadLine().Split();
            float credit = float.Parse(input[1]);
            string grade = input[2];

            if (grade == "P") continue;

            totalCredits += credit;

            switch (grade)
            {
                case "A+":
                    sum += credit * 4.5f;
                    break;
                case "A0":
                    sum += credit * 4.0f;
                    break;
                case "B+":
                    sum += credit * 3.5f;
                    break;
                case "B0":
                    sum += credit * 3.0f;
                    break;
                case "C+":
                    sum += credit * 2.5f;
                    break;
                case "C0":
                    sum += credit * 2.0f;
                    break;
                case "D+":
                    sum += credit * 1.5f;
                    break;
                case "D0":
                    sum += credit * 1.0f;
                    break;
                case "F":
                    break;
                default:
                    break;
            }
        }
        Console.Write((sum / totalCredits).ToString("F6"));
    }
}