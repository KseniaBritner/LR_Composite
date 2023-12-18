using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Section : IComponent
    { 
        private string _name;

        public Section(string name)
        {
            _name = name;
        }
        public override void Add(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Компонент не существует");
            }
            _components.Add(component);
        }
        public override void Print()
        {
            Console.WriteLine($"{_name}:");
            foreach (var component in _components)
            {
                component.Print();
            }
        }
        public override void Remove(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component));
            }
            if (!_components.Contains(component))
            {
                throw new InvalidOperationException("Указанный компонент не найден в секции");
            }
            _components.Remove(component);
        }
        public override void Accept(LR_Visitor.Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
