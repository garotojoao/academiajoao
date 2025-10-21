using CONTROLE_ACADEMIA.controle;
using CONTROLE_ACADEMIA.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
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
            CriarBancoDados();
            BoaForma = new Academia();
            CarregarArquivoCSV();
            if (BoaForma.Alunos.Count == 0)
                { 
                    AlunoDB tabela = new AlunoDB();
                    string res = tabela.Select(BoaForma.Alunos);
                    if (res != "OK")
                    {
                        MessageBox.Show($"Erro: {res}");     
                    }
            }
            bs = new BindingSource();
            bs.DataSource = BoaForma.Alunos;
            BN.BindingSource = bs;
            DG.DataSource = bs;
            DG.AutoResizeColumns();
            DG.DefaultCellStyle.ForeColor = Color.FromArgb(107, 49, 49);
            DG.DefaultCellStyle.BackColor = Color.FromArgb(235, 221, 221);
            DG.DefaultCellStyle.SelectionForeColor = Color.FromArgb(222, 237, 85);
            DG.DefaultCellStyle.SelectionBackColor = Color.Black;

            DG.Columns["Nascimento"].Visible = false;
            DG.Columns["Documento"].Visible = false;

        }

        private void CriarBancoDados()
        {   
            string file = "academia.sqlite";
            if (!File.Exists(file)) 
            {
              Servidor serv = new Servidor();
                string res = serv.CreateDataBase(file);
                if (res == "OK")
                {
                    MessageBox.Show(res, "banco criado com sucesso");
                    CriarTabelas();
                }
                else                 {
                    MessageBox.Show($"falha:{res}");
                    Environment.Exit(0);// sai do programa
                }
            }

        }

        private void CriarTabelas()
        {
            string sql = "CREATE TABLE ALUNO(" +
                "COD INT PRIMARY KEY," +
                "NOME VARCHAR (30)," +
                "NASCIMENTO DATE," +
                "CONTATO VARCHAR(15)," +
                "DOCUMENTO VARCHAR(15)," +
                "PESO DOUBLE," +
                "ALTURA DOUBLE," +
                "SEXO VARCHAR(1)" +
                ")";
            Servidor serv = new Servidor();
            string res = serv.CreateTable(sql, "academia.sqlite");
            if (res == "OK")
            {
                MessageBox.Show("Tabela criada com sucesso");
            }
            else
            {
                MessageBox.Show($"Falha: {res}");
                File.Delete("academia.sqlite");
                Environment.Exit(0);
            }
        }

        private void CarregarArquivoCSV()
        {
            string arquivo = "lista.txt";
            if (File.Exists(arquivo))
            {
                // ler o arquivo csv
                string[] linhas = File.ReadAllLines(arquivo);
                foreach (string line in linhas)
                {
                    string[] campos = line.Split(',');
                    Aluno reg = new Aluno()
                    {
                        Id = Int16.Parse(campos[0]),
                        Nome = campos[1],
                        Nascimento = Convert.ToDateTime(campos[2]),
                        Altura = Double.Parse(campos[6].Replace(".",",")),
                        Peso = Double.Parse(campos[5].Replace(".", ",")),
                        Contato = campos[4],
                        Documento = campos[6],
                        Sexo = campos[7].Substring(0, 1)
                    };
                    BoaForma.Matricular(reg);
                }
            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Form1 ficha = new Form1();
            ficha.Reg = null;
            ficha.ShowDialog();
            if (ficha.Reg != null)
            {
                if (ficha.Reg.Id == 0)
                    ficha.Reg.Id = BoaForma.Alunos.Max(i => i.Id) + 1;
                BoaForma.Matricular(ficha.Reg);
                bs.ResetBindings(true);
                bs.MoveLast();
                DG.AutoResizeColumns();
            }
        }

        private void BtnExcluir_Click (object sender, EventArgs e)
            {
                Aluno Reg = (Aluno)bs.Current;
            DialogResult op =
                MessageBox.Show($"Deseja excluir o aluno" + $"{Reg.Nome}", "Alerta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                BoaForma.Excluir(Reg);
                bs.ResetBindings(true);
                bs.MoveLast();
            }

         }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (BoaForma.Alunos.Count == 0)
            {
                MessageBox.Show("Nenhum aluno cadastrado!", "Atenção");
                return;
            }

            Form1 ficha = new Form1();
            ficha .Reg = (Aluno)bs.Current;
            ficha.ShowDialog();
            if (ficha.Reg != null)
            {
                BoaForma.Equals(ficha.Reg);
                bs.ResetBindings(true);
                DG.AutoResizeColumns();
            }

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisar pesquisa = new FormPesquisar();
            pesquisa.BoaForma = BoaForma;
            pesquisa.ShowDialog();
            if (pesquisa.Cod != 0)
            {
                Aluno Reg = BoaForma.Alunos.FirstOrDefault(
                    i => i.Id == pesquisa.Cod
                    );
                bs.Position = bs.IndexOf(Reg);
                btnEditar_Click(sender, e);
            }
        }
    }
}
