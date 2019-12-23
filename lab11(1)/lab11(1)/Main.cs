using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_1_
{

    public delegate void ProductDelegate(Product productChar);
    class MainProgaramm
    {

        static void Main()
        {
            Product productChar = new Product();
            Conveyer conveyer = new Conveyer();

            ProductDelegate productDelegate = new ProductDelegate(conveyer.SizesRemoved);
            productDelegate += conveyer.Wrapped;
            productDelegate += conveyer.Drilled;





            productDelegate.Invoke(productChar);

            Console.WriteLine(productChar.ShowProperties());
            Console.ReadKey();
        }





    }
}
