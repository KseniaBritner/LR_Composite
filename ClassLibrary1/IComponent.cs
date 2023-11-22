using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IComponent
    {
        void Add(IComponent component);
        void Print();
        void Remove(IComponent component);
    }
}
