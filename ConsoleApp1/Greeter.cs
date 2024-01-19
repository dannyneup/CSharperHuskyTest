namespace ConsoleApp1;

public class Greeter
{
    private Random _rand = new();

    public void Greet()
    {
        string stringFormat = "Hello {0}!";
        var word = "";

        switch (_rand.Next(2))
        {
            case 0:
                word = "World";
                break;
            case 1:
                word = "Husky";
                break;
        }

        var formatedString = String.Format(stringFormat, word);

        Console.WriteLine(formatedString);
    }
}
