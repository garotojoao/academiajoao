using CONTROLE_ACADEMIA.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLE_ACADEMIA.visao
{
    public partial class Form1 : Form
    {
        internal Aluno Reg { get; set; }
        public static int SelectedIndex { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Reg == null) Novo();
            else Editar();
            this.Dispose();
        }

        public void Editar(Aluno reg)
        {
            try
            {
                Aluno old = Aluno.FirstOrDefault(i => ((Aluno)i).Id == reg.Id);
                old.Nome = reg.Nome;
                old.Contato = reg.Contato;
                old.Altura = reg.Altura;
                old.Peso = reg.Peso;
                old.Sexo = reg.Sexo;
                old.Documento = reg.Documento;
                old.Nascimento = reg.Nascimento;
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(Erro.Message);
            }
        }

        private void Novo()
        {
            Reg = new Aluno()
            {
                Id = Int16.Parse(txtMatricula.Text),
                Nome = txtNome.Text,
                Nascimento = dtNascimento.Value,
                Altura = Double.Parse(txtAltura.Text),
                Peso = Double.Parse(txtPeso.Text),
                Contato = txtContato.Text,
                Documento = txtDocumento.Text,
                Sexo = CbSexo.Text
            };
        }

        private void Editar()
        {
            Reg.Nome = txtNome.Text;
            Reg.Nascimento = dtNascimento.Value;
            Reg.Altura = Double.Parse(txtAltura.Text);
            Reg.Peso = Double.Parse(txtPeso.Text);
            Reg.Contato = txtContato.Text;
            Reg.Documento = txtDocumento.Text;
            Reg.Sexo = CbSexo.Text;
        }

      

        private void btnGerarMatricula_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = r.Next(1, 12);
            string cod = DateTime.Now.Year.ToString() + n.ToString();
            txtMatricula.Text = cod;
            // 202512
        }

        private void FormMatricula_Load(object sender, EventArgs e)
        {

            if (Reg != null)
            {
                txtMatricula.Text = Reg.Id.ToString();
                txtMatricula.ReadOnly = true;
                btnGerarMatricula.Enabled = false;
                txtNome.Text = Reg.Nome;
                dtNascimento.Value = Reg.Nascimento;
                txtDocumento.Text = Reg.Documento;
                txtContato.Text = Reg.Contato;
                txtAltura.Text = Reg.Altura.ToString();
                txtPeso.Text = Reg.Peso.ToString();
                if (Reg.Sexo == "M") CbSexo.SelectedIndex = 0;
                if (Reg.Sexo == "F") CbSexo.SelectedIndex = 1;
                if (Reg.Sexo == "I") CbSexo.SelectedIndex = 2;
                CarregarFoto();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reg = null;
            this.Dispose();
        }

        private void btnEditarFoto_Click(object sender, EventArgs e)
        {
            string caminho = $"\\fotos\\{txtMatricula.Text}" + 
                $".png";
            if (Reg != null)
            { 
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Fotos |*.png";
                file.FileName = "";
                file.ShowDialog();
                if (File.Exists(file.FileName)) {
                    

                    if (File.Exists(Environment.CurrentDirectory + caminho))
                    {
                        Application.DoEvents();
                        pbFoto.Image.Dispose();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete(Environment.CurrentDirectory + caminho);
                    }
                    File.Copy(file.FileName, Environment.CurrentDirectory + caminho);
                    CarregarFoto();
                }
            }
        }

        private void CarregarFoto()
        {

            string caminho = $"\\fotos\\{txtMatricula.Text}" +
               $".png";

            if (File.Exists(Environment.CurrentDirectory +
                       caminho))
            {

                var fs = new FileStream(Environment.CurrentDirectory +
                       caminho, FileMode.Open,
                    FileAccess.Read);
                pbFoto.Image = Image.FromStream(fs);
            }
        }


        private void btnCapturar_Click_1(object sender, EventArgs e)
        {
            FormWebCam webCam = new FormWebCam();
            string caminho = Environment.CurrentDirectory +
                $"\\fotos\\{txtMatricula.Text}" + $".png";
            Application.DoEvents(); // AMD RAYZEN
            pbFoto.Image.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            webCam.caminho = caminho;
            webCam.ShowDialog();
            CarregarFoto();
        }
    }
}
