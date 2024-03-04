using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLearning
{
    public class MoveLastNodeToFirstNode
    {
        public void MoveLastToFirst(LinkedList<string> linkeListName)
        {
            LinkedListNode<String> mark1 = linkeListName.Last;
            linkeListName.RemoveLast();
            linkeListName.AddFirst(mark1);
        }
    }
}
