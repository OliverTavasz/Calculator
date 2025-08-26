using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconConsole
{
    public static class Calculator
    {
        private static bool Running = true;
        public static void Run()
        {
            while (Running)
            {
                Console.Clear();
                Console.WriteLine("Calculator\n\nEnter a number to choose:");
                Console.WriteLine("    1: Addition");
                Console.WriteLine("    2: Subtraction");
                Console.WriteLine("    3: Multiplication");
                Console.WriteLine("    4: Division");
                Console.WriteLine("    5: Power");
                Console.WriteLine("    6: Root");
                Console.WriteLine("    7: Quit");
                Console.Write("\n> ");
                switch (Console.ReadLine() ?? "")
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
                        Running = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private static void Addition()
        {
            string s = "Addition\n\n";
            float a = GetNumber(s + "Input term A");
            float b = GetNumber(s + "Input term B");
            float c = DoAddition(a, b);
            PrintResult(a.ToString() + " + " + b.ToString() + " = " + c);
        }
        public static float DoAddition(float a, float b)
        {
            return a + b;
        }
        private static void Subtraction()
        {
            string s = "Subtraction\n\n";
            float a = GetNumber(s + "Input term A");
            float b = GetNumber(s + "Input term B");
            float c = DoSubtraction(a, b);
            PrintResult(a.ToString() + " - " + b.ToString() + " = " + c);
        }
        public static float DoSubtraction(float a, float b)
        {
            return a - b;
        }
        private static void Multiplication()
        {
            string s = "Multiplication\n\n";
            float a = GetNumber(s + "Input factor A");
            float b = GetNumber(s + "Input factor B");
            float c = DoMultiplication(a, b);
            PrintResult(a.ToString() + " * " + b.ToString() + " = " + c);
        }
        public static float DoMultiplication(float a, float b)
        {
            return a * b;
        }
        private static void Division()
        {
            string s = "Division\n\n";
            float a = GetNumber(s + "Input numerator");
            float b = GetNumber(s + "Input denominator");
            float c = DoDivision(a, b); ;
            if (b == 0)
                PrintResult("Cannot divide by 0");
            else
                PrintResult(a.ToString() + " / " + b.ToString() + " = " + c.ToString());
        }
        public static float DoDivision(float a, float b)
        {
            return a / b;
        }
        private static void Power()
        {
            string s = "Power\n\n";
            float a = GetNumber(s + "Input base:");
            float b = GetNumber(s + "Input power:");
            float c = DoPower(a, b);
            PrintResult(a.ToString() + " ^ " + b.ToString() + " = " + c.ToString());
        }
        public static float DoPower(float a, float b)
        {
            return (float)Math.Pow(a, b);
        }
        private static void Root()
        {
            string s = "Root\n\n";
            float a = GetNumber(s + "Input degree:");
            float b = GetNumber(s + "Input radicand:");
            string c = DoRoot(a, b);
            PrintResult("The root of " + b.ToString() + " with the degree " + a.ToString() + " is " + c);
        }
        public static string DoRoot(float a, float b)
        {
            return Math.Sign(b) == -1 ? "imaginary" : Math.Pow(b, 1.0 / a).ToString();
        }
        private static void PrintResult(string res)
        {
            Console.Clear();
            Console.WriteLine("Result:\n");
            Console.WriteLine(res);
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
        private static float GetNumber(string text)
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
    }
}
