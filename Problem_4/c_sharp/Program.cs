using System;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int larger = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int x = 100; x < 1000; x++)
                {
                    int product = i*x;
                    string products = product.ToString();

                    char[] charArray = products.ToCharArray();
                    Array.Reverse( charArray );
                    string reverse = new string(charArray);     
                //   Console.WriteLine(products + " - " + reverse);
                    if (products == reverse)
                    {
                        if (product > larger)
                        {
                            larger =  product;
                        }
                        
                          Console.WriteLine("{0} X {1} = {2} --- {3}",i,x,product, reverse);
                    }

                  
                }
            }
            Console.WriteLine (larger);
          
        }
    }
}
