using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    class nullItem : Item
    {
        ItemsEffect _effect;

        public nullItem()
        {
            _effect = new ItemsEffect();
            this.setItemName("Null Item");
            _effect.setEffectName("No effect");
            this.setEffect(_effect);
        }
    }
}
