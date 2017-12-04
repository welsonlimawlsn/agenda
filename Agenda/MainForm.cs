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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuNovoContato_Click(object sender, EventArgs e)
        {

        }

        private void menuContatoPessoal_Click(object sender, EventArgs e)
        {
            FormContato formulario = new FormContato(new Pessoal(), FormContato.Acao.Novo);
            formulario.ShowDialog();
        }
    }
}
