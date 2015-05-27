using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PotionOfHealth : Item
    {
        ItemsEffect _effect;

        public PotionOfHealth()
        {
            _effect = new ItemsEffect();
            this.setItemName("Health Potion");
            this.setConsumable(true);
            _effect.setEffectName("Heals a single character by");
            _effect.setEffectAmount(20);
            _effect.setHealthValue(20);
            this.setEffect(_effect);
        }
    }
}
