using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_lab_3_sem
{
    public partial class Form1 : Form, IController
    {
        static Random r = new Random();
        IModel model;
        IModel IController.Model 
        { get => model; set => model = value; }
        IModel Model
        { get => model; set => model = value; }
        public Form1()
        {
            Model = new MyModel();
            InitializeComponent();
            IView labView = new LabelView(label1);
            AddView(labView);
            AddView(panelView1);
            AddView(myDataGridView1);
        }

        public void AddView(IView view)
        {
            view.Model= this.Model;
            model.Changed += new Action(view.UpdateView);
            view.UpdateView();
        }

        public void Add()
        {
            model.addNode(r.Next(100));
        }


        public void Remove()
        {
            if (model.Count > 0) 
            {
                model.RemoveLastNode();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}
