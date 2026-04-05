class Program
{
    static void Main(string[] args)
    {
        // Teste da classe base Assignment
        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());

        Console.WriteLine("---");

        // Teste da MathAssignment
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine("---");

        // Teste da WritingAssignment
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}