
int result = Random.Shared.Next(1, 101);
while(true){
    Console.Write("Guess a number");
    int userInput = int.Parse(Console.ReadLine() ?? "");
    if(userInput == result) break;
    if(userInput > result){
        Console.WriteLine("Too big");
    }else{
        Console.WriteLine("Too Small");
    }
}
Console.WriteLine("The result is " + result);