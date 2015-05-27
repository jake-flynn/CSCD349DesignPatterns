﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PotionOfHealth : Item
    {
        ItemsEffect _effect;

        public PotionOfHealth()
        {
            _effect = new ItemsEffect();
            this.setItemName("Health Potion");
            this.setConsumable(true);
            _effect.setEffectName("Heals by ");
            _effect.setEffectAmount(40);
            _effect.setHealthValue(40);
            this.setEffect(_effect);
        }
    }
}
