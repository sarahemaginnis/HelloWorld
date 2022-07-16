// See https://aka.ms/new-console-template for more information

var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

foreach (var animal in animals)
{
	Console.WriteLine(animal);
}
Console.Write("Type a letter: ");
var input = Console.ReadLine();
Console.WriteLine(input);
Console.ReadKey(); // What happens if you run the app without this line?