using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class RuneOfHope: Item
    {
        ItemsEffect _effect;

        public RuneOfHope()
        {
            _effect = new ItemsEffect();
            this.setItemName("Rune Of Hope");
            this.setSocketable(true);
            _effect.setEffectName("Sheds light upon your dark journey");
            _effect.setStrengthValue(10);
            _effect.setMagicValue(10);
            _effect.setResistanceDefense(10);
            _effect.setPhysicalDefense(10);
            _effect.setHealthValue(10);
            _effect.setManaValue(10);
            this.setEffect(_effect);
        }
    }
}
