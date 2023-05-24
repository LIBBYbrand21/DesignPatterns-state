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
            {new NotReadyItem(){ Name = "סמבוסק", Price = 10.5 }, 20},
            {new NotReadyItem(){ Name = "קרואוסון", Price = 10.5 }, 20},
            {new NotReadyItem(){ Name = "מלווח", Price = 8.5 }, 20},
            {new NotReadyItem(){ Name = "בורקס תפו'א", Price = 4.5 }, 10},
            {new NotReadyItem(){ Name = "בורקס גבינה", Price = 5.0 }, 20},
            {new NotReadyItem(){ Name = "רוגלה", Price = 4.0 }, 20},
            {new NotReadyItem(){ Name = "פיציה", Price = 8.5 }, 15},
            {new NotReadyItem(){ Name = "סופלה", Price = 5.5 }, 10},
            {new NotReadyItem(){ Name = "בגט גבינה", Price = 15.5 }, 20},
            {new NotReadyItem(){ Name = "בייגל בצל", Price = 5.0 }, 20},
        };
        public static Dictionary<Item, int> inventoryDrink = new()
        {
             { new ReadyItem() { Name = "קוקה קולה ", Price = 9.9 } , 20},
            { new ReadyItem() { Name = "קוקה קולה דיאט", Price = 9.9 }, 20},
            { new ReadyItem() { Name = "ספרייט", Price = 9.5, }, 20},
            { new ReadyItem() { Name = "ג'אמפ תות בננה", Price = 10.0 }, 10},
            { new ReadyItem() { Name = "ג'אמפ מנגו", Price = 12.5 }, 20},
            { new ReadyItem() { Name = "מירינדה", Price = 10.5 }, 20},
            { new ReadyItem() { Name = "פפסי", Price = 8.5 }, 15},
            { new ReadyItem() { Name = "בירה", Price = 12 }, 10},
            { new ReadyItem() { Name = "מים בטעמים-ענבים", Price = 7.5 }, 20},
            { new ReadyItem() { Name = "מים בטעמים-תפוח", Price = 7.5 }, 20},
            { new ReadyItem() { Name = "מים מינרלים", Price = 5.5 }, 20},
            { new ReadyItem() { Name = "סודה", Price = 7.5 }, 20},
        };
        public static Dictionary<Item, int> inventoryCupDrink = new()
        {
           {new NotReadyItem(){ Name = "צ'וקולטה", Price = 7.5,DrinkBuilder=new ChocolateBuilder() } , 2},
            {new NotReadyItem(){ Name = "קפה שחור", Price = 10.5 ,DrinkBuilder=new BlackCoffeeBuilder()}, 20},
            {new NotReadyItem() { Name = "קפה נמס", Price = 10.5,DrinkBuilder=new InstantCoffeeBuilder() }, 20},
            { new NotReadyItem()  { Name = "קפה הפוך", Price = 7.5 ,DrinkBuilder=new CappuccinoBuilder()}, 10},
            { new NotReadyItem() { Name = "אייס קפה", Price = 8.5 , DrinkBuilder = new IceCoffeeBuilder()}, 20},
            { new NotReadyItem() { Name = "אייס אגוזים", Price = 8.5 , DrinkBuilder = new IceNutsBuilder()}, 20},
            //{ new NotReadyItem() { Name = "אייס פסיפלורה", Price = 5.5 , DrinkBuilder = new ChocolateBuilder()}, 15},
            { new NotReadyItem() { Name = "אייס וניל", Price = 7.5 , DrinkBuilder = new IceVanilBuilder()} , 10},
            //{ new NotReadyItem(){ Name = "ברד ענבים", Price = 5.5 , DrinkBuilder = new ChocolateBuilder()}, 20},
           // { new NotReadyItem() { Name = "ברד פטל", Price = 5.5 , DrinkBuilder = new ChocolateBuilder()}, 20},
            //{ new NotReadyItem() { Name = "שייק פירות", Price = 7.5 , DrinkBuilder = new ChocolateBuilder()}, 20},
            { new NotReadyItem() { Name = "אקספרסו", Price = 8.5 , DrinkBuilder = new ExpresoBuilder()}, 20},
           };
        public static Dictionary<Item, int> inventorySnack = new() {
            { new ReadyItem() { Name = "תפוצ'יפס טבעי", Price = 7.5 } , 20},
            { new ReadyItem() { Name = "תפוצ'יפס שמנת בצל", Price = 9.5 }, 20},
            { new ReadyItem() { Name = "דוריטוס טבעי", Price = 8.5 }, 20},
            { new ReadyItem() { Name = "דוריטוס חמוץ חריף", Price = 5.5 }, 10},
            { new ReadyItem() { Name = "דוריטוס חריף אש", Price = 5.5 }, 20},
            { new ReadyItem() { Name = "צ'יטוס קטשופ", Price = 7.0 }, 20},
            { new ReadyItem() { Name = "צ'יטוס פיצה", Price = 6.0 }, 15},
            { new ReadyItem() { Name = "פריכיות אורז בשוקולד", Price = 6.5 }, 10},
            { new ReadyItem() { Name = "נשנושים", Price = 8.5 }, 20},
            { new ReadyItem() { Name = "שוגי", Price = 2.5 }, 20},
            { new ReadyItem() { Name = "פסק זמן", Price = 3.5 }, 20},
            { new ReadyItem() { Name = "שוקולד חלבי עילית", Price = 5.5 }, 20},
        };



        /*public Menu()
        {
            inventoryPastris = new Dictionary<Item, int>();
            inventoryDrink = new Dictionary<Item, int>();
            inventoryCupDrink = new Dictionary<Item, int>();
            inventorySnack = new Dictionary<Item, int>();
            InitializeInventory();
        }

        private void InitializeInventory()
        {
            inventoryPastris.Add(new NotReadyItem() { Name = "סמבוסק", Price = 10.5 }, 20);
            inventoryPastris.Add(new NotReadyItem() { Name = "קרואוסון", Price = 10.5 }, 20);
            inventoryPastris.Add(new NotReadyItem() { Name = "מלווח", Price = 8.5 }, 20);
            inventoryPastris.Add(new NotReadyItem() { Name = "בייגל בצל", Price = 5.0 }, 20);
            inventoryPastris.Add(new NotReadyItem() { Name = "בגט גבינה", Price = 15.5 }, 20);
            inventoryPastris.Add(new NotReadyItem() { Name = "סופלה", Price = 5.5 }, 10);
            inventoryPastris.Add(new NotReadyItem() { Name = "פיציה", Price = 8.5 }, 15);
            inventoryPastris.Add(new NotReadyItem() { Name = "רוגלה", Price = 4.0 }, 20);
            inventoryPastris.Add(new NotReadyItem() { Name = "בורקס גבינה", Price = 5.0 }, 20);
            inventoryPastris.Add(new NotReadyItem() { Name = "בורקס תפו'א", Price = 4.5 }, 10);


            inventoryDrink.Add(new ReadyItem() { Name = "סודה", Price = 7.5 }, 10);
            inventoryDrink.Add(new ReadyItem() { Name = "מים מינרלים", Price = 5.5 }, 50);
            inventoryDrink.Add(new ReadyItem() { Name = "מים בטעמים-תפוח", Price = 7.5 }, 1);
            inventoryDrink.Add(new ReadyItem() { Name = "מים בטעמים-ענבים", Price = 7.5 }, 2);
            inventoryDrink.Add(new ReadyItem() { Name = "בירה", Price = 12 }, 10);
            inventoryDrink.Add(new ReadyItem() { Name = "פפסי", Price = 8.5 }, 15);
            inventoryDrink.Add(new ReadyItem() { Name = "מירינדה", Price = 10.5 }, 2);
            inventoryDrink.Add(new ReadyItem() { Name = "ג'אמפ מנגו", Price = 12.5 }, 12);
            inventoryDrink.Add(new ReadyItem() { Name = "ג'אמפ תות בננה", Price = 10.0 }, 15);
            inventoryDrink.Add(new ReadyItem() { Name = "ספרייט", Price = 9.5, }, 20);
            inventoryDrink.Add(new ReadyItem() { Name = "קוקה קולה דיאט", Price = 9.9 }, 10);
            inventoryDrink.Add(new ReadyItem() { Name = "קוקה קולה ", Price = 9.9 }, 20);


            inventoryCupDrink.Add(new NotReadyItem() { Name = "אקספרסו", Price = 8.5 }, 5);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "שייק פירות", Price = 7.5 }, 5);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "ברד פטל", Price = 5.5 }, 10);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "ברד ענבים", Price = 5.5 }, 10);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "אייס וניל", Price = 7.5 }, 10);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "אייס פסיפלורה", Price = 5.5 }, 15);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "אייס אגוזים", Price = 8.5 }, 15);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "אייס קפה", Price = 8.5 }, 20);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "קפה הפוך", Price = 7.5 }, 10);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "קפה נמס", Price = 10.5 }, 20);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "קפה שחור", Price = 10.5 }, 15);
            inventoryCupDrink.Add(new NotReadyItem() { Name = "צ'וקולטה", Price = 7.5 }, 10);


            inventorySnack.Add(new ReadyItem() { Name = "שוקולד חלבי עילית", Price = 5.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "פסק זמן", Price = 3.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "שוגי", Price = 2.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "נשנושים", Price = 8.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "פריכיות אורז בשוקולד", Price = 6.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "צ'יטוס פיצה", Price = 6.0 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "צ'יטוס קטשופ", Price = 7.0 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "דוריטוס חריף אש", Price = 5.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "דוריטוס חמוץ חריף", Price = 5.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "דוריטוס טבעי", Price = 8.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "תפוצ'יפס שמנת בצל", Price = 9.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "תפוצ'יפס טבעי", Price = 7.5 }, 10);


        }*/

        /*

        /*public static List<Item> GenerateItems()
        {*/
        /*    List<Item> items = new List<Item>();
          // items = new Dictionary<Item, int>();
            // public Dictionary<Item, int> items { get; set; }

            // Clone the DrinkList
             foreach (var drink in inventoryDrink)
            {
                items.Add(drink.Clone());
            }

            // Clone the snackList
            foreach (var snack in inventorySnack)
            {
                items.Add(snack.Clone());
            }

            // Clone the PastriesList
            foreach (var pastry in inventoryPastris)
            {
                items.Add(pastry.Clone());
            }

            // Clone the CupDrinkList
            foreach (var cupDrink in inventoryCupDrink)
            {
                items.Add(cupDrink.Clone());
            }

            return items;
        }*/

        // Define the DrinkList, snackList, PastriesList, and CupDrinkList here
        /* }*/

    }
}
/*Dictionary<string, NotReadyItem> dictionary = new Dictionary<string, NotReadyItem>();

NotReadyItem item1 = new NotReadyItem("Item 1", 10, 9.9);
NotReadyItem item2 = new NotReadyItem("Item 2", 10, 9.5);

dictionary.Add(item1.Name, item1);
dictionary.Add(item2.Name, item2);*/

