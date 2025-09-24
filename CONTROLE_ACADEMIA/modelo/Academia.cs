using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Alunos.Add(Reg);
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(Erro.Message);
            }
            
        }
    }
}
