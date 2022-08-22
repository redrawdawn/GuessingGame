using System;

Console.Write("Guess a secret number: ");
int guessedNumber = int.Parse(Console.ReadLine());
int secretNumber = 42;
string result = (guessedNumber == secretNumber)
? "you guessed tje secret number" : "try again";
Console.WriteLine(result);