using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraping.Model
{
    public class Item
    {
        public int? Numero { get; set; }
        public string? Titulo { get; set; }
        public string? Situacao { get; set; }
        public string? QtdeSolicitada { get; set; }
        public string? ValorEstimadoUnitario { get; set; }
    }
}
