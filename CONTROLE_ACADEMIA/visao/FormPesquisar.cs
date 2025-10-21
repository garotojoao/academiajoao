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
    public partial class FormPesquisar : Form
    {
        public FormPesquisar()
        {
            InitializeComponent();
        }
        internal modelo.Academia BoaForma { get; set; }
        private void FormPesquisar_Load(object sender, EventArgs e)
        {   
            

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;
            if (RBinicio.Checked) filtro = "I";
            if (RBmeio.Checked) filtro = "M";
            if (RBfinal.Checked) filtro = "F";
            BindingSource bs = new BindingSource();
            bs.DataSource = BoaForma.Pesquisar(TxtNome.Text, filtro);
            DgvLista.DataSource = bs;
            DgvLista.AutoResizeColumns();
        }

        internal int Cod { get; set; }
        private void btnabrir_Click(object sender, EventArgs e)
        {
            Cod = Convert.ToInt32(
                    DgvLista.CurrentRow.Cells["Id"].Value.ToString()
                    );
                    this.Dispose();
        }
    }
}
