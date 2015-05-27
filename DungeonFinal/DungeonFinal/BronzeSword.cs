using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class BronzeSword : Item
    {
        ItemsEffect _effect;

        public BronzeSword()
        {
            _effect = new ItemsEffect();
            this.setItemName("Bronze Sword");
            this.setEquippable(true);
            this.setSocketAmount(4);
            _effect.setEffectName("A well balanced sword made of copper and tin");
            _effect.setStrengthValue(100);
            _effect.setHealthValue(100);
            _effect.setManaValue(-5);
            this.setEffect(_effect);
        }
    }
}
