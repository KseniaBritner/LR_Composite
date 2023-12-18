using LR_Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Menu : IComponent
    {
        private string _name;
        public Menu(string name)
        {
            _name = name;
        }
        public override void Add(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Блюда не существует");
            }
            _components.Add(component);
        }
        public override void Print()
        {
            Console.WriteLine($"Меню {_name}:");
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
                throw new InvalidOperationException("Указанное блюдо не найдено в меню");
            }
            _components.Remove(component);
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
