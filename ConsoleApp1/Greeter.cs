using System;

namespace ConsoleApp1;

public class Greeter
{
    private Random _rand = new();

    public void Greet()
    {
        var stringFormat = "Hello {0}!";

        var word = _rand.Next(6) switch
        {
            0 => "World",
            1 => "Husky",
            2 => "Snake",
            3 => "Turtle",
            4 => "Elephant",
            5 => "Chameleon",
            6 => "Human",
            _ => "_"
        };

        var formattedString = string.Format(stringFormat, word);

        Console.WriteLine(formattedString);
    }
}
