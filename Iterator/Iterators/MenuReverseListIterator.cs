using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class MenuReverseListIterator : IIterator<MenuItem>
    {
        private List<MenuItem> _menuItems;
        private int _item;
        public MenuReverseListIterator(List<MenuItem> items)
        {
            _menuItems = items;
            _item = items.Count - 1;
        }
        public bool HasNext()
        {
            return _item >= 0;
        }
        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_item--];
            }
            else
            {
                throw new InvalidOperationException("Больше нет блюд");
            }
        }
    }
}
