﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Design_Pattern_Project_.BuilderItem
{
    public class IceCoffeeBuilder : DrinkBuilder
    {
        public override void AddExtras()
        {
            drink.Text += "\nadd milk jam";
            Task.Delay(500).Wait();
            drink.Text += "\nadd whipped cream";
            Task.Delay(500).Wait();
        }

        public override void AddLiquids()
        {
            drink.Text += "\nadd water";
            Task.Delay(500).Wait();
            drink.Text += "\nadd milk";
            Task.Delay(500).Wait();
        }

        public override void AddPowders()
        {
            drink.Text += "\nadd sugar";
            Task.Delay(500).Wait();
            drink.Text += "\nadd chocolate";
            Task.Delay(500).Wait();
            drink.Text += "\nadd coffee";
            Task.Delay(500).Wait();
        }
        public override void AddPicture()
        {
            Image image1 = Image.FromFile("C:\\Users\\The user\\Documents\\שנה ב\\DesignPatterns\\project\\E\\9\\images\\ice coffee.jpg");
            //drink.Size = new Size(image1.Width, image1.Height);
            drink.Image = image1;
        }
    }
}
