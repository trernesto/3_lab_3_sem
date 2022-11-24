using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_3_sem
{
    public interface IController
    {
        IModel Model { get; set; }
        void AddView(IView view);
        void Add();
        void Remove();
    }
}
