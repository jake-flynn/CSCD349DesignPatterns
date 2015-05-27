using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class BronzeBoots : Item
    {
        ItemsEffect _effect;

        public BronzeBoots()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Boots");
            this.setEquippable(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Durable boots made of copper and tin");
            _effect.setPhysicalDefense(2);
            //_effect.setManaValue(-2);     heavy armor effect?
            this.setEffect(_effect);
        }
    }
}
