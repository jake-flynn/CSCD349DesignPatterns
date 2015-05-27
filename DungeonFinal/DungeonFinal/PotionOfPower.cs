using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PotionOfPower : Item
    {
        ItemsEffect _effect;

        public PotionOfPower()
        {
            _effect = new ItemsEffect();
            this.setItemName("Potion of Power");
            this.setConsumable(true);
            _effect.setEffectName("Enhances the power of a single character temporarily");
            _effect.setStrengthValue(5);
            this.setEffect(_effect);
        }
    }
}
