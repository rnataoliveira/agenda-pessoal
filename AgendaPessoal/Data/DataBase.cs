using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPessoal.Data
{
    public class DataBase
    {
        protected string strSql = "";
        protected StringBuilder stbSql = new StringBuilder();
        protected SqlConnection sqlConexao = new SqlConnection(@"Data Source=DESKTOP-BBI3TPC;Initial Catalog=agenda;Integrated Security=True");
        protected SqlCommand sqlComando;
        protected SqlDataReader dr;

        protected void mtdAbrirConexao()
        {
            this.sqlConexao.Open();
            this.sqlComando = new SqlCommand(this.strSql, this.sqlConexao);
            this.sqlComando.ExecuteNonQuery();
            this.dr = this.sqlComando.ExecuteReader();
        }

        protected void mtdFecharConexao()
        {
            if (this.sqlConexao != null)
            {
                this.sqlConexao.Close();
            }
            this.strSql = "";
            this.stbSql.Clear();
            this.dr.Close();
        }


        protected void mtdDBInsertUpdate()
        {
            this.mtdAbrirConexaoIU();
            this.mtdFecharConexaoIU();
        }

        private void mtdAbrirConexaoIU()
        {
            this.sqlConexao.Open();
            this.sqlComando = new SqlCommand(this.strSql + this.stbSql, this.sqlConexao);
            this.sqlComando.ExecuteNonQuery();
        }

        private void mtdFecharConexaoIU()
        {
            if (this.sqlConexao != null)
            {
                this.sqlConexao.Close();
            }
            this.strSql = "";
            this.stbSql.Clear();
        }


    }
}
