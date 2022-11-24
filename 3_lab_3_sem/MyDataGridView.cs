using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_lab_3_sem
{
    internal class MyDataGridView : DataGridView, IView
    {
        public IModel Model { get; set; }

        public void UpdateView()
        {
            this.Invalidate();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            var source = new BindingSource();
            source.DataSource = this.Model.AllNodes;
            this.DataSource = source;
        }
    }
}
