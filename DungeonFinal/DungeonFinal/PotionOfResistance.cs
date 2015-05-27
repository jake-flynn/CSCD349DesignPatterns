using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PotionOfResistance : Item
    {
        ItemsEffect _effect;
        
        public PotionOfResistance()
        {
            _effect = new ItemsEffect();
            this.setItemName("Potion of Magical Resistance");
            this.setConsumable(true);
            _effect.setEffectName("Enhances the resistance of ");
            _effect.setResistanceDefense(5);
            _effect.setEffectAmount(5);
            this.setEffect(_effect);
        }
        
    }
}
