using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    abstract class Item
    {
        string _itemName;
        ItemsEffect _effect;
        Boolean _isConsumable;
        Boolean _isEquippable;

        public void use(Hero hero)
        {
            hero.setCurHealth(hero.getCurHealth() + _effect.getHealthValue());
            hero.setCurMana(hero.getCurMana() + _effect.getManaValue());
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
    }
}
