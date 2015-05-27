using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class RuneOfDespair : Item
    {
        ItemsEffect _effect;

        public RuneOfDespair()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Despair");
            this.setSocketable(true);
            _effect.setEffectName("Sheds darkness upon your enemies");
            _effect.setStrengthValue(15);
            _effect.setMagicValue(15);
            _effect.setHealthValue(15);
            _effect.setManaValue(15);
            this.setEffect(_effect);
        }
    }
}
