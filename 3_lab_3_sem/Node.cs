using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_lab_3_sem
{
    public class Node
    {
        private int value;
        private Pen color;
        public int Value => value;
        public Pen Color { get => color; set => color = value; }

        public Node(int value)
        {
            this.value = value;
            color = Pens.Red;
        }

        public void Recolor()
        {
            color = Pens.Blue;
        }
    }
}
