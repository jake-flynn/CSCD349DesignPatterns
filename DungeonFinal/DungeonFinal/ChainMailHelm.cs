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
    class ChainMailHelm : Equipment
    {
        ItemsEffect _effect;

        public ChainMailHelm() : base()
        {
            _effect = new ItemsEffect();
            this.setItemName("Chain Mail Helmet");
            this.setIsHelmet(true);
            this.setSocketAmount(3);
            _effect.setEffectName("Chain mail helmet made of interlocking steel ringlets, increases strength by 5");
            _effect.setStrengthValue(4);
            _effect.setPhysicalDefense(2);
            _effect.setManaValue(10);
            _effect.setEffectAmount(9);
            this.setEffect(_effect);

            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Items/chainhelmet.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            setImageBrush(imgBrush);
        }
    }
}
