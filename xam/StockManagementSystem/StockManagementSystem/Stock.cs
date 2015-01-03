using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class Stock
    {

        private List<Item> stockList;

        public Stock()
        {
            stockList = new List<Item>();
        }
        public string Additem(Item aItem)
        {
            if (DuplicateProduct(aItem))
            {
                return "Duplicate product quantity increase";
            }
            else
            {
                stockList.Add(aItem);
                return "New Product Added";
            }

        }

        public bool DuplicateProduct(Item aItem)
        {
            foreach (Item Item1 in stockList)
            {
                if (Item1.ItemId == aItem.ItemId)
                {
                    Item1.Quantity += aItem.Quantity;
            
                    return true;
                }
            }
            return false;
        }



        public string OutItem(Item aItem)
        {
            if (HasInList(aItem)==false)
            {
                return "Item with Item Id is Not Exist in the system";
            }
            else
            {
               foreach (Item Item1 in stockList)
                {
                    if (aItem.ItemId==Item1.ItemId && aItem.Quantity > Item1.Quantity)
                    {
                        return "Sorry! There is " + Item1.Quantity +
                               " Items Available , but you are trying  to stock out " +
                               aItem.Quantity + " items.";
                    }
                    else if (aItem.ItemId==Item1.ItemId && aItem.Quantity<=Item1.Quantity)
                    {
                        Item1.Quantity -= aItem.Quantity;
                        return "Item Out";
                    }
                }
                return "Please enter an Item";

            }
        }

        public bool HasInList(Item aItem)
        {
            foreach (Item Item1 in stockList)
            {
                if (aItem.ItemId == Item1.ItemId)
                {
                    return true;
                }

            }
            return false;
        }
        public Item[] GetItems()
        {
            return stockList.ToArray();
        }
    }
}

