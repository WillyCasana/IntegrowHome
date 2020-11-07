using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrowHomeBOL
{
   public class EntradaBlogEnt
    {
        public int EntradaId { get; set; }

        public DateTime FechaEntrada { get; set; }
        public string TituloEntrada { get; set; }

        public string ImagenEntrada { get; set; }

        public string DescripcionEntrada { get; set; }

    }
}
