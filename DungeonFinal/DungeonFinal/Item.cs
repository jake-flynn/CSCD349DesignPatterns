using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    abstract class Item
    {
        Item[] sockets;
        int socketNumber = 0;
        string _itemName;
        ItemsEffect _effect;
        Boolean _isConsumable = false;
        Boolean _isEquippable = false;
        Boolean _isSocketable = false;

        public void use(Hero _hero)
        {
            _hero.setCurHealth(_hero.getCurHealth() + _effect.getHealthValue());
            _hero.setCurMana(_hero.getCurMana() + _effect.getManaValue());
            _hero.setModStrength(_hero.getModStrength() + _effect.getStrengthValue());
            _hero.setModMagic(_hero.getModMagic() + _effect.getMagicValue());
            _hero.setModDefense(_hero.getModDefense() + _effect.getPhysicalDefenseValue());
            _hero.setModResistance(_hero.getModResistance() + _effect.getResistanceDefenseValue());
        }  

        public void unUse(Hero _hero)
        {
            _hero.setCurHealth(_hero.getCurHealth() - _effect.getHealthValue());
            _hero.setCurMana(_hero.getCurMana() - _effect.getManaValue());
            _hero.setModStrength(_hero.getModStrength() - _effect.getStrengthValue());
            _hero.setModMagic(_hero.getModMagic() -_effect.getMagicValue());
            _hero.setModDefense(_hero.getModDefense() - _effect.getPhysicalDefenseValue());
            _hero.setModResistance(_hero.getModResistance() - _effect.getResistanceDefenseValue());
        }

        public void socket(Hero _hero, Item _item)
        {
            if(this._isEquippable)
            {
                if(_item._isSocketable)
                {
                    if(socketNumber > sockets.Length)
                    {
                        // all sockets are full
                    }

                    else
                    {
                        sockets[socketNumber] = _item;
                        socketNumber++;
                        allocate(_hero, _item);
                    }
                    
                }

                else
                {
                    // item attempting to be put into other item isn't socketable ie. putting a helmet into a sword
                }
            }

            else
            {
                // can't put anything into an item that isn't equippable
            }
        }

        public void allocate(Hero _hero, Item _item)
        {
            this._effect.setHealthValue(this._effect.getHealthValue() + _item._effect.getHealthValue());
            this._effect.setManaValue(this._effect.getManaValue() + _item._effect.getManaValue());
            this._effect.setStrengthValue(this._effect.getStrengthValue() + _item._effect.getStrengthValue());
            this._effect.setMagicValue(this._effect.getMagicValue() + _item._effect.getMagicValue());
            this._effect.setPhysicalDefense(this._effect.getPhysicalDefenseValue() + _item._effect.getPhysicalDefenseValue());
            this._effect.setResistanceDefense(this._effect.getResistanceDefenseValue() + _item._effect.getResistanceDefenseValue());
            _item.use(_hero);
        }

        public void setSocketAmount(int sockets)
        {
            this.sockets = new Item[sockets];
        }

        public void setItemName(string _itemName)
        {
            this._itemName = _itemName;
        }

        public void setEffect(ItemsEffect _effect)
        {
            this._effect = _effect;
        }

        public void setConsumable(Boolean _isConsumable)
        {
            this._isConsumable = _isConsumable;
        }

        public void setEquippable(Boolean _isEquippable)
        {
            this._isEquippable = _isEquippable;
        }

        public void setSocketable(Boolean _isSocketable)
        {
            this._isSocketable = _isSocketable;
        }

        public string getItemName()
        {
            return _itemName;
        }

        public ItemsEffect getEffect()
        {
            return _effect;
        }

        public Boolean getConsumable()
        {
            return _isConsumable;
        }

        public Boolean getEquippable()
        {
            return _isEquippable;
        }

        public Boolean setSocketable()
        {
            return _isSocketable;
        }

        public int getSocketAmount()
        {
            return sockets.Length;
        }
    }
}
