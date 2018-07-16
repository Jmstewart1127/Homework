using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Invoice> invoices = new List<Invoice>();
            for (int i = 1; i < 11; i++)
            {
                string partName = "part" + i;
                invoices.Add(new Invoice(i, partName, 2 + i, 1.5m + i));
            }

            var sortByPartDescription = from invoice in invoices
                                        orderby invoice.PartDescription
                                        select invoice;

            var sortByPrice = from invoice in invoices
                              orderby invoice.Price ascending
                              select invoice;

            var sortPartDescriptionAndPriceByQuantity = from invoice in invoices 
                                                        orderby invoice.Quantity ascending
                                                        select new { invoice.PartDescription, invoice.Price };
                   

            Console.WriteLine("***SORT BY DESCRIPTION***");
            foreach (var invoice in sortByPartDescription)
            {
                Console.WriteLine(invoice);
            }
            Console.WriteLine("***SORT BY PRICE***");
            foreach (var invoice in sortByPrice)
            {
                Console.WriteLine(invoice);
            }
            Console.WriteLine("***SORT BY QUANTITY***");
            foreach (var invoice in sortPartDescriptionAndPriceByQuantity)
            {
                Console.WriteLine(invoice);
            }
            Console.ReadLine();
        }
    }
}
