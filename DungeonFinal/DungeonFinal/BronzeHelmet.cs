using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class BronzeHelmet : Item
    {
        ItemsEffect _effect;

        public BronzeHelmet()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Helmet");
            this.setEquippable(true);
            this.setSocketAmount(3);
            _effect.setEffectName("A well crafted helmet made of an alloy of copper and tin");
            _effect.setPhysicalDefense(3);
            //_effect.setManaValue(-1);         Decrease mana pool for wearing heavy armor?
            this.setEffect(_effect);
        }
    }
}
