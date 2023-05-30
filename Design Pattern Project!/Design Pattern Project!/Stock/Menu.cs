using Design_Pattern_Project_.BuilderItem;
using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatternsProject.Stock
{
    public class Menu
    {
        public static Dictionary<Item, int> inventoryPastris = new()
        {
            { new NotReadyItem() { Name = "סמבוסק", Price = 10.5 }, 20 },
            { new NotReadyItem() { Name = "קרואוסון", Price = 10.5 }, 20 },
            { new NotReadyItem() { Name = "מלווח", Price = 8.5 }, 20 },
            { new NotReadyItem() { Name = "בורקס תפו'א", Price = 4.5 }, 10 },
            { new NotReadyItem() { Name = "בורקס גבינה", Price = 5.0 }, 20 },
            { new NotReadyItem() { Name = "רוגלה", Price = 4.0 }, 20 },
            { new NotReadyItem() { Name = "פיציה", Price = 8.5 }, 15 },
            { new NotReadyItem() { Name = "סופלה", Price = 5.5 }, 10 },
            { new NotReadyItem() { Name = "בגט גבינה", Price = 15.5 }, 20 },
            { new NotReadyItem() { Name = "בייגל בצל", Price = 5.0 }, 20 },
        };
        public static Dictionary<Item, int> inventoryDrink = new()
        {
            { new ReadyItem() { Name = "קוקה קולה ", Price = 9.9 }, 20 },
            { new ReadyItem() { Name = "קוקה קולה דיאט", Price = 9.9 }, 20 },
            { new ReadyItem() { Name = "ספרייט", Price = 9.5, }, 20 },
            { new ReadyItem() { Name = "ג'אמפ תות בננה", Price = 10.0 }, 10 },
            { new ReadyItem() { Name = "ג'אמפ מנגו", Price = 12.5 }, 20 },
            { new ReadyItem() { Name = "מירינדה", Price = 10.5 }, 20 },
            { new ReadyItem() { Name = "פפסי", Price = 8.5 }, 15 },
            { new ReadyItem() { Name = "בירה", Price = 12 }, 10 },
            { new ReadyItem() { Name = "מים בטעמים-ענבים", Price = 7.5 }, 20 },
            { new ReadyItem() { Name = "מים בטעמים-תפוח", Price = 7.5 }, 20 },
            { new ReadyItem() { Name = "מים מינרלים", Price = 5.5 }, 20 },
            { new ReadyItem() { Name = "סודה", Price = 7.5 }, 20 },
        };
        public static Dictionary<Item, int> inventoryCupDrink = new()
        {
            { new NotReadyItem() { Name = "צ'וקולטה", Price = 7.5, DrinkBuilder = new ChocolateBuilder() }, 2 },
            { new NotReadyItem() { Name = "קפה שחור", Price = 10.5, DrinkBuilder = new BlackCoffeeBuilder() }, 20 },
            { new NotReadyItem() { Name = "קפה נמס", Price = 10.5, DrinkBuilder = new InstantCoffeeBuilder() }, 20 },
            { new NotReadyItem() { Name = "קפה הפוך", Price = 7.5, DrinkBuilder = new CappuccinoBuilder() }, 10 },
            { new NotReadyItem() { Name = "אייס קפה", Price = 8.5, DrinkBuilder = new IceCoffeeBuilder() }, 20 },
            { new NotReadyItem() { Name = "אייס אגוזים", Price = 8.5, DrinkBuilder = new IceNutsBuilder() }, 20 },
            { new NotReadyItem() { Name = "אייס וניל", Price = 7.5, DrinkBuilder = new IceVanilBuilder() }, 10 },
            { new NotReadyItem() { Name = "אקספרסו", Price = 8.5, DrinkBuilder = new ExpresoBuilder() }, 20 },
        };
        public static Dictionary<Item, int> inventorySnack = new()
        {
            { new ReadyItem() { Name = "תפוצ'יפס טבעי", Price = 7.5 }, 20 },
            { new ReadyItem() { Name = "תפוצ'יפס שמנת בצל", Price = 9.5 }, 20 },
            { new ReadyItem() { Name = "דוריטוס טבעי", Price = 8.5 }, 20 },
            { new ReadyItem() { Name = "דוריטוס חמוץ חריף", Price = 5.5 }, 10 },
            { new ReadyItem() { Name = "דוריטוס חריף אש", Price = 5.5 }, 20 },
            { new ReadyItem() { Name = "צ'יטוס קטשופ", Price = 7.0 }, 20 },
            { new ReadyItem() { Name = "צ'יטוס פיצה", Price = 6.0 }, 15 },
            { new ReadyItem() { Name = "פריכיות אורז בשוקולד", Price = 6.5 }, 10 },
            { new ReadyItem() { Name = "נשנושים", Price = 8.5 }, 20 },
            { new ReadyItem() { Name = "שוגי", Price = 2.5 }, 20 },
            { new ReadyItem() { Name = "פסק זמן", Price = 3.5 }, 20 },
            { new ReadyItem() { Name = "שוקולד חלבי עילית", Price = 5.5 }, 20 },
        };
    }
}