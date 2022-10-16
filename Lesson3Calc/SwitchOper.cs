using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Calc
{
    internal class SwitchOper
    {
        public static char repitdoit = 'N';
        public char сontinue;
        double total = 0;
        DisplayOutput displayOutput = new DisplayOutput();
        MathOperation mathOperation = new MathOperation();
        int resize = 0;
        double number1 = 0;
        double number2 = 0;
        char oper;
        char repit;
        public double EnterNumAndSwitchOper()
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
            switch (oper)
            {
                case '+':
                    repitdoit = '+';
                    total = mathOperation.SumOper(number1, number2);
                    Console.WriteLine($"Sum {number1} and {number2} result {total} .");
                    
                    
                    
                    break;
                case '-':
                    repitdoit = '-';
                    total = mathOperation.DifOper(number1, number2);
                    Console.WriteLine($"Difference {number1} and {number2} result {total} .");
                    
                    break;
                case '*':
                    repitdoit = '*';
                    total = mathOperation.MultOper(number1, number2);
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
                        total = mathOperation.DivOper(number1, number2);
                        Console.WriteLine($"Division {number1} and {number2} result {total}.");
                        
                    }
                    break;
                default:
                    Console.WriteLine("Unknown operator.");
                    break;

            }
            return total;
        }
        public char RepeatOperation()
        {

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
            return repitdoit;
        }
        public char ContinueWorking()
        {
            char again;
            Console.Write("Do you want to continue working? (Y/N): ");
            again = Convert.ToChar(Console.ReadLine());
            if (again == 'y' || again == 'Y')
            {
                again = 'Y';
                сontinue = 'Y';
                
            }
            else if (again == 'N' || again == 'n')
            {
                
                displayOutput.DisplayHis();
                сontinue = 'N';
            }
            return again;

        }
    }
}
