using CONTROLE_ACADEMIA.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLE_ACADEMIA.visao
{
    public partial class FormAcademia : Form
    {
        public FormAcademia()
        {
            InitializeComponent();
        }
        Academia BoaForma;
        BindingSource bs;
        private void FormAcademia_Load(object sender, EventArgs e)
        {
            BoaForma = new Academia();
            BoaForma.Matricular(new Aluno(1, "João Silva", new DateTime(2001, 02, 16), "123456", "35220000",
                1.74, 100, "M"));
            BoaForma.Matricular(new Aluno(2, "Maria Souza", new DateTime(1995, 10, 05), "654321", "35225555",
                1.60, 60, "F"));
            BoaForma.Matricular(new Aluno(3, "Pedro Santos", new DateTime(1980, 05, 20), "987654", "35229999",
                1.80, 90, "M"));
            bs = new BindingSource();
            bs.DataSource = BoaForma.Alunos;
            BN.BindingSource = bs;
            DG.DataSource = bs;
            DG.AutoResizeColumns();
            DG.DefaultCellStyle.ForeColor = Color.FromArgb(80, 158, 28);
            DG.DefaultCellStyle.BackColor = Color.FromArgb(77, 77, 77);
            DG.DefaultCellStyle.SelectionForeColor = Color.FromArgb(75, 75, 75);
            DG.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 158, 28);

            DG.Columns["Nascimento"].Visible = false;
            DG.Columns["Documento"].Visible = false;
        }
    }
}
