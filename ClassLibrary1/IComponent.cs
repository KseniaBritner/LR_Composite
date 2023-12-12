using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class IComponent
    {
        public abstract void Add(IComponent component) ;
        public abstract void Print();
        public abstract void Remove(IComponent component);
    }
}
