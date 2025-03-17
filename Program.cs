using System;

public class Program
{


    public static void Main()
    {
        GenerateGame();
    }

    static void GenerateGame()
    {
        Random random = new Random();
        int atRow = random.Next(40);
        int atCol = random.Next(40);

        for (int i = 0; i < 40; i++)
        {
            string line = "";
            for (int j = 0; j < 40; j++)
            {
                if (i == atRow && j == atCol)
                {
                    line += "@";
                }
                else
                {
                    line += (char)('A' + random.Next(26));
                }
            }
            Console.WriteLine(line);
        }
    }
}