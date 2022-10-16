using Lesson3Calc;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;


internal class Program
{
    public static void Main(string[] args)
    {
        DisplayOutput displayOutput = new DisplayOutput();
        SwitchOper switchOper = new SwitchOper();
        double total = 0;
        char again = 'Y';
        while (again == 'Y')
        {
            total = switchOper.EnterNumAndSwitchOper();
            
            
            displayOutput.AddForList(total);

            switchOper.ContinueWorking();
            again = switchOper.сontinue;
            if (again == 'Y')
            {
                switchOper.RepeatOperation();
            }
            else
            {
                break;
            }
            
        }
  

    }
}
