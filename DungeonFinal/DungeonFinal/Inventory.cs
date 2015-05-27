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
        public Item[] _inventory;
        public int _invNextFreeIndex;

        public Inventory()
        {
            _inventory = new Item[20];
            _invNextFreeIndex = 0;
            Item item = new LesserPotionOfHealth();
            this.addLast(item);
            this.addLast(item);
            item = new LesserPotionOfMana();
            this.addLast(item);
            this.addLast(item);
            item = new BronzeSword();
            this.addLast(item);
        }
        

        public Item findInvItemByName(String _name)
        {
            for (int x = 0; x < _inventory.Length; x++)
            {
                if (_inventory[x].getItemName().Equals(_name))
                {
                    return _inventory[x];
                }
            }

            return new nullItem();
        }

        public Item findItemByItem(Item item)
        {
              return findInvItemByName(item.getItemName());
        }

        public Item findItemByIndex(int index)
        {
            return _inventory[index];
        }

        public int findIndexByItem(Item _item)
        {
            for (int x = 0; x < _inventory.Length; x++)
            {
                if(_inventory[x].getItemName().Equals(_item.getItemName()))
                {
                    return x;
                }
            }

            return -1;
        }

        public void addLast(Item itemToAdd) //will be renamed addToInventory
        {
            if (_invNextFreeIndex < _inventory.Length)//if there is still room to add.
            {
                _inventory[_invNextFreeIndex] = itemToAdd;
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
                Item item = findItemByIndex(indexOfItem);

                //if(item.getItemName().Equals("Null Item"))
                //{
                //    MessageBox.Show("Cannot remove a null item!"); // handling edge case of null item in inventory.
                //}

              //  else
              //  {
                    _inventory[indexOfItem] = new nullItem();
                    _invNextFreeIndex--;
                    return item;
               // }

             //   return new nullItem();
            }
        }
    }
}
