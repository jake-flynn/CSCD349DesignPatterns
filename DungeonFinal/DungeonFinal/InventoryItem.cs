using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class InventoryItem
    {
        Item _item;
        int _amount;

        public InventoryItem(Item _item, int _amount)
        {
            this._item = _item;
            this._amount = _amount;
        }

        public void setItem(Item _item)
        {
            this._item = _item;
        }

        public void setAmount(int _amount)
        {
            this._amount = _amount;
        }

        public Item getItem()
        {
            return this._item;
        }

        public int getAmount()
        {
            return this._amount;
        }

    }
}
