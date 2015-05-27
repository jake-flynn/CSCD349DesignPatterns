using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LeatherGloves : Item
    {
        ItemsEffect _effect;

        public LeatherGloves()
        {
            _effect = new ItemsEffect();
            this.setItemName("Leather Gloves");
            this.setEquippable(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Gloves made from leather straps woven together");
            _effect.setPhysicalDefense(2);
            this.setEffect(_effect);
        }
    }
}
