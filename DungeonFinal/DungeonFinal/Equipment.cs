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
    public abstract class Equipment : Item
    {
        Item[] sockets;
        int _socketNumber;
        Boolean _isSocketable;
        Boolean _isHelmet;
        Boolean _isTorso;
        Boolean _isGloves;
        Boolean _isBoots;
        Boolean _isWeapon;
        private ImageBrush _ImageBrush;

        public Equipment() : base()
        {
            _socketNumber = 0;
            _isBoots = false;
            _isGloves = false;
            _isHelmet = false;
            _isTorso = false;
            _isWeapon = false;
            _isSocketable = false;
        }

        public string equip(Hero _hero)
        {
            _hero.setCurHealth(_hero.getCurHealth() + getEffect().getHealthValue());
            _hero.setCurMana(_hero.getCurMana() + getEffect().getManaValue());
            _hero.setModStrength(_hero.getModStrength() + getEffect().getStrengthValue());
            _hero.setModMagic(_hero.getModMagic() + getEffect().getMagicValue());
            _hero.setModDefense(_hero.getModDefense() + getEffect().getPhysicalDefenseValue());
            _hero.setModResistance(_hero.getModResistance() + getEffect().getResistanceDefenseValue());
            return _hero.getName() + " equipped " + this.getItemName() + ", " + getEffect().getEffectName() + getEffect().getEffectAmount();
        }

        public string unEquip(Hero _hero)
        {
            _hero.setCurHealth(_hero.getCurHealth() - getEffect().getHealthValue());
            _hero.setCurMana(_hero.getCurMana() - getEffect().getManaValue());
            _hero.setModStrength(_hero.getModStrength() - getEffect().getStrengthValue());
            _hero.setModMagic(_hero.getModMagic() - getEffect().getMagicValue());
            _hero.setModDefense(_hero.getModDefense() - getEffect().getPhysicalDefenseValue());
            _hero.setModResistance(_hero.getModResistance() - getEffect().getResistanceDefenseValue());
            return _hero.getName() + " unequipped " + this.getItemName() + ", " + getEffect().getEffectName() + getEffect().getEffectAmount();
        }

        public void socket(Hero _hero, Item _item)
        {
                if (_isSocketable)
                {
                    if (_socketNumber > sockets.Length)
                    {
                        // all sockets are full
                    }

                    else
                    {
                        sockets[_socketNumber] = _item;
                        _socketNumber++;
                        allocate(_hero, _item);
                    }

                }

                else
                {
                    MessageBox.Show("Cannot socket an item that is not socketable");
                }
        }

        public void allocate(Hero _hero, Item _item)
        {
            getEffect().setHealthValue(this.getEffect().getHealthValue() + _item.getEffect().getHealthValue());
            getEffect().setManaValue(this.getEffect().getManaValue() + _item.getEffect().getManaValue());
            getEffect().setStrengthValue(this.getEffect().getStrengthValue() + _item.getEffect().getStrengthValue());
            getEffect().setMagicValue(this.getEffect().getMagicValue() + _item.getEffect().getMagicValue());
            getEffect().setPhysicalDefense(this.getEffect().getPhysicalDefenseValue() + _item.getEffect().getPhysicalDefenseValue());
            getEffect().setResistanceDefense(this.getEffect().getResistanceDefenseValue() + _item.getEffect().getResistanceDefenseValue());
            this.equip(_hero);
        }

        public void setSocketAmount(int sockets)
        {
            this.sockets = new Item[sockets];
        }

        public int getSocketAmount()
        {
            return sockets.Length;
        }

        public void setIsSocketable(Boolean _isSocketable)
        {
            this._isSocketable = _isSocketable;
        }

        public Boolean getIsSocketable()
        {
            return _isSocketable;
        }

        public void setIsWeapon(Boolean _isWeapon)
        {
            this._isWeapon = _isWeapon;
        }

        public Boolean getIsWeapon()
        {
            return _isWeapon;
        }

        public void setIsHelmet(Boolean _isHelmet)
        {
            this._isHelmet = _isHelmet;
        }

        public Boolean getIsHelmet()
        {
            return _isHelmet;
        }

        public void setIsTorso(Boolean _isTorso)
        {
            this._isTorso = _isTorso;
        }

        public Boolean getIsTorso()
        {
            return _isTorso;
        }

        public void setIsBoots(Boolean _isBoots)
        {
            this._isBoots = _isBoots;
        }

        public Boolean getIsBoots()
        {
            return _isBoots;
        }

        public void setIsGloves(Boolean _isGloves)
        {
            this._isGloves = _isGloves;
        }

        public Boolean getIsGloves()
        {
            return _isGloves;
        }

        public void setImageBrush(ImageBrush i)
        {
            _ImageBrush = i;
        }

        public ImageBrush getImageBrush()
        {
            return _ImageBrush;
        }
    }
}
