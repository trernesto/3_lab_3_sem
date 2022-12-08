using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_lab_3_sem
{
    public class MessageView : Label, IView
    {
        public IModel Model { get; set; }

        public void UpdateView()
        {
            Text = Model.Message;
        }
    }
}
