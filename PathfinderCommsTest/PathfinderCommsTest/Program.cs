List<string> directions = new List<string>
{
    "Right",
    "Down",
    "Left",
    "Up",
};

string text = Console.ReadLine();
if (text == "Reading?")
{
    Console.WriteLine("Test Bot");
}

int boardSize = int.Parse(Console.ReadLine());
Console.ReadLine(); // Start message

string surroundings = Console.ReadLine();
Console.WriteLine("# Console Test");
Console.WriteLine("# Board Size = " + boardSize.ToString());

Console.WriteLine("Right");
Console.WriteLine("Over");
Console.ReadLine();

do
{
    surroundings = Console.ReadLine();
    Console.WriteLine("Right");
    Console.WriteLine("Over");
}
while (Console.ReadLine() == "Confirm");


do
{
    surroundings = Console.ReadLine();
    Console.WriteLine("Down");
    Console.WriteLine("Over");
}
while (Console.ReadLine() == "Confirm");


do
{
    surroundings = Console.ReadLine();
    Console.WriteLine("Left");
    Console.WriteLine("Over");
}
while (Console.ReadLine() == "Confirm");

do
{
    surroundings = Console.ReadLine();
    Console.WriteLine("Up");
    Console.WriteLine("Over");
}
while (Console.ReadLine() == "Confirm");
