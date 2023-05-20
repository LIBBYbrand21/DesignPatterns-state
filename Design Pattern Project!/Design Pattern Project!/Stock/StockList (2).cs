using DesignPatternsProject.AbstractFactory.prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Stock
{
    public static class StockList1
    {

        /*public static List<ReadyItem> DrinkList { get; set; }
          public static List<ReadyItem> SnakList { get; set; }
          static List<NotReadyItem> CupDrinkList { get; set; }
          static List<NotReadyItem> PastrisList { get; set; }
        */  /*public StockList()
          {
              DrinkList = new List<ReadyItem>()
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
              SnakList = new List<ReadyItem>()
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
              PastrisList = new List<NotReadyItem>()
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
              CupDrinkList = new List<NotReadyItem>()
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
      };
          }*/
     
        public static List<ReadyItem> DrinkList= new List<ReadyItem>()
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
        public static List<ReadyItem> SnakList= new List<ReadyItem>()
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
        public static List<NotReadyItem> PastrisList = new List<NotReadyItem>()
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
      };

    }
}
/*   List<Item> items = new List<Item>();
        foreach(var drink in DrinkList)
            {
             items.Add(drink.Clone());
    }*/