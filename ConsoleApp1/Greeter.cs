namespace ConsoleApp1;

public class Greeter
{
    private Random _rand = new();

    public void Greet()
    {
        var stringFormat = "Hello {0}!";

        var word = _rand.Next(3) switch
        {
            0 => "World",
            1 => "Husky",
            2 => "Snake",
            _ => ""
        };

        var formattedString = string.Format(stringFormat, word);

        Console.WriteLine(formattedString);
    }
}
