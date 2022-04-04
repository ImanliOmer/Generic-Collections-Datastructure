using GenericCollectionsDatastructure.HelperExx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsDatastructure.Models
{
    abstract class Product:Exceptions
    {
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        protected double TotalInCome { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
