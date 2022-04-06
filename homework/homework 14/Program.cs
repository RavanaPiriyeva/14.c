using System;
using ClassLibrary1;
namespace homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine("Nece product elav etmek isteyirsiz?");
            int count = 0;
            bool loop2 = true;
            while(loop2) {
            try
            {
                count = Convert.ToInt32(Console.ReadLine());
                    loop2 = false;
            }
            catch {
                Console.WriteLine("Duzgun daxil et:");
            }
            }
            Product [] products = new Product [count];
            int x = 0;
            for (int i = 0; i <count; i++)
            {
                Console.WriteLine($"{i+1}.Ad daxil edin :");
                string name = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Type daxil edin:");
                string type = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Qiymet daxil edin:");
                double price = 0;
                bool loop3= true;
                while (loop3)
                {
                    try
                    {
                        price = Convert.ToDouble(Console.ReadLine());
                        loop3= false;
                    }
                    catch
                    {
                        Console.WriteLine("Duzgun daxil et !!!");
                    }
                }
                Product product = new Product();
                product.Name = name;
                product.Price = price;
                product.Type = type;

                
                 store.AddProduct(product);
                x++;

            }
            bool loop = true;
            while (loop) { 
            Console.WriteLine("\n--------------------------------------------------------------\n");
            Console.WriteLine("1.Siyahini goster\n2.Yeni product elave etmek\n3.Product sil\n4.Filtirle\n5.Bitir\n\nSecim et:\n");
                int check = 0;
                bool loop7= true;
                while (loop7) { 
                try { 
             check = Convert.ToInt32(Console.ReadLine());
                        if(check <=5)
                        loop7 = false;
                        else
                        {
                            Console.WriteLine("5 secim var !!! Duzgun secim et!!!");
                        }
                }
                catch
                {
                    Console.WriteLine("Duzgun daxil et !!!!");
                }
                }
                switch (check)
            {
                case 1:
                    store.ReturnList();
                    break;
                case 5:
                    return;
                    break;
                    case 2:
                    Console.WriteLine("Nece yeni product elav etmek isteyirsiz?");
                        int count1=0;
                        bool loop1 = true;
                        while(loop1)
                        try
                        {
                            count1 = Convert.ToInt32(Console.ReadLine());
                                loop1 = false;
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun daxil et!!!");
                        }
                    for (int j = 0; j < count1; j++)
                    {
                        Console.WriteLine($"{x+1}.Ad daxil edin :");
                        string name = Console.ReadLine();
                        Console.WriteLine($"{x + 1}.Type daxil edin:");
                        string type = Console.ReadLine();
                        Console.WriteLine($"{x + 1}.Qiymet daxil edin:");
                            double price = 0;
                            bool loop6=true;
                            while (loop6) { 
                            try
                            {
                                 price = Convert.ToDouble(Console.ReadLine());
                                    loop6=false;
                            }
                            catch
                            {
                                Console.WriteLine("Duzgun daxil et!!!");
                            }
                            }

                            Product product = new Product();
                        product.Name = name;
                        product.Price = price;
                        product.Type = type;


                        store.AddProduct(product);
                            x++;

                    }
                    break;
                case 3:
                    Console.WriteLine("\n--------------------------------------------------------------\n");
                    Console.WriteLine("Nomreni daxil et:");
                        int removeno = 0;
                        bool loop5=true;
                        while (loop5) { 
                        try {
                                
                                removeno = Convert.ToInt32(Console.ReadLine());
                               
                                if (removeno <=store.Products.Length)
                                loop5 = false;
                                else
                                {
                                    Console.WriteLine($"{ store.Products.Length} product  var!!!");
                                }
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun nomre daxil et!!!!!");
                        }
                        }
                        foreach (var item in store.RemoveProductByNo(removeno))
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case 4:
                    Console.WriteLine("1.Ada gore       2.Tipe gore");
                        int check2 = 0;
                        bool loop4 = true;
                        while(loop4) { 
                        try { 
                         check2 = Convert.ToInt32(Console.ReadLine());
                                if (check2 <= 2)
                                {
                                    loop4 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Duzgun daxil et !!!! 1 ve ya 2 sec!!!");
                                }
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun daxil et !!!!");
                        }
                        }
                        if (check2 == 1)
                    {
                        Console.WriteLine("\n--------------------------------------------------------------------\n");
                        Console.WriteLine("Ad daxil edin:");
                        string searchname= Console.ReadLine();
                        foreach (var item in store.FilterProductByName(searchname))
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    else if (check2 == 2)
                    {
                        Console.WriteLine("\n--------------------------------------------------------------------\n");
                        Console.WriteLine("Tip daxil edin:");
                        string searchtype=Console.ReadLine();
                        foreach (var item in store.FilterProductsByType(searchtype))
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                        break;
                    default:
                        Console.WriteLine("Duzgun secim daxil et:");
                        break;
                }
            }

        }
    }
}
