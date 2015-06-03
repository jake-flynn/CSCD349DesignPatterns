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
        private ImageBrush _ImageBrush;
        Boolean _hasStatusEffect;
        StatusEffect _statusEffect;
        Hero _hero;

        public Consumable() : base()
        {
            _hasStatusEffect = false;
        }

        public string use(Hero hero)
        {
            _hero = hero;
            _hero.setCurHealth(_hero.getCurHealth() + getEffect().getHealthValue());
            _hero.setCurMana(_hero.getCurMana() + getEffect().getManaValue());
            _hero.setModStrength(_hero.getModStrength() + getEffect().getStrengthValue());
            _hero.setModMagic(_hero.getModMagic() + getEffect().getMagicValue());
            _hero.setModDefense(_hero.getModDefense() + getEffect().getPhysicalDefenseValue());
            _hero.setModResistance(_hero.getModResistance() + getEffect().getResistanceDefenseValue());

            if(_hasStatusEffect)
            {
                _statusEffect.setHero(_hero);
                _hero.Subscribe(_statusEffect);
            }

            else
            {
                return _hero.getName() + " used " + this.getItemName() + ", " + getEffect().getEffectName() + getEffect().getEffectAmount();
            }

            return "The status effect was applied.";
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

        public void setImageBrush(ImageBrush i)
        {
            _ImageBrush = i;
        }

        public ImageBrush getImageBrush()
        {
            return _ImageBrush;
        }

        public void setHasStatusEffect(Boolean _hasStatusEffect)
        {
            this._hasStatusEffect = _hasStatusEffect;
        }

        public Boolean getHasStatusEffect()
        {
            return _hasStatusEffect;
        }

        public void setStatusEffect(StatusEffect _statusEffect)
        {
            this._statusEffect = _statusEffect;
        }

        public StatusEffect getStatusEffect()
        {
            return _statusEffect;
        }

        public void setHero(Hero _hero)
        {
            this._hero = _hero;
        }

        public Hero getHero()
        {
            return _hero;
        }
    }
}
