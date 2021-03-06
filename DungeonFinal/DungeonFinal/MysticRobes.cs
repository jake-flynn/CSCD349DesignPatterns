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
    class MysticRobes : Equipment
    {
        ItemsEffect _effect;

        public MysticRobes() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Mystic Robes");
            this.setIsTorso(true);
            this.setSocketAmount(6);
            _effect.setEffectName("Mystic robes that increase magic power by 15 and mana by 30");
            _effect.setMagicValue(9);
            _effect.setResistanceDefense(6);
            _effect.setManaValue(30);
            _effect.setEffectAmount(10);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/Dread_Cloak.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
