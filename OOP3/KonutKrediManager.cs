﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class KonutKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");
        }
    }
}
