using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Anamnese
    {

        public int id { get; set; }
        public string cpf { get; set; }
        public string obs { get; set; }
        public string statusemocional { get; set; }
        public int idEvento { get; set; }
        public bool presenca { get; set; }
        public bool aceite { get; set; }
        public string status{ get; set; }
    }
}
