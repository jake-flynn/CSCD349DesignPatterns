using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class RuneOfDestruction : Item
    {
        ItemsEffect _effect;

        public RuneOfDestruction()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Destruction");
            this.setSocketable(true);
            _effect.setEffectName("The fallen angel set fire to the heavens, and this fell from the ashes...");
            _effect.setStrengthValue(100);
            _effect.setMagicValue(100);
            this.setEffect(_effect);
        }
    }
}
