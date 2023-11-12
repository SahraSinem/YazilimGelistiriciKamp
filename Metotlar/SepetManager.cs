using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    { 
        //naming convention
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi: " + product.Name);
        }
    }
}
