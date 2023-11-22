using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Section : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();
        private string _name;

        public Section(string name)
        {
            _name = name;
        }
        public void Add(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Компонент не существует");
            }
            _components.Add(component);
        }
        public void Print()
        {
            Console.WriteLine($"{_name}:");
            foreach (var component in _components)
            {
                component.Print();
            }
        }
        public void Remove(IComponent component)
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
    }
}
