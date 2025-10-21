namespace CONTROLE_ACADEMIA.visao
{
    partial class FormPesquisar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.RBfinal = new System.Windows.Forms.RadioButton();
            this.RBmeio = new System.Windows.Forms.RadioButton();
            this.RBinicio = new System.Windows.Forms.RadioButton();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnabrir);
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Controls.Add(this.RBfinal);
            this.groupBox1.Controls.Add(this.RBmeio);
            this.groupBox1.Controls.Add(this.RBinicio);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DA PESQUISA";
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(386, 101);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(140, 40);
            this.btnabrir.TabIndex = 6;
            this.btnabrir.Text = "abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(386, 31);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(141, 37);
            this.BtnPesquisar.TabIndex = 5;
            this.BtnPesquisar.Text = "pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // RBfinal
            // 
            this.RBfinal.AutoSize = true;
            this.RBfinal.Location = new System.Drawing.Point(212, 85);
            this.RBfinal.Name = "RBfinal";
            this.RBfinal.Size = new System.Drawing.Size(44, 17);
            this.RBfinal.TabIndex = 4;
            this.RBfinal.TabStop = true;
            this.RBfinal.Text = "final";
            this.RBfinal.UseVisualStyleBackColor = true;
            // 
            // RBmeio
            // 
            this.RBmeio.AutoSize = true;
            this.RBmeio.Location = new System.Drawing.Point(121, 85);
            this.RBmeio.Name = "RBmeio";
            this.RBmeio.Size = new System.Drawing.Size(47, 17);
            this.RBmeio.TabIndex = 3;
            this.RBmeio.TabStop = true;
            this.RBmeio.Text = "meio";
            this.RBmeio.UseVisualStyleBackColor = true;
            // 
            // RBinicio
            // 
            this.RBinicio.AutoSize = true;
            this.RBinicio.Location = new System.Drawing.Point(30, 85);
            this.RBinicio.Name = "RBinicio";
            this.RBinicio.Size = new System.Drawing.Size(50, 17);
            this.RBinicio.TabIndex = 2;
            this.RBinicio.TabStop = true;
            this.RBinicio.Text = "Inicio";
            this.RBinicio.UseVisualStyleBackColor = true;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(30, 59);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(264, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE O NOME";
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Location = new System.Drawing.Point(30, 208);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.Size = new System.Drawing.Size(574, 301);
            this.DgvLista.TabIndex = 1;
            // 
            // FormPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(651, 521);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisar";
            this.Text = "Pesquisar alunos";
            this.Load += new System.EventHandler(this.FormPesquisar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.RadioButton RBfinal;
        private System.Windows.Forms.RadioButton RBmeio;
        private System.Windows.Forms.RadioButton RBinicio;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvLista;
    }
}