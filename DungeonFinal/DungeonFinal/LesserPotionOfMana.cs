using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LesserPotionOfMana : Item
    {
        ItemsEffect _effect;

        public LesserPotionOfMana()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Mana Potion");
            this.setConsumable(true);
            _effect.setEffectName("Slightly restores mana by ");
            _effect.setEffectAmount(20);
            _effect.setHealthValue(20);
            this.setEffect(_effect);
        }
    }
}
