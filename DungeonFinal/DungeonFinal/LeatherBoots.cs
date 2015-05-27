using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LeatherBoots : Item
    {
        ItemsEffect _effect;

        public LeatherBoots()
        {
            _effect = new ItemsEffect();
            this.setItemName("Leather Boots");
            this.setEquippable(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Boots made from tough leather");
            _effect.setPhysicalDefense(2);
            this.setEffect(_effect);
        }
    }
}
