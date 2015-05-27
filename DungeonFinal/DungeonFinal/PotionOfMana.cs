﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class PotionOfMana : Item
    {
        ItemsEffect _effect;

        public PotionOfMana()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mana Potion");
            this.setConsumable(true);
            _effect.setEffectName("Restores mana by ");
            _effect.setManaValue(40);
            _effect.setEffectAmount(40);
            this.setEffect(_effect);
        }
    }
}
