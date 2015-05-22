using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PotionOfMana : Item
    {
        ItemsEffect _effect;

        public PotionOfMana()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mana Potion");
            this.setConsumable(true);
            _effect.setEffectName("Restores mana of a single character");
            _effect.setManaValue(20);
            this.setEffect(_effect);
        }
    }
}
