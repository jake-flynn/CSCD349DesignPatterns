using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public abstract class Item
    {
        Effect _effect;
        string _itemName;

        public Item()
        { }

        public void setEffect(Effect effect)
        {
            this._effect = effect;
        }

        public Effect getEffect()
        {
            return this._effect;
        }

        public void setName(string name)
        {
            _itemName = name;
        }
        public string getName()
        {
            return this._itemName;
        }

    }
}
