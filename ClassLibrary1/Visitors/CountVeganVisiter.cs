using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Iterator;

namespace LR_Visitor
{
    public class CountVeganVisitor : Visitor
    {
        public int VeganCount { get; private set; }
       
        public override void Visit(IComponent component)
        {
            if (component is MenuItem menuItem && menuItem.IsVegan)
            {
                VeganCount++;
            }
        }
        public object GetResult()
        {
            return VeganCount;
        }
    }
}
