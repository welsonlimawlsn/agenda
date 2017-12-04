using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Serializable()]
    public class Pessoal : Contato
    {
        public const string PASTA = @"C:\contatos";
        public const string ARQUIVO = "contatos-pessoais.txt";
        public override void Salvar()
        {
            
        }
    }
}
