using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLearning
{
    public class LinkeListLearningnew
    {
        public void Display(LinkedList<string> linkeListName)
        {
            Console.Write("The linked list values: ");
            foreach (string word in linkeListName)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
