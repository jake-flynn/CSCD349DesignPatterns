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
        public Consumable[] _Consumable;
        public Equipment[] _Equipment;
        public int _ConsumableNextFreeIndex;
        public int _EquipmentNextFreeIndex;

        public Inventory()
        {
            _Consumable = new Consumable[20];
            _Equipment = new Equipment[20];
            _ConsumableNextFreeIndex = 0;
            _EquipmentNextFreeIndex = 0;
            Consumable consumable = new LesserPotionOfHealth();
            this.addLastToConsumable(consumable);
            consumable = new PotionOfHealth();
            this.addLastToConsumable(consumable);
            consumable = new LesserPotionOfMana();
            this.addLastToConsumable(consumable);
            consumable = new PotionOfMana();
            this.addLastToConsumable(consumable);
            Equipment equip = new BronzeSword();
            this.addLastToEquipment(equip);
        }

        public Consumable findConsumableByIndex(int index)
        {
            return _Consumable[index];
        }

        public int findIndexOfConsumable(Item _item)
        {
            for (int x = 0; x < _Consumable.Length; x++)
            {
                if(_Consumable[x].getItemName().Equals(_item.getItemName()))
                {
                    return x;
                }
            }

            return -1;
        }

        public Equipment findEquipmentByIndex(int index)
        {
            return _Equipment[index];
        }

        public int findIndexOfEquipment(Item _item)
        {
            for (int x = 0; x < _Equipment.Length; x++)
            {
                if (_Equipment[x].getItemName().Equals(_item.getItemName()))
                {
                    return x;
                }
            }

            return -1;
        }

        public void addLastToConsumable(Consumable itemToAdd) //will be renamed addToInventory
        {
            if (_ConsumableNextFreeIndex < _Consumable.Length)
            {
                _Consumable[_ConsumableNextFreeIndex] = itemToAdd;
                _ConsumableNextFreeIndex++;
            }
            else
            {
                MessageBox.Show("Your packs are full! You cannot carry another pound.");
            }
        }

        public void addLastToEquipment(Equipment itemToAdd) //will be renamed addToInventory
        {
            if (_EquipmentNextFreeIndex < _Equipment.Length)
            {
                _Equipment[_EquipmentNextFreeIndex] = itemToAdd;
                _EquipmentNextFreeIndex++;
            }
            else
            {
                MessageBox.Show("Your packs are full! You cannot carry another pound.");
            }
        }

        public Item removeFromConsumable(int indexOfItem)
        {
            if(_ConsumableNextFreeIndex == 0)
            {
                return new nullItem();
            }

            else
            {
                Item item = findConsumableByIndex(indexOfItem);
                _Consumable[indexOfItem] = null;
                _ConsumableNextFreeIndex--;
                return item;
            }
        }

        public Item removeFromEquipment(int indexOfItem)
        {
            if (_EquipmentNextFreeIndex == 0)
            {
                return new nullItem();
            }

            else
            {
                Item item = findEquipmentByIndex(indexOfItem);
                _Equipment[indexOfItem] = null;
                _EquipmentNextFreeIndex--;
                return item;
            }
        }
    }
}
