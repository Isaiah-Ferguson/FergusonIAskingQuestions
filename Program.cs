//Isaiah Keith Ferguson
//10/17/2022
//Mini Challenge 3
//asking questions


Console.Clear();

string answer = "";

while(answer != "end"){
Console.WriteLine("Goodmorning, what's your name?");
string response = Console.ReadLine();

Console.WriteLine($"{response}? Wow what a mysterious name!! What time did you wake up?");
string response1 = Console.ReadLine();

Console.WriteLine($"{response1} wow I woke up about 10 minutes after {response1}");

Console.WriteLine("Type End to Terminate the program or press enter to replay.");
answer = Console.ReadLine().ToLower();
}
