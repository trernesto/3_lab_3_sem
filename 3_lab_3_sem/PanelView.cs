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
        public event Action PanelClicked;
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
                g.DrawEllipse(Pens.Red, n.X * 20, n.Y * 20, 20, 20);
            }
        }
    }
}
