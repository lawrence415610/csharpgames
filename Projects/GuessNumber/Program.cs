int result = Random.Shared.Next(1, 101);
while (true)
{
    Console.WriteLine("Guess a number: ");
    if (!int.TryParse(Console.ReadLine(), out int userInput))
    {
        Console.WriteLine("Invalid input, please enter a valid integer.");
    }
    if (userInput == result) break;
    if (userInput > result)
    {
        Console.WriteLine(userInput + " is too big");
    }
    else
    {
        Console.WriteLine(userInput + " is too small");
    }
}
Console.WriteLine("The result is " + result);