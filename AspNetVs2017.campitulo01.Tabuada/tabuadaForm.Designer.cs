﻿namespace AspNetVs2017.campitulo01.Tabuada
{
    partial class tabuadaForm
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
            this.tabuadaTextBox = new System.Windows.Forms.TextBox();
            this.tabuadaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tabuadaTextBox
            // 
            this.tabuadaTextBox.Location = new System.Drawing.Point(13, 13);
            this.tabuadaTextBox.Name = "tabuadaTextBox";
            this.tabuadaTextBox.Size = new System.Drawing.Size(267, 20);
            this.tabuadaTextBox.TabIndex = 0;
            this.tabuadaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabuadaTextBox_KeyPress);
            // 
            // tabuadaListBox
            // 
            this.tabuadaListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabuadaListBox.FormattingEnabled = true;
            this.tabuadaListBox.Location = new System.Drawing.Point(12, 39);
            this.tabuadaListBox.Name = "tabuadaListBox";
            this.tabuadaListBox.Size = new System.Drawing.Size(268, 225);
            this.tabuadaListBox.TabIndex = 1;
            // 
            // tabuadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tabuadaListBox);
            this.Controls.Add(this.tabuadaTextBox);
            this.Name = "tabuadaForm";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tabuadaTextBox;
        private System.Windows.Forms.ListBox tabuadaListBox;
    }
}

