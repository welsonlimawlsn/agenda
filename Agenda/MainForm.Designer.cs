﻿namespace Agenda
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNovoContato = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContatoPessoal = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPessoais = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovoContato});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNovoContato
            // 
            this.menuNovoContato.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContatoPessoal,
            this.comercialToolStripMenuItem});
            this.menuNovoContato.Name = "menuNovoContato";
            this.menuNovoContato.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menuNovoContato.Size = new System.Drawing.Size(94, 20);
            this.menuNovoContato.Text = "Novo Contato";
            this.menuNovoContato.Click += new System.EventHandler(this.menuNovoContato_Click);
            // 
            // menuContatoPessoal
            // 
            this.menuContatoPessoal.Name = "menuContatoPessoal";
            this.menuContatoPessoal.Size = new System.Drawing.Size(128, 22);
            this.menuContatoPessoal.Text = "Pessoal";
            this.menuContatoPessoal.Click += new System.EventHandler(this.menuContatoPessoal_Click);
            // 
            // comercialToolStripMenuItem
            // 
            this.comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            this.comercialToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.comercialToolStripMenuItem.Text = "Comercial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contatos Pessoais:";
            // 
            // listBoxPessoais
            // 
            this.listBoxPessoais.FormattingEnabled = true;
            this.listBoxPessoais.Location = new System.Drawing.Point(12, 44);
            this.listBoxPessoais.Name = "listBoxPessoais";
            this.listBoxPessoais.Size = new System.Drawing.Size(186, 264);
            this.listBoxPessoais.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 323);
            this.Controls.Add(this.listBoxPessoais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNovoContato;
        private System.Windows.Forms.ToolStripMenuItem menuContatoPessoal;
        private System.Windows.Forms.ToolStripMenuItem comercialToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPessoais;
    }
}

