using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLearning
{
    public class AddWordBeginningLinkedList
    {
        public void AddWordBeginning(LinkedList<string> linkeListName)
        {
            Console.Write("Enter The Word Which You want to add at Beginning: ");
            string? userInputWord = Console.ReadLine();

            linkeListName.AddFirst(userInputWord);
        }
    }
}
