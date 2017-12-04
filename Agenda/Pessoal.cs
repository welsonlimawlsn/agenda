using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Pessoal : Contato
    {
        public override void Salvar()
        {
            Arquivo.Salvar(@"C:\contatos", "contatos-pessoais.txt", this.Nome, this.Endereco.Rua, this.Endereco.Cidade, this.Endereco.Estado, this.Endereco.CEP, this.Telefone, this.Celular, this.Whatsapp, this.Email, this.Facebook, this.InformacoesAdicionais);
        }
    }
}
