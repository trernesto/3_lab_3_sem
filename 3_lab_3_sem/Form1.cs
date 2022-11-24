using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_lab_3_sem
{
    public partial class Form1 : Form, IController
    {
        static Random r = new Random();
        List<IView> views = new List<IView>();
        IModel model;
        IModel IController.Model 
        { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Form1()
        {
            InitializeComponent();
        }

        public void AddView(IView view)
        {
            views.Add(view);
        }

        public void Add()
        {
            model.addNode(r.Next(100));
        }

        public void Remove()
        {
            model.RemoveLastNode();
        }
    }
}
