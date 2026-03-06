using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // =============================================================

        // 1. Mostrar mensagem de boas-vindas
        DisplayWelcome();

        // 2. Pedir o nome do usuário
        string userName = PromptUserName();

        // 3. Pedir o número favorito do usuário
        int userNumber = PromptUserNumber();

        // 4. Calcular o quadrado do número
        int squaredNumber = SquareNumber(userNumber);

        // 5. Mostrar o resultado final
        DisplayResult(userName, squaredNumber);
    }

    // Função que mostra mensagem de boas-vindas
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Função que pede o nome e retorna como string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Função que pede o número favorito e retorna como inteiro
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }

    // Função que recebe um número e retorna o quadrado dele
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Função que mostra o resultado final
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
