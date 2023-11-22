using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dish : IComponent
    {
        private string _name;
        private bool _isVegan;
        public Dish(string name, bool isVegan)
        {
            _name = name;
            _isVegan = isVegan;
        }
        public void Add(IComponent component)
        {
            throw new InvalidOperationException("Блюдо не изменяется");
        }
        public void Print()
        {
            string isVegan = _isVegan ? "Веганское блюдо" : "";
            Console.WriteLine($"- {_name} {isVegan}");
        }

        public void Remove (IComponent component)
        {
            throw new InvalidOperationException("Блюдо не изменяется");
        }
    }
}
