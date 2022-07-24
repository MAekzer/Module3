// See https://aka.ms/new-console-template for more information

Console.Write("What is your name? ");

var name = Console.ReadLine();

Console.Write("What is your age? ");

var age = checked((byte)int.Parse(Console.ReadLine()));
Console.WriteLine("Your name is {0} and age is {1} ", name, age);

Console.Write("What is your favorite day of week? ");

var day = (DayOfWeek)int.Parse(Console.ReadLine());
Console.WriteLine("Your favorite day is {0}", day);

Console.Write("When is your birthday: ");

var birthday = Console.ReadLine();
Console.WriteLine("Your birthday is {0}", birthday);

enum Semaphore
{
    Red = 100,
    Yellow = 200,
    Green = 300
}