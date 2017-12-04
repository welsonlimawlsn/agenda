using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Serializable()]
    public abstract class Contato
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string InformacoesAdicionais { get; set; }
        public override string ToString()
        {
            return this.Nome;
        }
    }
}
