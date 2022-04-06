using System;

namespace ClassLibrary1
{
    public class Product
    {
        public Product()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"No:{No}   Name:{Name}    Price:{Price}     Type:{Type}";
        }

    }
}
