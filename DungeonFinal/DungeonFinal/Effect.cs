using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class Effect
    {
        string _effectName;
        int _healthValue;
        int _manaValue;
        int _strengthValue;
        int _magicValue;
        int _magicDefenceValue;
        int _physicalDefenceValue;
        int _ResistanceValue;

        public Effect()
        {
            _effectName = "no effect";
            _healthValue = 0;
            _manaValue = 0;
            _strengthValue = 0;
            _magicValue = 0;
            _magicDefenceValue = 0;
            _physicalDefenceValue = 0;
            _ResistanceValue = 0;
        }

        public void setEffectName(string _effectName)
        {
            this._effectName = _effectName;
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

        public void setMagicDefenceValue(int _magicDefenceValue)
        {
            this._magicDefenceValue = _magicDefenceValue;
        }

        public void setPhysicalDefenceValue(int _physicalDefenceValue)
        {
            this._physicalDefenceValue = _physicalDefenceValue;
        }

        public void setResistanceValue(int _ResistanceValue)
        {
            this._ResistanceValue = _ResistanceValue;
        }

        public string getEffectName()
        {
            return(_effectName);
        }

        public int getHealthValue()
        {
            return(_healthValue);
        }

        public int getManaValue()
        {
            return(_manaValue);
        }

        public int getStrengthValue()
        {
            return(_strengthValue);
        }

        public int getMagicValue()
        {
            return(_magicValue);
        }

        public int getMagicDefenceValue()
        {
            return(_magicDefenceValue);
        }

        public int getPhysicalDefenceValue()
        {
            return(_physicalDefenceValue);
        }

        public int getResistanceValue()
        {
            return (_ResistanceValue);
        }
    }
}
