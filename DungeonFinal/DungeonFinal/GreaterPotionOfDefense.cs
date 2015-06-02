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
    class GreaterPotionOfDefense : Consumable
    {
        ItemsEffect _effect;

        public GreaterPotionOfDefense() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Greater Defense Potion");
            _effect.setEffectName("Greatly increase defense by ");
            _effect.setEffectAmount(10);
            _effect.setPhysicalDefense(10);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/potionofdefense.png", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
