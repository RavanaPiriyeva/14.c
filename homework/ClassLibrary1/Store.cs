using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Store
    {

        private Product[] _products=new Product[0];
    public  Product[]  Products { get { return _products; } }

  public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length-1] = product;

        }
        public void ReturnList()
        {
            foreach(var item in _products)
            {
                Console.WriteLine(item);
            }
        }
        public Product[] RemoveProductByNo(int no)
        {
            Product[] products = new Product[0];
            foreach (var item in _products)
            {
                if (item.No != no)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = item;
                }

            }
            ///!!!!!Ikinci yol!!!!!///
            //for (int i=0; i<_products.Length ; i++)
            //{
            //    if(_products[i].No == no)
            //    {
            //        Array.Clear(_products, i, 1);
            //    }
            // }
            return products;
            }
            
        public Product[] FilterProductsByType(string type)
        {
            Product[] productss = new Product[0];
            foreach (var item in _products)
            {
                if (item.Type == type)
                {
                    Array.Resize(ref productss, productss.Length + 1);
                    productss[productss.Length - 1] = item;
                }
            }
            return productss;
        }


        public Product[] FilterProductByName(string name)
        {
            Product[] products = new Product[0];
            foreach (var item in _products)
            {
                if (item.Name == name)
                {
                    Array.Resize(ref products, products.Length + 1);
                    products[products.Length - 1] = item;
                }
            }
            return products;
        }
        
    }
}
