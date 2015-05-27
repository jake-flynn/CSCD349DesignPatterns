using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class LeatherHelmet : Item
    {
        ItemsEffect _effect;

        public LeatherHelmet()
        {
            _effect = new ItemsEffect();
            this.setItemName("Leather Helmet");
            this.setEquippable(true);
            this.setSocketAmount(1);
            _effect.setEffectName("A sturdy leather cap");
            _effect.setPhysicalDefense(3);
            this.setEffect(_effect);
        }
    }
}
