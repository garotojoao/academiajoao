using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CONTROLE_ACADEMIA.controle
{
    public class Servidor 
    {
        public SQLiteConnection Con { get; set; }

        public Servidor() 
        {
            Con = new SQLiteConnection();
        }
        public string CreateDataBase(string name) {
            try
            {
                SQLiteConnection.CreateFile(name);
                return "OK";
            }
            catch ( Exception Erro)
            {
                return $"Erro: {Erro.Message}";
            }
        }

        public void Open(string name)
        {
            string str = $"Data Source = {name};version = 3;";
            Con = new SQLiteConnection(str);
            Con.Open();
        }

        public string CreateTable(string sql, string name)
        {
            try
            {
                Open(name);
                using (SQLiteCommand cmd = new SQLiteCommand(Con))
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Erro)
            {
                return $"Erro: {Erro.Message}";
            }
            return "OK";

        }
    }
}
