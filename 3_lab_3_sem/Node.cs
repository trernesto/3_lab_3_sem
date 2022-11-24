using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_3_sem
{
    public class Node
    {
        private int x,y, value;
        public int X => x;
        public int Y => y;
        public int Value => value;

        public Node(int value, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }
    }
}
