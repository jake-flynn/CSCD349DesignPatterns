using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class Ultima : Item
    {
        ItemsEffect _effect;

        public Ultima()
        {
            _effect = new ItemsEffect();
            this.setItemName("Ultima");
            this.setEquippable(true);
            this.setSocketAmount(15);
            _effect.setEffectName("FEAR NO STUBEAST");
            _effect.setStrengthValue(100);
            _effect.setHealthValue(100);
            _effect.setManaValue(-5);
            this.setEffect(_effect);
        }
    }
}
