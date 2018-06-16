using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Evento
    {
        public int  id { get; set; }
        public string cnpj { get; set; }
        public string nome { get; set; }
        public DateTime dtEvento { get; set; }
        public string  local { get; set; }

    }
}
   