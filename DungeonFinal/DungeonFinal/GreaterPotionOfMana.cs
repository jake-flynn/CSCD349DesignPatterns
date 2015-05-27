using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class GreaterPotionOfMana : Item
    {
        ItemsEffect _effect;

        public GreaterPotionOfMana()
        {
            _effect = new ItemsEffect();
            this.setItemName("Greater Mana Potion");
            this.setConsumable(true);
            _effect.setEffectName("Greatly restores mana by ");
            _effect.setEffectAmount(60);
            _effect.setHealthValue(60);
            this.setEffect(_effect);
        }
    }
}
