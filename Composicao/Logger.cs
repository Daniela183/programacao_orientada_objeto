﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    internal class Logger
    {
        public void Log(string mensagem)
        {
            Console.WriteLine("Logando: " + mensagem);
        }
    }
}
