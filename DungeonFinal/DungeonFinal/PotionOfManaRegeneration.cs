﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DungeonFinal
{
    class PotionOfManaRegeneration : Consumable
    {
        ItemsEffect _effect;

        public PotionOfManaRegeneration() : base()
        {
            _effect = new ItemsEffect();
            setItemName("Mana Regeneration Potion");
            _effect.setEffectName("Restores mana by 15 for four turns.");
            setEffect(_effect);
            setHasStatusEffect(true);
            setStatusEffect(new ManaRegeneration());

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/full_mana_potion.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}