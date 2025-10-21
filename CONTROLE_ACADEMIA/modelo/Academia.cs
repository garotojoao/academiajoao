using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLE_ACADEMIA.controle;

namespace CONTROLE_ACADEMIA.modelo
{
    public class Academia
    {
        public List<Aluno> Alunos { get; set; }
        public Academia() { 
            Alunos = new List<Aluno>();
        }
        public void Matricular (Aluno Reg) {
            try
            {
                Alunos.Add(Reg); // na moraria ram 
                AlunoDB tabela = new AlunoDB();
                string res = tabela.Insert(Reg);
                if (res != "OK")
                {
                    MessageBox.Show($"Erro: {res}");
                    Environment.Exit(0);// sai do programa 
                }

            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(Erro.Message);
            }
            
        }

        public void Editar(Aluno Reg)
        {
            try
            {
                Aluno old = Alunos.FirstOrDefault(i => i.Id == Reg.Id);
                old.Nome = Reg.Nome;
                old.Contato = Reg.Contato;
                old.Altura = Reg.Altura;
                old.Peso = Reg.Peso;
                old.Sexo = Reg.Sexo;
                old.Documento = Reg.Documento;
                old.Nascimento = Reg.Nascimento;

                AlunoDB tabela = new AlunoDB();
                string res = tabela.Update(old);
                if (res != "OK")
                {
                    MessageBox.Show($"Erro: {res}");
                    Environment.Exit(0);// sai do programa 
                }
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(Erro.Message);
            }
        }
        public void Excluir(Aluno reg)
        {
            try
            {
                Aluno old = Alunos.FirstOrDefault(i => i.Id == reg.Id);
                AlunoDB tabela = new AlunoDB();
                string res = tabela.Delete(old);
                if (res != "OK")
                {
                    MessageBox.Show($"Erro:{res}");
                }
                Alunos.Remove(reg);
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(Erro.Message);
            }
        }

        public object Pesquisar(string texto, string filtro)
        {
            if (filtro.Equals("I"))
                return Alunos.Where(i => i.Nome.StartsWith(texto));
            if (filtro.Equals("M"))
                return Alunos.Where(i => i.Nome.Contains(texto));
            else
                return Alunos.Where(i => i.Nome.EndsWith(texto));
        }
    }
}
