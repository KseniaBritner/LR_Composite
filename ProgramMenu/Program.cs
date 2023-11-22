using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var saladVegetable = new Dish("Овощной салат", false);
            var saladMeat = new Dish("Салат Цезарь с курицей", false);
            var iceCream = new Dish("Мороженое с фруктами", true);
            var saladsSection = new Section("Салаты");
            saladsSection.Add(saladVegetable);
            saladsSection.Add(saladMeat);
            var dessertsSection = new Section("Десерты");
            dessertsSection.Add(iceCream);

            var menu = new Menu("Меню Кафе");
            menu.Add(saladsSection);
            menu.Add(dessertsSection);
            menu.Print();
        }
    }
}
