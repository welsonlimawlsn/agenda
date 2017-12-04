﻿using System;
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
    public partial class FormContato : Form
    {
        public enum Acao { Novo, Editar }
        private Contato Contato { get; set; }
        private Acao AcaoAFazer { get; set; }
        public FormContato(Contato contato, Acao acao)
        {
            InitializeComponent();
            if(acao == Acao.Novo)
            {
                if (contato is Pessoal)
                    this.Text = "Novo contato pessoal";
                if (contato is Comercial)
                    this.Text = "Novo contato comercial";
            }
            this.Contato = contato;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Contato.Nome = textBoxNome.Text;
            Contato.Endereco = new Endereco(textBoxRua.Text, textBoxCidade.Text, textBoxEstado.Text, textBoxCep.Text);
            Contato.Telefone = textBoxTelefone.Text;
            Contato.Celular = textBoxCelular.Text;
            Contato.Whatsapp = textBoxWhatsapp.Text;
            Contato.Email = textBoxEmail.Text;
            Contato.Facebook = textBoxFacebook.Text;
            Contato.InformacoesAdicionais = textBoxAdicionais.Text;

            if(AcaoAFazer == Acao.Novo)
            {
                if (Contato is Pessoal)
                {
                    MainForm.ListaContatosPessoais.Add(Contato);
                    Arquivo.Salvar(Pessoal.PASTA, Pessoal.ARQUIVO, MainForm.ListaContatosPessoais);
                }
                if (Contato is Comercial)
                {
                    MainForm.ListaContatosComerciais.Add(Contato);
                    Arquivo.Salvar(Comercial.PASTA, Comercial.ARQUIVO, MainForm.ListaContatosComerciais);
                }
            }
            MessageBox.Show("Contato salvo com sucesso!");
            this.Close();
        }
    }
}
