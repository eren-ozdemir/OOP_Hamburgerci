using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Menu : Gida
    {
        public override string ToString()
        {
            return $"{Ad} Menü + ({Fiyat:n2}₺)";
        }
    }
}
