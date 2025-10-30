namespace CONTROLE_ACADEMIA.visao
{
    partial class FormWebCam
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbDevices = new System.Windows.Forms.ComboBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.PbVideo = new System.Windows.Forms.PictureBox();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispositivos conecatados";
            // 
            // CbDevices
            // 
            this.CbDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbDevices.FormattingEnabled = true;
            this.CbDevices.Location = new System.Drawing.Point(18, 35);
            this.CbDevices.Name = "CbDevices";
            this.CbDevices.Size = new System.Drawing.Size(255, 21);
            this.CbDevices.TabIndex = 1;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(18, 80);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(255, 42);
            this.BtnConectar.TabIndex = 2;
            this.BtnConectar.Text = "conectar ao dispositivo ";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // PbVideo
            // 
            this.PbVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PbVideo.Location = new System.Drawing.Point(18, 163);
            this.PbVideo.Name = "PbVideo";
            this.PbVideo.Size = new System.Drawing.Size(158, 147);
            this.PbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbVideo.TabIndex = 3;
            this.PbVideo.TabStop = false;
            // 
            // PbFoto
            // 
            this.PbFoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PbFoto.Location = new System.Drawing.Point(222, 163);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(158, 147);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFoto.TabIndex = 4;
            this.PbFoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "camera selecionada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "foto capturada";
            // 
            // BtnFoto
            // 
            this.BtnFoto.Location = new System.Drawing.Point(40, 349);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(75, 23);
            this.BtnFoto.TabIndex = 7;
            this.BtnFoto.Text = "capturar foto ";
            this.BtnFoto.UseVisualStyleBackColor = true;
            this.BtnFoto.Click += new System.EventHandler(this.BtnFoto_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(254, 349);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "Salvar ";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FormWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 468);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnFoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbFoto);
            this.Controls.Add(this.PbVideo);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.CbDevices);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormWebCam";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPTURA DE FOTO - CAMERA";
            this.Load += new System.EventHandler(this.FormWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDevices;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.PictureBox PbVideo;
        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.Button BtnSalvar;
    }
}