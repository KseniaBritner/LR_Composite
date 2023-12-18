using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class IComponent
    {
        public List<IComponent> _components = new List<IComponent>();
        public int i;
        public abstract void Add(IComponent component) ;
        public abstract void Print();
        public abstract void Remove(IComponent component);
        public abstract void Accept(LR_Visitor.Visitor visitor);
        public bool IsNext()
        {
            return _components.Count >= i;
        }
        public IComponent Next()
        {
            if (!_components[i].IsNext())
            {
                i++;
            }
            if (_components.Count == i)
            {
                i++;
                return this;
            }
            return _components[i].IsNext() ? _components[i].Next() : throw new Exception("end");
        }
    }
}
