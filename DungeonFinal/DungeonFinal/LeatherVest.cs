using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LeatherVest : Item
    {
        ItemsEffect _effect;

        public LeatherVest()
        {
            _effect = new ItemsEffect();
            this.setItemName("Leather Vest");
            this.setEquippable(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A vest made of stiff leather");
            _effect.setPhysicalDefense(4);
            this.setEffect(_effect);
        }
    }
}
