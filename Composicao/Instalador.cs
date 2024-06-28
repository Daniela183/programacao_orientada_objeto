﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    internal class Instalador
    {
        public string? Local { get; set; }
        public DateTime DataHora { get; set; }

        private readonly Logger _logger;
        public Instalador(Logger logger)
        {
            _logger = logger;
        }
        public void Instalar(string mensagem)
        {
            _logger.Log($"{mensagem} - instalando em: {Local} em: {DataHora}");
        }
    }
}
