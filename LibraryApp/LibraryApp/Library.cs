using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using LibraryApp.models;
using LibraryApp.exceptions;


namespace LibraryApp
{
    internal class Library<T> where T :LibraryItem<T>
    {
        List<T> items= new List<T>();

        public void Add(T item) 
        {
            items.Add(item);
        }
        public void Listitems() 
        {
            Console.WriteLine("Knihovní předměty");
            foreach (T item in items) 
            {
                item.DisplayInfo();
            }
        }

        public void CheckoutItem(int id)
        {
            T itemToCheckout = items.Find(item => item.Id == id);
            if (itemToCheckout != null)
            {
                if (itemToCheckout.IsAvaiable)
                {
                    itemToCheckout.IsAvaiable = false;
                    Console.WriteLine($"Vypujčil jsem si knížku: {itemToCheckout.Title}");
                } else
                {
                    throw new NotAvaiableException($"Položka s ID ${itemToCheckout.Id} nebyla nalezena");
                }
            }
            else
            {
                throw new NotFoundException($"Položka s ID ${itemToCheckout.Id} neexistuje");   
            }
        }
        public void ReturnItem( int id)
        {
            T itemToCheckout = items.Find(item => item.Id == id);
            if (itemToCheckout != null)
            {
                if (itemToCheckout.IsAvaiable)
                {
                    itemToCheckout.IsAvaiable = true;
                    Console.WriteLine($"Vrátil jsem knížku: {itemToCheckout.Title}");
                }
                else
                {
                    throw new NotAvaiableException($"Položka s ID ${itemToCheckout.Id} nebyla nalezena");
                }
            }
            else
            {
                throw new NotFoundException($"Položka s ID ${itemToCheckout.Id} neexistuje");
            }
        }
    }
}
