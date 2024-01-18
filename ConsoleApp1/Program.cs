// See https://aka.ms/new-console-template for more information

var rand = new Random();

string stringFormat = "Hello {0}!";
var word = "";

switch (rand.Next(2))
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
