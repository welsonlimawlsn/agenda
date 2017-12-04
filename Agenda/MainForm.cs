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
        public static List<Contato> ListaContatosComerciais { get; set; }
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
            listBoxPessoais.Items.Clear();
            ListaContatosPessoais = Arquivo.Ler(Pessoal.ARQUIVO, Pessoal.PASTA) == null ? new List<Contato>() : (List<Contato>)Arquivo.Ler(Pessoal.ARQUIVO, Pessoal.PASTA);
            foreach (Contato contato in ListaContatosPessoais)
            {
                listBoxPessoais.Items.Add(contato);
            }
            listBoxComerciais.Items.Clear();
            ListaContatosComerciais = Arquivo.Ler(Comercial.ARQUIVO, Comercial.PASTA) == null ? new List<Contato>() : (List<Contato>)Arquivo.Ler(Comercial.ARQUIVO, Comercial.PASTA);
            foreach (Contato contato in ListaContatosComerciais)
            {
                listBoxComerciais.Items.Add(contato);
            }
        }

        private void listBoxPessoais_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBoxPessoais.SelectedIndex != -1)
            {
                FormContatoVer formulario = new FormContatoVer((Contato)listBoxPessoais.SelectedItem);
                formulario.Show();
            }
        }

        private void comercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContato formulario = new FormContato(new Comercial(), FormContato.Acao.Novo);
            formulario.ShowDialog();
            AtulizarListas();
        }

        private void listBoxComerciais_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBoxComerciais.SelectedIndex != -1)
            {
                FormContatoVer formulario = new FormContatoVer((Contato)listBoxComerciais.SelectedItem);
                formulario.Show();
            }
        }
    }
}
