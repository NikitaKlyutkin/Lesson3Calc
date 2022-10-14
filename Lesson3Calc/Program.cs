using Lesson3Calc;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;


internal class Program
{
    public static void Main(string[] args)
    {
        double number1 = 0;
        double number2 = 0;
        double total = 0;

        char oper;
        char again = 'Y';

        int resize = 0;
        char repit;
        char repitdoit = 'N';

        DisplayOutput displayOutput = new DisplayOutput();

        while (again == 'Y')
        {
            try
            {
                ++resize;
                Console.WriteLine($"Operation {resize}");
                Console.WriteLine("Enter the first number(1):");
                number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number(2):");
                number2 = double.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Failed to convert string to number");
                Console.ReadLine();
                continue;
            }
            if (repitdoit == 'N')
            {
                Console.WriteLine("Enter operator( * , / , + , - ):");
                oper = Convert.ToChar(Console.ReadLine());
            }
            else
            {
                oper = repitdoit;
            }
            switch(oper)
            {
                case '+':
                    repitdoit = '+';
                    total = number1 + number2;
                    Console.WriteLine($"Sum {number1} and {number2} result {total} .");
                    break;
                case '-':
                    repitdoit = '-';
                    total = number1 - number2;
                    Console.WriteLine($"Difference {number1} and {number2} result {total} .");
                    break;
                case '*':
                    repitdoit = '*';
                    total = number1 * number2;
                    Console.WriteLine($"Multiplication {number1} and {number2} result {total} .");
                    break;
                case '/':
                    repitdoit = '/';
                    if (number1 == 0)
                    {
                        total = 0;
                        Console.WriteLine($"Can't divide by zero, result: {total}");
                    }
                    else
                    {
                        total = number1 / number2;
                        Console.WriteLine($"Division {number1} and {number2} result {total}.");
                    }
                    break;
                default: 
                    Console.WriteLine("Unknown operator.");
                    break;

            }
            
            displayOutput.AddForList(total);

            Console.Write("Do you want to continue working? (Y/N): ");
            again = Convert.ToChar(Console.ReadLine());
            if (again == 'y' || again == 'Y')
            {
                again = 'Y';
            }
            else
            {
                displayOutput.DisplayHis();
                break;
            }

            Console.Write("Repeat operation? (Y/N): ");
            repit = Convert.ToChar(Console.ReadLine());
            if (repit == 'Y')
            {
                oper = repitdoit;
            }
            else
            {
                repitdoit = 'N';
            }  
        }
  

    }
}
