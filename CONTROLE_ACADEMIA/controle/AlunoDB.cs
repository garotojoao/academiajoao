using CONTROLE_ACADEMIA.modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CONTROLE_ACADEMIA.controle
{
    public class AlunoDB
    {
        Servidor serv = new Servidor();  //
        public string Insert(Aluno reg)
        {
            try
            {
                string sql = $"INSERT INTO ALUNO VALUES(" +
                    $"{reg.Id}," +
                    $"'{reg.Nome}'," +
                    $"'{reg.Nascimento.Date}'," +
                    $"'{reg.Contato}'," +
                    $"'{reg.Documento}'," +
                    $"{reg.Peso.ToString().Replace(',', '.')}," +
                    $"{reg.Altura.ToString().Replace(',', '.')}," +
                    $"'{reg.Sexo}')";

                serv.Open("academia.sqlite");
                using (SQLiteCommand cmd = new SQLiteCommand(serv.Con))
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Erro)
            {
                return $"Erro:{Erro.Message}";
            }
            return "OK";
        }
        public string Update(Aluno reg)
        {
            try
            {
                string sql = $"UPDATE ALUNO SET " +
                    $"NOME = '{reg.Nome}'," +
                    $"NASCIMENTO = '{reg.Nascimento.Date}'," +
                    $"DOCUMENTO = '{reg.Documento}'," +
                    $"PESO = {reg.Peso.ToString().Replace(',', '.')}," +
                    $"ALTURA = {reg.Altura.ToString().Replace(',', '.')}," +
                    $"SEXO = '{reg.Sexo}' " +
                    $"WHERE COD = {reg.Id}";

                serv.Open("academia.sqlite");
                using (SQLiteCommand cmd = new SQLiteCommand(serv.Con))
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Erro)
            {
                return $"Erro:{Erro.Message}";
            }
            return "OK";
        }
        public string Delete(Aluno reg)
        {
            try
            {
                string sql = $"DELETE FROM ALUNO WHERE COD = {reg.Id}";
                serv.Open("academia.sqlite");
                using (SQLiteCommand cmd = new SQLiteCommand(serv.Con))
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Erro)
            {
                return $"Erro:{Erro.Message}";
            }
            return "OK";
        }

        public string Select(List<Aluno> Lista)
        {
            try
            {
                string sql = $"SELECT * FROM ALUNO ORDER BY COD";
                serv.Open("academia.sqlite");
                using (SQLiteCommand cmd = new SQLiteCommand(serv.Con))
                {
                    cmd.CommandText = sql;
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Aluno reg = new Aluno()
                        {
                            Id = dr.GetInt32(0),
                            Nome = dr.GetString(1),
                            Nascimento = Convert.ToDateTime(dr.GetString(2)),
                            Contato = dr.GetString(3),
                            Documento = dr.GetString(4),
                            Peso = dr.GetDouble(5),
                            Altura = dr.GetDouble(6),
                            Sexo = dr.GetString(7)
                        };
                        Lista.Add(reg);
                    }
                    dr.Close();
                }
            }
            catch (Exception Erro)
            {
                return $"Erro:{Erro.Message}";
            }
            return "OK";
        }
    }
}
