using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLE_ACADEMIA.modelo
{
    public class Aluno
    {
        public Int32 Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Documento { get; set; }
        public string Contato { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Sexo { get; set; }

        public Aluno(Int32 Id, string Nome, DateTime Nascimento, string Documento, string Contato, double Altura, double Peso, string sexo)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Nascimento = Nascimento;
            this.Documento = Documento;
            this.Contato = Contato;
            this.Altura = Altura;
            this.Peso = Peso;
            this.Sexo = sexo;
        }

        public Aluno():this(0, "", DateTime.Now, "", "", 0f, 0f, "")
        {

        }
        public double Imc { 
            get
            {
                return  Math.Round( Peso / Math.Pow(Altura, 2),2);
            }
        }
        public int Idade
        {
            get
            {
                TimeSpan calculo = DateTime.Now - Nascimento;
                int i = (int) Math.Truncate(calculo.TotalDays / 365);
                return i;
            }
        }
    }
}
