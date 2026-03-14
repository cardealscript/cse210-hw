public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    // construtor para NOVA entrada (data automática)
    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    // construtor para CARREGAR do ficheiro (data já existe)
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    // método para exibir na tela
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("---");
    }

    // método para salvar no ficheiro
    public string GetSaveLine()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}