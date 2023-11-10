// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.DarkRed;

string repeat = "Y";

int x_pos = 0;
do
{

    Console.SetCursorPosition(x_pos, 0);

    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

    Console.WriteLine($"Key Char: {keyInfo.KeyChar}");

    Console.SetCursorPosition(0, 2);

    Console.WriteLine($"Key: {keyInfo.Key.ToString()}");
    Console.WriteLine($"Key: {keyInfo.Modifiers.ToString()}");

    Console.Write("Do you want to find the information of another key? (y/n): ");

    repeat = Console.ReadLine();

} while (repeat == "Y" || repeat == "y");
