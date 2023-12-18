using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Iterator;

namespace LR_Visitor
{
    public class ObjectStruct
    {
        private IComponent _root;
        public ObjectStruct(IComponent root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root), "Недопустимое значение");
            }
            _root = root;
        }
        public void Accept(Visitor visitor)
        {
            _root.Accept(visitor);
        }
    }
}
