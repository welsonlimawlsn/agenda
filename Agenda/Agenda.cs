using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Agenda
    {
        List<Contato> contatos;
        public Agenda()
        {
            contatos = new List<Contato>();
        }
        public void NovoContato(Contato contato)
        {
            contatos.Add(contato);
            contato.Salvar();
        }
    }
}
