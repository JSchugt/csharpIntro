
using System;
Console.WriteLine("What is your first name?");
string name = System.Console.ReadLine();
Console.WriteLine("What is your first name?");
string lastName = System.Console.ReadLine();
if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName))
{
    Console.WriteLine("Fine, don't say hello");
}
else
{
    for (int i = name.Length - 1; i >= 0; i--)
    {
        Console.Write(name[i]);
    }
    Console.Write(" ");
    for (int i = lastName.Length - 1; i >= 0; i--)
    {
        Console.Write(lastName[i]);
    }
}
