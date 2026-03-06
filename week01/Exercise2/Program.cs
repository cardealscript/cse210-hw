using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        // ============================================================

        Console.Write("What is your grade percentage? ");
        string grade_percentage = Console.ReadLine();

        if (int.TryParse(grade_percentage, out int grade))
        {
            string letter = "";
            string sign = "";

            // Determinar a letra
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Determinar o sinal (+ ou -)
            int lastDigit = grade % 10; // pega o último dígito

            if (letter != "F") // não existe F+ ou F-
            {
                if (letter == "A")
                {
                    // não existe A+, só A ou A-
                    if (lastDigit < 3)
                    {
                        sign = "-";
                    }
                }
                else
                {
                    if (lastDigit >= 7)
                    {
                        sign = "+";
                    }
                    else if (lastDigit < 3)
                    {
                        sign = "-";
                    }
                }
            }

            Console.WriteLine($"You have got {letter}{sign}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
