using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

internal class Program
{
    //public void ArrayFiveResult()
    //{
    //    double[] results = new double[5];
    //    for (int i = 0; i < results.Length; i++)
    //    {
    //        results[i] = total;
    //        Console.Write(results[i] + "\t");
    //    }
    //}
    public static void Main(string[] args)
    {
        double number1 = 0;
        double number2 = 0;
        double total = 0;

        char oper;
        char again = 'Y';
        char fiveElements;
        int numRes = 0;

        double[] results = new double[5];

        while (again == 'Y')
        {

            try
            {
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

            Console.WriteLine("Enter operator( * , / , + , - ):");
            oper = Convert.ToChar(Console.ReadLine());

            switch(oper)
            {
                case '+':
                    total = number1 + number2;
                    Console.WriteLine($"Sum {number1} and {number2} result {total} .");
                    break;
                case '-':
                    total = number1 - number2;
                    Console.WriteLine($"Difference {number1} and {number2} result {total} .");
                    break;
                case '*':
                    total = number1 * number2;
                    Console.WriteLine($"Multiplication {number1} and {number2} result {total} .");
                    break;
                case '/':
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

            Console.Write("Do you want to continue working? (Y/N): ");
            again = Convert.ToChar(Console.ReadLine());
            if (again == 'y')
            {
                again = 'Y';
            }
            results[numRes] = total;
            ++numRes;

        }
        //Запись в массив


        Console.Write("Display the last 5 results?: ");
        fiveElements = Convert.ToChar(Console.ReadLine());
        if (fiveElements == 'Y')
        {
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }
        }

    }
}
