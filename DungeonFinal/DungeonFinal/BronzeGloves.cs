using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class BronzeGloves : Item
    {
        ItemsEffect _effect;

        public BronzeGloves()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Gloves");
            this.setEquippable(true);
            this.setSocketAmount(1);
            _effect.setEffectName("Reasonably well crafted from copper and tin");
            _effect.setPhysicalDefense(1);
            //_effect.setManaValue(-2);     heavy armor effect?
            this.setEffect(_effect);
        }
    }
}
