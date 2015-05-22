using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class HealthPotion : Item
    {
        Effect _effect;

        public HealthPotion()
        {
            _effect = new Effect();
            this.setName("Health Potion");
            this.setConsumable(true);
            _effect.setEffectName("Heal a single character");
            _effect.setHealthValue(20);
            this.setEffect(_effect);
        }

        public void use()
        {

        }
    }
}
