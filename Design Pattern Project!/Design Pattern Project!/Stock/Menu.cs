using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Stock
{
    public class Menu
    {
        public Dictionary<Item, int> inventoryPastris { get; set; }
        public Dictionary<Item, int> inventoryDrink { get; set; }
        public Dictionary<Item, int> inventoryCupDrink { get; set; }
        public Dictionary<Item, int> inventorySnack { get; set; }



        public Menu()
        {
            inventoryPastris = new Dictionary<Item, int>();
            inventoryDrink = new Dictionary<Item, int>();
            inventoryCupDrink = new Dictionary<Item, int>();
            inventorySnack = new Dictionary<Item, int>();
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
            inventorySnack.Add(new ReadyItem() { Name = "שוגי", Price = 2.5}, 10);
            inventorySnack.Add(new ReadyItem() { Name = "נשנושים", Price = 8.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "פריכיות אורז בשוקולד", Price = 6.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "צ'יטוס פיצה", Price = 6.0}, 10);
            inventorySnack.Add(new ReadyItem() { Name = "צ'יטוס קטשופ", Price = 7.0}, 10);
            inventorySnack.Add(new ReadyItem() { Name = "דוריטוס חריף אש", Price = 5.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "דוריטוס חמוץ חריף", Price = 5.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "דוריטוס טבעי", Price = 8.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "תפוצ'יפס שמנת בצל", Price = 9.5 }, 10);
            inventorySnack.Add(new ReadyItem() { Name = "תפוצ'יפס טבעי", Price = 7.5 }, 10);


        }

        /*public static List<NotReadyItem> PastrisList = new List<NotReadyItem>()
          {
              new NotReadyItem("בורקס תפו'א",10,9.9),
              new NotReadyItem("בורקס גבינה",10,9.9),
              new NotReadyItem("פיציה",10,9.5),
              new NotReadyItem("רוגלה",10,9.5),
              new NotReadyItem("סופלה",10,8),
              new NotReadyItem("בגט גבינה",10,7),
              new NotReadyItem("בייגל בצל",10,7),
              new NotReadyItem("מלווח",10,2),
              new NotReadyItem("קרואוסון",10,2),
              new NotReadyItem("סמבוסק",10,15),
      };
        public static List<ReadyItem> DrinkList = new List<ReadyItem>()
          {
              new ReadyItem("קוקה קולה",10,9.9),
              new ReadyItem("קוקה קולה דיאט",10,9.9),
              new ReadyItem("ספרייט",10,9.5),
              new ReadyItem("ג'אמפ תות בננה",10,9),
              new ReadyItem("ג'אמפ מנגו",10,9),
              new ReadyItem("מירינדה",10,8.9),
              new ReadyItem("פפסי",10,8.9),
              new ReadyItem("בירה",10,12),
              new ReadyItem("מים בטעמים-ענבים",10,7.9),
              new ReadyItem("מים בטעמים-תפוח",10,7.9),
              new ReadyItem("מים מינרלים",10,5.5),
              new ReadyItem("סודה",10,7.0),

      };
        public static List<ReadyItem> snackList = new List<ReadyItem>()
          {
              new ReadyItem("תפוצ'יפס טבעי",10,5),
              new ReadyItem("תפוצ'יפס שמנת בצל",10,5),
              new ReadyItem("דוריטוס טבעי",10,4.5),
              new ReadyItem("דוריטוס חמוץ חריף",10,4.5),
              new ReadyItem("דוריטוס חריף אש",10,4.5),
              new ReadyItem("צ'יטוס קטשופ",10,4),
              new ReadyItem("צ'יטוס פיצה",10,4),
              new ReadyItem("פריכיות אורז בשוקולד",10,12),
              new ReadyItem("נשנושים",10,10.9),
              new ReadyItem("שוגי",10,4.9),
              new ReadyItem("פסק זמן",10,5.5),
              new ReadyItem("שוקולד חלבי עילית",10,7.5),
      };
        public static List<NotReadyItem> CupDrinkList = new List<NotReadyItem>()
          {
              new NotReadyItem("צ'וקולטה",10,9.9),
              new NotReadyItem("קפה שחור",10,9.9),
              new NotReadyItem("קפה נמס",10,9.5),
              new NotReadyItem("קפה הפוך",10,9.5),
              new NotReadyItem("אייס קפה",10,8),
              new NotReadyItem("אייס אגוזים",10,7),
              new NotReadyItem("אייס פסיפלורה",10,7),
              new NotReadyItem("אייס וניל",10,7),
              new NotReadyItem("ברד ענבים",10,2),
              new NotReadyItem("ברד פטל",10,2),
              new NotReadyItem("שייק פירות",10,15),
              new NotReadyItem("אקספרסו",10,7),
      };*/

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

