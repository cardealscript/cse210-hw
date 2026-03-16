public class Fraction
{
    // variáveis privadas
    private int _top;
    private int _bottom;

    // Constructor 1 - sem parâmetros, inicializa 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2 - um parâmetro, inicializa top/1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3 - dois parâmetros
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // Setters
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // método que retorna fração como string ex: "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // método que retorna fração como decimal ex: 0.75
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}