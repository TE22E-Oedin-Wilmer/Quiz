// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

string choice = "";
string name = "";
Console.WriteLine("Mornin', mornin', mornin, to yall!");
Console.WriteLine("This is Wieron in the Ott! The clock says it's 03:30, get up!");
Console.WriteLine("Who am I tjöting with?(What is your name):");
Console.WriteLine();           //skriv ut meddelanden
name = Console.ReadLine();

Console.WriteLine($"Hello {name}, nice to meet you!");
Console.WriteLine("Now I have a few questions for you, alright?");
Console.WriteLine("Question 1:");
Console.WriteLine("");
Console.WriteLine("What animals did the Australian soldiers lose a war to in 1932?");
Console.WriteLine("Was it:");
Console.WriteLine("a) Kangaroo");
Console.WriteLine("b) Dingo");
Console.WriteLine("c) Emu");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a")
{
Console.WriteLine("Interesting choice. The war only lasted one month.");
Console.WriteLine("Alrighty then, here comes question 2:");
Console.WriteLine("");
Console.WriteLine("What is Scotlands national animal?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Unicorn");
Console.WriteLine("b) Snake");
Console.WriteLine("c) Squirrel");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was a tricky one right?");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("That was a decent try. You did pretty good!");
Console.WriteLine("You got 2 right out of 3 [2/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "c"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}

else if (choice == "b"){
Console.WriteLine("Nice try. I would have answered Unicorn just for the fun of it.");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was a try I guess?. You did try right?");
Console.WriteLine("You got 0 right out of 3 [0/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "c"){
Console.WriteLine("That was a try I guess?. You did try right?");
Console.WriteLine("You got 0 right out of 3 [0/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");    
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}

else if (choice == "c"){
Console.WriteLine("Good answer. The red squirrel is actually a very common animal in Scotland.");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was a try I guess?. You did try right?");
Console.WriteLine("You got 0 right out of 3 [0/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "c"){
Console.WriteLine("That was a try I guess?. You did try right?");
Console.WriteLine("You got 0 right out of 3 [0/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");    
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}

else if (choice == "b")
{
Console.WriteLine("Alright. The war was in fact a really short one.");
Console.WriteLine("Either way, here comes question 2:");
Console.WriteLine("");
Console.WriteLine("What is Scotlands national animal?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Unicorn");
Console.WriteLine("b) Snake");
Console.WriteLine("c) Squirrel");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was a tricky one right?");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("That was a decent try. You did pretty good!");
Console.WriteLine("You got 2 right out of 3 [2/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "c"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");    
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}

else if (choice == "b"){
Console.WriteLine("Nice try. I would have answered Unicorn just for the fun of it.");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was a try I guess?. You did try right?");
Console.WriteLine("You got 0 right out of 3 [0/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "c"){
Console.WriteLine("That was a try I guess?. You did try right?");
Console.WriteLine("You got 0 right out of 3 [0/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");    
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}

else if (choice == "c"){
Console.WriteLine("Good answer. The red squirrel is actually a very common animal in Scotland.");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was a try I guess?. You did try right?");
Console.WriteLine("You got 0 right out of 3 [0/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "c"){
Console.WriteLine("That was a try I guess?. You did try right?");
Console.WriteLine("You got 0 right out of 3 [0/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");    
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}

else if (choice == "c")
{
Console.WriteLine("Finally a half capable human.");
Console.WriteLine("Even though you did choose the correct alternative I must ask you question 2.");  
Console.WriteLine("Here it comes:");
Console.WriteLine("");
Console.WriteLine("What is Scotlands national animal?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Unicorn");
Console.WriteLine("b) Snake");
Console.WriteLine("c) Squirrel");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was a tricky one right?");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was a decent try. You did pretty good!");
Console.WriteLine("You got 2 right out of 3 [2/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("You did AMAZING! Congratulations!");
Console.WriteLine("Your score is 3 right answers out of 3 [3/3]!");
Console.WriteLine("Hope you found my quiz half fun and enjoyable!");
Console.WriteLine($"Congratulations again {name}! Have a beautiful life!");
Console.WriteLine("Press [ENTER] to quit with your perfect score!");
}

else if (choice == "c"){
Console.WriteLine("That was a decent try. You did pretty good!");
Console.WriteLine("You got 2 right out of 3 [2/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");    
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}

else if (choice == "b"){
Console.WriteLine("Nice try. I would have answered Unicorn just for the fun of it.");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("That was a decent try. You did pretty good!");
Console.WriteLine("You got 2 right out of 3 [2/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "c"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}

else if (choice == "c"){
Console.WriteLine("Good answer. The red squirrel is actually a very common animal in Scotland.");
Console.WriteLine("Alright. Let's keep up the pace and get right into question 3:");
Console.WriteLine("");
Console.WriteLine("What is the fear of vegetables called?");
Console.WriteLine("Is it:");
Console.WriteLine("a) Arachnophobia");
Console.WriteLine("b) Lachanophobia");
Console.WriteLine("c) Hippopotomonstrosesquippedaliophobia");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "b"){
Console.WriteLine("That was a decent try. You did pretty good!");
Console.WriteLine("You got 2 right out of 3 [2/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");
}

else if (choice == "c"){
Console.WriteLine("That was an honest try. Unfortunately not a very good one.");
Console.WriteLine("You got 1 right out of 3 [1/3].");
Console.WriteLine("Better luck next time!");
Console.WriteLine("Press [ENTER] to quit.");    
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}
else {
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
}
else{
Console.WriteLine("You tried tricking the system. It didn't work. Now leave by pressing [ENTER] and don't try that again.");
}
Console.ReadLine();