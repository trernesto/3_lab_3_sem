using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_lab_3_sem
{
    public class PanelView : Panel, IView
    {
        public delegate void ChangeColor(Node node);
        public event ChangeColor PanelClicked;
        public IModel Model 
        { get; set; }

        public void UpdateView()
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Model == null) return;
            Graphics g = e.Graphics;
            foreach (Node n in Model.AllNodes)
            {
                g.DrawEllipse(n.Color, n.X * 20, n.Y * 20, 20, 20);
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            Node SavedNode = null;
            foreach (Node n in Model.AllNodes)
            {
                if (n.X == e.X / 20 && n.Y == e.Y / 20 )
                {
                    SavedNode = n;
                }
            }
            if (SavedNode != null)
            {
                PanelClicked(SavedNode);
            }
            UpdateView();
        }
    }
}
