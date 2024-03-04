using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLearning
{
    public class UserInputForOperation
    {
        public string UserInput()
        {
            Console.WriteLine($"{Environment.NewLine}Show Link List = show, {Environment.NewLine}Add Element in Beginning = aeb, {Environment.NewLine}Remove Element from Beginning = reb, {Environment.NewLine}Add Element in Last = ael, {Environment.NewLine}Remove Element from Last = rel, {Environment.NewLine}Move First Element to Last = mfl, {Environment.NewLine}Move Last Element to Firsrt = mlf.  ");
            Console.WriteLine();
            Console.Write("Enter What You Want to do? : ");
            string? userInput = Console.ReadLine();

            // Return Value of UserInpute.
            return userInput;
        }
    }
}
