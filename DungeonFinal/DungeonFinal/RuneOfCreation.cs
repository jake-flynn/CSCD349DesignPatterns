using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class RuneOfCreation : Item
    {
        ItemsEffect _effect;

        public RuneOfCreation()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Creation");
            this.setSocketable(true);
            _effect.setEffectName("God created the heavens, the earth, and this...");
            _effect.setHealthValue(100);
            _effect.setManaValue(100);
            this.setEffect(_effect);
        }
    }
}
