using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Iterator;

namespace LR_Visitor
{
    public class ObjectStruct
    {
        private ClassLibrary1.IComponent _root;
        public ObjectStruct(ClassLibrary1.IComponent root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root), "Недопустимое значение");
            }
            _root = root;
        }
        public void Accept(LR_Visitor.Visitor visitor)
        {
            List<ClassLibrary1.IComponent> components = new List<ClassLibrary1.IComponent>();
            ClassLibrary1.IComponent root = _root;

            while (root != null || components.Count > 0)
            {
                while (root != null)
                {
                    components.Add(root);
                    root = root.IsNext() ? root.Next() : null;
                }
                int lastIndex = components.Count - 1;
                root = components[lastIndex];
                components.RemoveAt(lastIndex);

                root.Accept(visitor);
                root = root.IsNext() ? root.Next() : null;
            }
        }
    }
}
