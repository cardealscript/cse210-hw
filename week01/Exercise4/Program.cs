using System;
using System.Collections.Generic; // necessário para usar List<int>

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // ============================================================

        // Criamos uma lista para guardar os números digitados
        List<int> numbers = new List<int>();
        
        int userNumber = -1; // variável para guardar o número do usuário

        // Enquanto o usuário não digitar 0, continuamos pedindo números
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Só adicionamos o número se não for 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Parte 1: Somar todos os números
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Parte 2: Calcular a média
        // Convertendo para float para permitir resultado decimal
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Parte 3: Encontrar o maior número
        int max = numbers[0]; // começamos assumindo que o primeiro é o maior
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number; // se acharmos um maior, atualizamos
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}
