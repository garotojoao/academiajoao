namespace CONTROLE_ACADEMIA.visao
{
    partial class FormAcademia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcademia));
            this.DG = new System.Windows.Forms.DataGridView();
            this.BN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMatricular = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExluir = new System.Windows.Forms.ToolStripButton();
            this.BtnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lbNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN)).BeginInit();
            this.BN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(12, 2);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(703, 459);
            this.DG.TabIndex = 0;
            this.DG.SelectionChanged += new System.EventHandler(this.DG_SelectionChanged);
            // 
            // BN
            // 
            this.BN.AddNewItem = null;
            this.BN.AutoSize = false;
            this.BN.CountItem = this.bindingNavigatorCountItem;
            this.BN.DeleteItem = null;
            this.BN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnMatricular,
            this.btnEditar,
            this.btnExluir,
            this.BtnPesquisar,
            this.btnRelatorio});
            this.BN.Location = new System.Drawing.Point(0, 464);
            this.BN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BN.Name = "BN";
            this.BN.PositionItem = this.bindingNavigatorPositionItem;
            this.BN.Size = new System.Drawing.Size(1153, 85);
            this.BN.TabIndex = 1;
            this.BN.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(64, 82);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 82);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 82);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 85);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 85);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 82);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 82);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 85);
            // 
            // btnMatricular
            // 
            this.btnMatricular.AutoSize = false;
            this.btnMatricular.Image = ((System.Drawing.Image)(resources.GetObject("btnMatricular.Image")));
            this.btnMatricular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(109, 41);
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = false;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 41);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExluir
            // 
            this.btnExluir.AutoSize = false;
            this.btnExluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExluir.Image")));
            this.btnExluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(109, 41);
            this.btnExluir.Text = "Excluir";
            this.btnExluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.AutoSize = false;
            this.BtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisar.Image")));
            this.BtnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(109, 41);
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click_1);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.AutoSize = false;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(109, 41);
            this.btnRelatorio.Text = "Relatório";
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(833, 24);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(217, 195);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 2;
            this.pbFoto.TabStop = false;
            // 
            // lbNome
            // 
            this.lbNome.Location = new System.Drawing.Point(767, 259);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(349, 44);
            this.lbNome.TabIndex = 3;
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAcademia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 549);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.BN);
            this.Controls.Add(this.DG);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAcademia";
            this.ShowIcon = false;
            this.Text = "CONTROLE DE ACADEMIA";
            this.Load += new System.EventHandler(this.FormAcademia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BN)).EndInit();
            this.BN.ResumeLayout(false);
            this.BN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.BindingNavigator BN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
        private System.Windows.Forms.ToolStripButton btnMatricular;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExluir;
        private System.Windows.Forms.ToolStripButton BtnPesquisar;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lbNome;
    }
}