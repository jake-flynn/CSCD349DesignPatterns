using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DungeonFinal
{
    public abstract class Item
    {
        string _itemName;
        ItemsEffect _effect;
        

        public Item()
        {
            _itemName = "Null Item";
        }

        public void setItemName(string _itemName)
        {
            this._itemName = _itemName;
        }

        public void setEffect(ItemsEffect _effect)
        {
            this._effect = _effect;
        }

        public string getItemName()
        {
            return _itemName;
        }

        public ItemsEffect getEffect()
        {
            return _effect;
        }

        //abstract methods
        public abstract ImageBrush getBrush();
    }
}
