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
    public class Inventory
    {
        public InventoryItem[] _inventory;
        public int _invNextFreeIndex;

        public Inventory()
        {
            _inventory = new InventoryItem[20];
            _invNextFreeIndex = 0;
            Item item = new PotionOfHealth();
            this.addLast(item);
        }
        

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

        public Item findItem(int index)
        {
            return _inventory[index].getItem();
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

        public void addLast(Item itemToAdd) //will be renamed addToInventory
        {
            if (_invNextFreeIndex < _inventory.Length)//if there is still room to add.
            {
                _inventory[_invNextFreeIndex] = new InventoryItem(itemToAdd, 1);
                _invNextFreeIndex++;
            }
            else
            {
                MessageBox.Show("Your packs are full! You cannot carry another pound.");
            }
        }

        public Item remove(int indexOfItem)
        {
            if(_invNextFreeIndex == 0)
            {
                // cannot remove anything because it's empty
                return new nullItem();
            }

            else
            {
                Item item = findItem(indexOfItem);

                if(item.getItemName().Equals("Null Item"))
                {
                    // handling edge case of null item in inventory.
                }

                else
                {

                    return item;
                }

                return item;
            }
        }
    }
}
