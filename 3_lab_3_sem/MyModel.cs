using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_3_sem
{
    internal class MyModel : IModel
    {
        LinkedList<Node> nodes = new LinkedList<Node>();
        public int Count => nodes.Count;

        static Random r = new Random();
        public void addNode(int value)
        {
            nodes.AddFirst(new Node(value, r.Next(10), r.Next(10)));
        }

        public void RemoveLastNode()
        {
            nodes.RemoveLast();
        }
    }
}
