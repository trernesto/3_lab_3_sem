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
            double dividend = 1;
            double divisor = 2;
            int height = 0;
            foreach (Node n in Model.AllNodes)
            {
                int width = (int)(dividend / divisor * this.Size.Width);
                g.DrawEllipse(n.Color,
                    width, 
                    height, 20, 20);
                g.DrawString(n.Value.ToString(),
                    Font,
                    Brushes.Black,
                    width + 3, height + 4);
                dividend += 2;
                if (dividend / divisor > 1)
                {
                    dividend = 1;
                    height = this.Size.Height - (int)(this.Size.Height / divisor);
                    divisor *= 2;
                }
            }
        }
    }
}
