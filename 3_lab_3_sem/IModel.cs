using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_3_sem
{
    public interface IModel
    {
        event Action Changed;
        void addNode(int value);
        void RemoveLastNode();
        int Count { get; }
        IEnumerable<Node> AllNodes { get; }
    }
}
