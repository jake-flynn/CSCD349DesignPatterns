using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Inventory
    {
        InventoryItem[] _inventory = new InventoryItem[20];
        int _invNextFreeIndex = 0;

        public InventoryItem find(String _name)
        {
            for (int x = 0; x < _inventory.Length; x++)
            {
                if (_inventory[x].getItem().getItemName().Equals(_name))
                {
                    return _inventory[x];
                }
            }

            return new InventoryItem(new nullItem() , 0);
        }

        public int findIndex(Item _item)
        {
            for (int x = 0; x < _inventory.Length; x++)
            {
                if(_inventory[x].getItem().getItemName().Equals(_item.getItemName()))
                {
                    return x;
                }
            }

            return -1;
        }

        public InventoryItem findItem(Item item)
        {
            return find(item.getItemName());
        }

        public void add(Item _item)
        {
            if(_invNextFreeIndex > _inventory.Length)
            {
                // inventory is full
            }

            else
            {
                InventoryItem _invItem = findItem(_item);

                if (_invItem.getItem().getItemName().Equals("Null Item"))
                {
                    _inventory[_invNextFreeIndex] = new InventoryItem(_item, 1);
                    _invNextFreeIndex++;
                }

                else
                {
                    _invItem.setAmount(_invItem.getAmount() + 1);
                }
            }
        }

        public Item remove(Item _item)
        {
            if(_invNextFreeIndex == 0)
            {
                // cannot remove anything because it's empty
                return new nullItem();
            }

            else
            {
                InventoryItem _invItem = findItem(_item);

                if(_invItem.getItem().getItemName().Equals("Null Item"))
                {
                    // handling edge case of null item in inventory.
                }

                else
                {
                    _invItem.setAmount(_invItem.getAmount() - 1);

                    if(_invItem.getAmount() == 0)
                    {
                        int index = findIndex(_item);

                        if(index == -1)
                        {
                            // handle edge case
                        }

                        else
                        {
                            _inventory[index] = new InventoryItem(new nullItem(), 0);
                        }
                    }
                }

                return _item;
            }
        }
    }
}
