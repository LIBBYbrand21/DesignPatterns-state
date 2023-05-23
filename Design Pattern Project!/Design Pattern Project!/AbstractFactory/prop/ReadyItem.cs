﻿using DesignPatternsProject.AbstractFactory.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.AbstractFactory.prop
{
    public class ReadyItem : Item, ItemPrototype
    {
        public ReadyItem()
        {
            Description = "ready item";
        }
        public ReadyItem(string name, int amount, double price)
        {
            Name = name;
          //  Amount = amount;
            Price = price;
            Description = "ready item";

        }
        
        public Item Clone()
        {
            return new ReadyItem
            {
                Name = Name,
                Price = Price,
                Description =Description

            };
        }
    }
}