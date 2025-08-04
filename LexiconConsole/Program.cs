bool running = true;
while (running)
{
    Console.Clear();
    Console.WriteLine("Calculator\n\nChoices:");
    Console.WriteLine("    1: Addition");
    Console.WriteLine("    2: Subtraction");
    Console.WriteLine("    3: Multiplication");
    Console.WriteLine("    4: Division");
    Console.WriteLine("    5: Power");
    Console.WriteLine("    6: Root");
    Console.WriteLine("    7: Quit");
    Console.Write("\n> ");
    string input = Console.ReadLine() ?? "";
    switch (input)
    {
        case "1":
            Addition();
            break;
        case "2":
            Subtraction();
            break;
        case "3":
            Multiplication();
            break;
        case "4":
            Division();
            break;
        case "5":
            Power();
            break;
        case "6":
            Root();
            break;
        case "7":
            running = false;
            break;
        default:
            break;
    }
}
static void Addition()
{
    string s = "Addition\n\n";
    float a = GetNumber(s + "Input term A");
    float b = GetNumber(s + "Input term B");
    float c = a + b;
    PrintResult(a.ToString() + " + " + b.ToString() + " = " + c);
}
static void Subtraction()
{
    string s = "Subtraction\n\n";
    float a = GetNumber(s + "Input term A");
    float b = GetNumber(s + "Input term B");
    float c = a - b;
    PrintResult(a.ToString() + " - " + b.ToString() + " = " + c);
}
static void Multiplication()
{
    string s = "Multiplication\n\n";
    float a = GetNumber(s + "Input factor A");
    float b = GetNumber(s + "Input factor B");
    float c = a * b;
    PrintResult(a.ToString() + " * " + b.ToString() + " = " + c);
}
static void Division()
{
    string s = "Division\n\n";
    float a = GetNumber(s + "Input numerator");
    float b = GetNumber(s + "Input denominator");
    float c = a / b;
    if (b == 0)
        PrintResult("Cannot divide by 0");
    else
        PrintResult(a.ToString() + " / " + b.ToString() + " = " + c.ToString());
}
static void Power()
{
    string s = "Power\n\n";
    float a = GetNumber(s + "Input base:");
    float b = GetNumber(s + "Input power:");
    float c = (float)Math.Pow(a,b);
    PrintResult(a.ToString() + " ^ " + b.ToString() + " = " + c.ToString());
}
static void Root()
{
    string s = "Root\n\n";
    float a = GetNumber(s + "Input degree:");
    float b = GetNumber(s + "Input radicand:");
    string c = Math.Sign(b) == -1 ? "imaginary" : Math.Pow(b, 1.0 / a).ToString();
    PrintResult("The root of " + b.ToString() + " with the degree " + b.ToString() + " is " + c);
}
static void PrintResult(string res)
{
    Console.Clear();
    Console.WriteLine("Result:\n");
    Console.WriteLine(res);
    Console.WriteLine("\nPress any key to continue");
    Console.ReadKey();
}
static float GetNumber(string text)
{
    string message = "";
    while (true)
    {
        Console.Clear();
        if (message != "")
        {
            Console.WriteLine(message + "\n");
            message = "";
        }
        Console.WriteLine(text);
        Console.WriteLine();
        Console.Write("> ");
        if (float.TryParse(Console.ReadLine(), out float num))
            return num;
        message = "Could not parse number";
    }
}