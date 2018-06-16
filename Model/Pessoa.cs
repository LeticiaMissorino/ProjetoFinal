using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        
        public string cnpj { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string passaporte { get; set; }
        public string rne { get; set; }
        public string nomeSocial { get; set; }
        public DateTime dtNasc { get; set; }
        public string rg { get; set; }
        public bool isGravida { get; set; }
        public bool isPrimeira { get; set; }
        public string facebook { get; set; }
        public string status { get; set; }
        public int idEstadoCivil { get; set; }
        public int idSexo { get; set; }
        public int idNacionalidade { get; set; }
        public bool isMenor { get; set; }
        public string respMenor { get; set; }
        //Endereço
        public string localidade { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string uf { get; set; }
        public string pais { get; set; }
        public int numero { get; set; }
       

    }
}
