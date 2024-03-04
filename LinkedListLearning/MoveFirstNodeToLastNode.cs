using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLearning
{
    public class MoveFirstNodeToLastNode
    {
        public void MoveFirstToLast(LinkedList<string> linkeListName)
        {
            LinkedListNode<String> mark1 = linkeListName.First;
            linkeListName.RemoveFirst();
            linkeListName.AddLast(mark1);
        }
    }
}
