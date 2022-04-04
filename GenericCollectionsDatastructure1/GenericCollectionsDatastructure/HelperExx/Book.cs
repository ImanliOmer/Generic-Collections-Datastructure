using GenericCollectionsDatastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsDatastructure.HelperExx
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public string PageCount { get; set; }
        public Book(string authorname,string pagecount,string name,double price)
        {
            Name = name;
            Price = price;
            AuthorName = authorname;
            PageCount = pagecount;
        }




        public override void Sell()
        {
            ProductCountIsZeroException(Count);
            Count--;
            TotalInCome++;

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"ID{Id}\n" +
                $"Name: {Name}\n" +
                $"Price: {Price}\n" +
                $"Count: {Count}\n" +
                $"TotalInCome: {TotalInCome}\n" +
                $"AuthorName: {AuthorName}\n" +
                $"PageCount: {PageCount}");
        }
    }
}
