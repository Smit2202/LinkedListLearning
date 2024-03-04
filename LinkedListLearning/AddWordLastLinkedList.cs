using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLearning
{
    public class AddWordLastLinkedList
    {
        public void AddWordLast(LinkedList<string> linkeListName)
        {
            Console.Write("Enter The Word Which You want to add at Beginning: ");
            string? userInputWord = Console.ReadLine();

            linkeListName.AddLast(userInputWord);
        }
    }
}
