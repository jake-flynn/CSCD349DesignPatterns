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
    class ChainMailBoots : Equipment
    {
        ItemsEffect _effect;

        public ChainMailBoots() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Chain Mail Boots");
            this.setIsBoots(true);
            this.setSocketAmount(2);
            _effect.setEffectName("Chain Mail boots made of steel ringlets that increase strength by 6");
            _effect.setStrengthValue(2);
            _effect.setPhysicalDefense(2);
            _effect.setManaValue(4);
            _effect.setEffectAmount(8);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Chain_Boots.gif", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
