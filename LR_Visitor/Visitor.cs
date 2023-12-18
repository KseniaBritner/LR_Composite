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
        public abstract void Visit(Menu menu);
        public abstract void Visit(Section section);
        public abstract void Visit(MenuItem menuItem);
        public abstract void Visit(Dish dish);
        public abstract object GetResult();
    }
}
