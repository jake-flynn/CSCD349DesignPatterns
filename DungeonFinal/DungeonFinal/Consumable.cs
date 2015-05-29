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
    public abstract class Consumable : Item
    {
        public Consumable() : base()
        {

        }

        public string use(Hero _hero)
        {
            _hero.setCurHealth(_hero.getCurHealth() + getEffect().getHealthValue());
            _hero.setCurMana(_hero.getCurMana() + getEffect().getManaValue());
            _hero.setModStrength(_hero.getModStrength() + getEffect().getStrengthValue());
            _hero.setModMagic(_hero.getModMagic() + getEffect().getMagicValue());
            _hero.setModDefense(_hero.getModDefense() + getEffect().getPhysicalDefenseValue());
            _hero.setModResistance(_hero.getModResistance() + getEffect().getResistanceDefenseValue());
            return _hero.getName() + " used " + this.getItemName() + ", " + getEffect().getEffectName() + getEffect().getEffectAmount();
        }

        public string unUse(Hero _hero)
        {
            _hero.setCurHealth(_hero.getCurHealth() - getEffect().getHealthValue());
            _hero.setCurMana(_hero.getCurMana() - getEffect().getManaValue());
            _hero.setModStrength(_hero.getModStrength() - getEffect().getStrengthValue());
            _hero.setModMagic(_hero.getModMagic() - getEffect().getMagicValue());
            _hero.setModDefense(_hero.getModDefense() - getEffect().getPhysicalDefenseValue());
            _hero.setModResistance(_hero.getModResistance() - getEffect().getResistanceDefenseValue());
            return _hero.getName() + " had effect of " + this.getItemName() + ", " + getEffect().getEffectName() + getEffect().getEffectAmount();
        }

       // public abstract ImageBrush getBrush();
    }
}
