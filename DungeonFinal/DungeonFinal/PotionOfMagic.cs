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
            _effect.setEffectName("Enhances the magic power of a single character temporarily");
            _effect.setMagicValue(5);
            this.setEffect(_effect);
        }
    }
}
