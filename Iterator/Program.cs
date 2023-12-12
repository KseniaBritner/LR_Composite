using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Iterator
{
    internal class Program
    {
        static void Main()
        {
            MenuItem[] menuItemsArray = {
                new MenuItem("Овощной салат", true),
                new MenuItem("Салат Цезарь с курицей", false),
                new MenuItem("Мороженое с фруктами", true),
            };
            List<MenuItem> menuItems = new List<MenuItem>(menuItemsArray);
            IIterator<MenuItem> arrayMenu = new MenuArrayIterator(menuItemsArray);
            IIterator<MenuItem> reverseMenu = new MenuReverseListIterator(menuItems);
            IIterator<MenuItem> veganMenu = new MenuVeganIterator(menuItems);

            PrintMenu(arrayMenu);
            Console.WriteLine();
            PrintMenu(reverseMenu);
            Console.WriteLine();
            PrintMenu(veganMenu);
        }
        static void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                menuItem.Print();
            }
        }
    }
}
