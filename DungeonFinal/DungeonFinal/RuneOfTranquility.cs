using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class RuneOfTranquility: Item
    {
        ItemsEffect _effect;

        public RuneOfTranquility()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Tranquility");
            this.setSocketable(true);
            _effect.setEffectName("In the midst of creation and destruction, stood tranquility...");
            _effect.setResistanceDefense(100);
            _effect.setPhysicalDefense(100);
            this.setEffect(_effect);
        }
    }
}
