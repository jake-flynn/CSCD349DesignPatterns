using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class GreaterPotionOfHealth : Item
    {
        ItemsEffect _effect;

        public GreaterPotionOfHealth()
        {
            _effect = new ItemsEffect();
            this.setItemName("Greater Health Potion");
            this.setConsumable(true);
            _effect.setEffectName("Greatly heals by ");
            _effect.setEffectAmount(60);
            _effect.setHealthValue(60);
            this.setEffect(_effect);
        }
    }
}
