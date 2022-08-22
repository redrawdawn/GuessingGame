using System;

int secretNumber = new Random().Next(1, 101);

Console.Write("Choose difficulty level (e, m, h): ");
string difficulty = Console.ReadLine().ToLower();

int attempts = 0;

bool cheater = false;

switch(difficulty)
{
    case "e":
    attempts = 8;
    break;

    case "m":
    attempts = 6;
    break;

    case "h":
    attempts = 4;
    break;

    case "cheat": 
    {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Cheater mode enabled!");
    cheater = true; 
    break;}
}

Console.WriteLine("Guess a secret number: ");

while(attempts > 0 || cheater)
{
    attempts--;
    int guessedNumber = int.Parse(Console.ReadLine());

    string highOrLow = (guessedNumber > secretNumber)
     ? "Too high" : "Too low";

    string onWrong = (attempts != 0) 
    ? $"{highOrLow}, You have {(cheater ? "*" : attempts)} tries left" 
    : $"All out of tries,\nThe number was {secretNumber}";

    bool correct = guessedNumber == secretNumber;

    string result = (correct)? "You got the secret number!!" : onWrong;
    Console.WriteLine(result);
    
    if (correct)
    break;
}





