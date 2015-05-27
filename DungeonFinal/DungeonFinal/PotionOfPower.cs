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
            _effect.setEffectName("Enhances power by ");
            _effect.setStrengthValue(5);
            _effect.setEffectAmount(5);
            this.setEffect(_effect);
        }
    }
}
