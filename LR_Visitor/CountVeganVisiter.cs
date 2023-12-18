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
        public override void Visit(Menu menu)
        {
            foreach (var component in menu.GetComponents())
            {
                component.Accept(this);
            }
        }
        public override void Visit(Section section)
        {
            VeganCount += section.VeganCount;
        }

        public override void Visit(MenuItem menuItem)
        {
            if (menuItem.IsVegan)
            {
                VeganCount++;
            }
        }
        public override void Visit(Dish dish)
        {

        }
        public override object GetResult()
        {
            return VeganCount;
        }
    }
}
