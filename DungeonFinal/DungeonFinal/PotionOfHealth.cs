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
    class PotionOfHealth : Consumable
    {
        ItemsEffect _effect;

        public PotionOfHealth() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Health Potion");
            _effect.setEffectName("Heals by ");
            _effect.setEffectAmount(40);
            _effect.setHealthValue(40);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Super_Health_Potion.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
