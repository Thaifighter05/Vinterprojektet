Console.WriteLine("Welcome to the stew Contest");
Console.ReadLine();

Console.WriteLine("You will be making a stew with your choice of ingredients");
Console.ReadLine();

Console.WriteLine("The jury will be judging you based on the ingredients you pick");
Console.ReadLine();

Player Contestant = new Player(); 
Console.WriteLine("Please enter your name");
Contestant.name = Console.ReadLine();

Console.WriteLine($"Hi {Contestant.name}");
Console.ReadLine();
