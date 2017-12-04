using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FormContatoVer : Form
    {
        private Contato Contato { get; set; }
        public FormContatoVer(Contato contato)
        {
            InitializeComponent();
            this.Contato = contato;
            this.Text = contato.Nome;
            this.textBoxNome.Text = Contato.Nome;
            this.textBoxAdicionais.Text = Contato.InformacoesAdicionais;
            this.textBoxRua.Text = Contato.Endereco.Rua;
            this.textBoxCidade.Text = Contato.Endereco.Cidade;
            this.textBoxEstado.Text = Contato.Endereco.Estado;
            this.textBoxCep.Text = Contato.Endereco.CEP;
            this.textBoxTelefone.Text = Contato.Telefone;
            this.textBoxCelular.Text = Contato.Celular;
            this.textBoxWhatsapp.Text = Contato.Whatsapp;
            this.textBoxEmail.Text = Contato.Email;
            this.textBoxFacebook.Text = Contato.Facebook;
        }

        private void FormContatoVer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
