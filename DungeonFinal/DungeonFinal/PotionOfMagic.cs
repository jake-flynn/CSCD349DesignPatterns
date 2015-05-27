using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PotionOfMagic : Item
    {
        ItemsEffect _effect;

        public PotionOfMagic()
        {
            _effect = new ItemsEffect();
            this.setItemName("Magic Potion");
            this.setConsumable(true);
            _effect.setEffectName("Enhances the magic power of ");
            _effect.setMagicValue(5);
            _effect.setEffectAmount(5);
            this.setEffect(_effect);
        }
    }
}
