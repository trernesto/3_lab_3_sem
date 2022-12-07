using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_3_sem
{
    internal class MyModel : IModel
    {
        List<Node> heap = new List<Node>();
        public int Count => heap.Count;

        public IEnumerable<Node> AllNodes => heap;

        static Random r = new Random();

        public event Action Changed;

        public void addNode(int value)
        {
            Insert(value);
            if (Changed != null)
            {
                Changed();
            }
        }

        public void RemoveLastNode()
        {
            RemoveMin();
            if (Changed != null)
            {
                Changed();
            }
        }

        void Insert(int x)
        {
            int i = heap.Count;
            heap.Add(new Node(x));
            //sift up
            //swap child and parent until heap return to normal
            while (i > 0 && heap[i].Value < heap[(i - 1) / 2].Value)
            {
                Node temp = heap[i];
                heap[i] = heap[(i - 1) / 2];
                heap[(i - 1) / 2] = temp;
                i = (i - 1) / 2;
            }
        }

        void RemoveMin()
        {
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            int i = 0;
            while (2 * i + 1 < heap.Count)
            {
                int j = 2 * i + 1;
                if (2 * i + 2 < heap.Count && heap[2 * i + 2].Value < heap[j].Value)
                {
                    j = 2 * i + 2;
                }
                if (heap[i].Value < heap[j].Value)
                {
                    break;
                }
                else
                {
                    Node temp = heap[i];
                    heap[i] = heap[j];
                    heap[j] = temp;
                    i = j;
                }
            }
        }
    }
}
