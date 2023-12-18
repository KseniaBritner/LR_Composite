using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Iterator;

namespace LR_Visitor
{
    public class CountSectionVisitor : Visitor
    {
        public int SectionCount { get; private set; }
        public override void Visit(IComponent component)
        {
            if (component is Section section)
            {
                SectionCount++;
            }
        }
        public object GetResult()
        {
            return SectionCount;
        }
    }
}
