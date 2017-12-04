using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Serializable()]
    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public Endereco(string rua, string cidade, string estado, string cep)
        {
            this.Rua = rua;
            this.Cidade = cidade;
            this.Estado = estado;
            this.CEP = cep;
        }
    }
}
