using ClassLibrary1;
using Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Visitor
{
    public abstract class Visitor
    {
        public abstract void Visit(IComponent component);
    }
}
