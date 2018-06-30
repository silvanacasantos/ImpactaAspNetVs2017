namespace AspNetVS2017.capitulo01.Fretes
{
    partial class FretesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.FreteTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.UFComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.LimparButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% Frete:";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(60, 6);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(177, 20);
            this.ClienteTextBox.TabIndex = 1;
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(60, 38);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(177, 20);
            this.ValorTextBox.TabIndex = 3;
            // 
            // FreteTextBox
            // 
            this.FreteTextBox.Enabled = false;
            this.FreteTextBox.Location = new System.Drawing.Point(60, 102);
            this.FreteTextBox.Name = "FreteTextBox";
            this.FreteTextBox.ReadOnly = true;
            this.FreteTextBox.Size = new System.Drawing.Size(177, 20);
            this.FreteTextBox.TabIndex = 7;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalcularButton.Location = new System.Drawing.Point(113, 156);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(124, 23);
            this.CalcularButton.TabIndex = 10;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // UFComboBox
            // 
            this.UFComboBox.FormattingEnabled = true;
            this.UFComboBox.Items.AddRange(new object[] {
            "AM",
            "MG",
            "RJ",
            "SP",
            "Outros"});
            this.UFComboBox.Location = new System.Drawing.Point(60, 70);
            this.UFComboBox.Name = "UFComboBox";
            this.UFComboBox.Size = new System.Drawing.Size(177, 21);
            this.UFComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(60, 130);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(177, 20);
            this.TotalTextBox.TabIndex = 9;
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(113, 185);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(124, 23);
            this.LimparButton.TabIndex = 11;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            this.LimparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // FretesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 220);
            this.Controls.Add(this.UFComboBox);
            this.Controls.Add(this.LimparButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.FreteTextBox);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FretesForm";
            this.Text = "Fretes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.TextBox FreteTextBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.ComboBox UFComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button LimparButton;
    }
}

