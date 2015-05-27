using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class ItemsEffect
    {
        string _effectName;
        int _effectAmount;
        int _healthValue;
        int _manaValue;
        int _strengthValue;
        int _magicValue;
        int _physicalDefense;
        int _resistanceDefense;

        public ItemsEffect()
        {
            _effectName = "No effect";
            _healthValue = 0;
            _manaValue = 0;
            _strengthValue = 0;
            _magicValue = 0;
            _physicalDefense = 0;
            _resistanceDefense = 0;
        }

        public void setEffectName(string _effectName)
        {
            this._effectName = _effectName;
        }

        public void setEffectAmount(int _effectAmount)
        {
            this._effectAmount = _effectAmount;
        }

        public void setHealthValue(int _healthValue)
        {
            this._healthValue = _healthValue;
        }

        public void setManaValue(int _manaValue)
        {
            this._manaValue = _manaValue;
        }

        public void setStrengthValue(int _strengthValue)
        {
            this._strengthValue = _strengthValue;
        }

        public void setMagicValue(int _magicValue)
        {
            this._magicValue = _magicValue;
        }

        public void setPhysicalDefense(int _physicalDefense)
        {
            this._physicalDefense = _physicalDefense;
        }

        public void setResistanceDefense(int _resistanceDefense)
        {
            this._resistanceDefense = _resistanceDefense;
        }

        public string getEffectName()
        {
            return _effectName;
        }

        public int getEffectAmount()
        {
            return _effectAmount;
        }

        public int getHealthValue()
        {
            return _healthValue;
        }

        public int getManaValue()
        {
            return _manaValue;
        }

        public int getStrengthValue()
        {
            return _strengthValue;
        }

        public int getMagicValue()
        {
            return _magicValue;
        }

        public int getPhysicalDefenseValue()
        {
            return _physicalDefense;
        }

        public int getResistanceDefenseValue()
        {
            return _resistanceDefense;
        }
    }
}
