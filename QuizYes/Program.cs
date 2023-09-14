// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

string choice = "";

Console.WriteLine("Mornin', mornin', mornin, to yall!");
Console.WriteLine("This is Wieron in the Ott! The klock says its 03:30, get up!");
Console.WriteLine("Who am I tjöting with?");
Console.WriteLine();           //skriv ut meddelanden
choice = Console.ReadLine();

Console.WriteLine($"Tjenare {choice}, de va la trevligt.");
Console.WriteLine("Nu har jag några frågor till dig här va.");
Console.WriteLine("Fråga 1:");
Console.WriteLine("");
Console.WriteLine("Vilket djur förlorade Australienska soldater ett krig mot år 1932?");
Console.WriteLine("Var det:");
Console.WriteLine("a) Känguru");
Console.WriteLine("b) Dingo");
Console.WriteLine("c) Emu");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a")
{
Console.WriteLine("Intressant val du. Kriget varade bara en månad.");
Console.WriteLine("Jaha då. Här kommer fråga 2:");
Console.WriteLine("");
Console.WriteLine("");
}

else if (choice == "b")
{
Console.WriteLine("Mhmm, okej. Kriget var ett riktigt kort ett.")
Console.WriteLine("Jaja, här kommer fråga 2:");



}

else if (choice == "c")
{
Console.WriteLine("Äntligen en lite kapabel människa!");
Console.WriteLine("Hur som helst måste jag ställa fråga 2. Här kommer den:");    
}


Console.ReadLine();