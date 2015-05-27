using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LesserPotionOfHealth: Item
    {
        ItemsEffect _effect;

        public LesserPotionOfHealth()
        {
            _effect = new ItemsEffect();
            this.setItemName("Lesser Health Potion");
            this.setConsumable(true);
            _effect.setEffectName("Slightly heals by ");
            _effect.setEffectAmount(20);
            _effect.setHealthValue(20);
            this.setEffect(_effect);
        }
    }
}
