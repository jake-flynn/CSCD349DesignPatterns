using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class BronzeChestPlate : Item
    {
        ItemsEffect _effect;

        public BronzeChestPlate()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Chest Plate");
            this.setEquippable(true);
            this.setSocketAmount(6);
            _effect.setEffectName("An exceptional piece of work crafted from copper and tin");
            _effect.setPhysicalDefense(5);
            //_effect.setManaValue(-2);     heavy armor effect?
            this.setEffect(_effect);
        }
    }
}
