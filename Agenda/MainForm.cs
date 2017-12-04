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
    [Serializable()]
    public partial class MainForm : Form
    {
        public static List<Contato> ListaContatosPessoais { get; set; }
        public MainForm()
        {
            InitializeComponent();
            AtulizarListas();
        }

        private void menuNovoContato_Click(object sender, EventArgs e)
        {

        }

        private void menuContatoPessoal_Click(object sender, EventArgs e)
        {
            FormContato formulario = new FormContato(new Pessoal(), FormContato.Acao.Novo);
            formulario.ShowDialog();
            AtulizarListas();
        }
        private void AtulizarListas()
        {
            ListaContatosPessoais = null;
            listBoxPessoais.Items.Clear();
            ListaContatosPessoais = (List<Contato>)Arquivo.Ler(Pessoal.PASTA, Pessoal.ARQUIVO);
            foreach (Contato contato in ListaContatosPessoais)
            {
                listBoxPessoais.Items.Add(contato);
            }
        }

        private void listBoxPessoais_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBoxPessoais.SelectedIndex != -1)
            {
                FormContatoVer formulario = new FormContatoVer((Contato)listBoxPessoais.SelectedItem);
                formulario.ShowDialog();
            }
        }
    }
}
