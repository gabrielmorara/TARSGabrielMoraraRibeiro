using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TARSGabrielMoraraRibeiro.Models
{
    public class CategoriaViewModel
    {
        public long CategoryID { get; set; }
        public long UserID { get; set; }
        public long QtdProducts { get; set; }
        public string Name { get; set; }
    }
}
