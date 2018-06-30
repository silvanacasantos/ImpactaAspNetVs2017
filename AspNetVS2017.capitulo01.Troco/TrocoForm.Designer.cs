namespace AspNetVS2017.capitulo01.Troco
{
    partial class TrocoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocoForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorCompratextBox = new System.Windows.Forms.TextBox();
            this.valorPagotextBox = new System.Windows.Forms.TextBox();
            this.TrocotextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moedasImageList = new System.Windows.Forms.ImageList(this.components);
            this.moedaslistView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.calcularButton);
            this.groupBox1.Controls.Add(this.TrocotextBox);
            this.groupBox1.Controls.Add(this.valorPagotextBox);
            this.groupBox1.Controls.Add(this.valorCompratextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da &Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor &Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Troco:";
            // 
            // valorCompratextBox
            // 
            this.valorCompratextBox.Location = new System.Drawing.Point(100, 32);
            this.valorCompratextBox.Name = "valorCompratextBox";
            this.valorCompratextBox.Size = new System.Drawing.Size(175, 20);
            this.valorCompratextBox.TabIndex = 1;
            // 
            // valorPagotextBox
            // 
            this.valorPagotextBox.Location = new System.Drawing.Point(100, 78);
            this.valorPagotextBox.Name = "valorPagotextBox";
            this.valorPagotextBox.Size = new System.Drawing.Size(175, 20);
            this.valorPagotextBox.TabIndex = 3;
            // 
            // TrocotextBox
            // 
            this.TrocotextBox.Location = new System.Drawing.Point(100, 124);
            this.TrocotextBox.Name = "TrocotextBox";
            this.TrocotextBox.ReadOnly = true;
            this.TrocotextBox.Size = new System.Drawing.Size(175, 20);
            this.TrocotextBox.TabIndex = 5;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(6, 174);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(269, 53);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "Ca&lcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.moedaslistView);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 371);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Troco";
            // 
            // moedasImageList
            // 
            this.moedasImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moedasImageList.ImageStream")));
            this.moedasImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.moedasImageList.Images.SetKeyName(0, "1.png");
            this.moedasImageList.Images.SetKeyName(1, "5.png");
            this.moedasImageList.Images.SetKeyName(2, "10.png");
            this.moedasImageList.Images.SetKeyName(3, "25.png");
            this.moedasImageList.Images.SetKeyName(4, "50.png");
            this.moedasImageList.Images.SetKeyName(5, "100.png");
            // 
            // moedaslistView
            // 
            this.moedaslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moedaslistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.moedaslistView.LargeImageList = this.moedasImageList;
            this.moedaslistView.Location = new System.Drawing.Point(3, 16);
            this.moedaslistView.Name = "moedaslistView";
            this.moedaslistView.Size = new System.Drawing.Size(714, 352);
            this.moedaslistView.TabIndex = 4;
            this.moedaslistView.UseCompatibleStateImageBehavior = false;
            // 
            // TrocoForm
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrocoForm";
            this.Text = "Troco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox TrocotextBox;
        private System.Windows.Forms.TextBox valorPagotextBox;
        private System.Windows.Forms.TextBox valorCompratextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView moedaslistView;
        private System.Windows.Forms.ImageList moedasImageList;
    }
}

