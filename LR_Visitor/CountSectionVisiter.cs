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
        public override void Visit(Menu menu)
        {
            SectionCount++;
            foreach (var component in menu.GetComponents())
            {
                component.Accept(this);
            }
        }
        public override void Visit(Section section)
        {
            SectionCount++;
            foreach (var component in section.GetComponents())
            {
                component.Accept(this);
            }
        }
        public override void Visit(MenuItem menuItem)
        {
            // Implementation for MenuItem if needed
        }
        public override void Visit(Dish dish)
        {
            // Implementation for Dish if needed
        }
        public override object GetResult()
        {
            return SectionCount;
        }
    }
}
