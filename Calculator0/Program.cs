Console.Title = ("Calculator");
while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("==========================================");
    Console.WriteLine("==                                      ==");
    Console.WriteLine("==              CALCULATOR              ==");
    Console.WriteLine("==                                      ==");
    Console.WriteLine("==========================================");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Choose operation (+, -, *, /): ");
    string oper = Console.ReadLine();

    Console.Write("Choose 1 number: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Choose 2 number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (oper == "+")
    {
        Console.Write(a + b);
    }
    else if (oper == "-")
    {
        Console.Write(a - b);
    }
    else if (oper == "*")
    {
        Console.Write(a * b);
    }
    else if (oper == "/")
    {
        Console.Write(a / b);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Error!");
    }
    Console.Write(" ");
    Console.Write("Press any key to continue!");
    Console.ReadKey();
    Console.Clear();
}