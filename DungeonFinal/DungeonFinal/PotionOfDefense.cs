using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PotionOfDefense : Item
    {
        ItemsEffect _effect;

        public PotionOfDefense()
        {
            _effect = new ItemsEffect();
            this.setItemName("Defense Potion");
            this.setConsumable(true);
            _effect.setEffectName("Enhances defense of ");
            _effect.setPhysicalDefense(5);
            _effect.setEffectAmount(5);
            this.setEffect(_effect);
        }
    }
}
