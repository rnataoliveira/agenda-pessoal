using AgendaPessoal.Data;
using System;
using System.Collections.Generic;
using System.Collections;

namespace AgendaPessoal.Models
{
    class Lembrete : DataBase
    {
        public string StrNome { get; set; }
        public DateTime StrData { get; set; }
        public string StrDescricao { get; set; }
        public string StrTelefone { get; set; }
        public string StrEmail { get; set; }

        public Lembrete()
        {

        }

        public Lembrete(string _Nome, DateTime _Data, string _Descricao,
            string _Telefone, string _Email)
        {
            this.StrNome = _Nome;
            this.StrData = _Data;
            this.StrDescricao = _Descricao;
            this.StrTelefone = _Telefone;
            this.StrEmail = _Email;
        }

        public void mtdInsert(Lembrete objLembrete)
        {
            this.stbSql.Append("INSERT INTO Lembrete (nome, data, descricao, email, telefone) VALUES (");
            this.stbSql.Append("'" + objLembrete.StrNome + "', ");
            this.stbSql.Append("'" + objLembrete.StrData + "', ");
            this.stbSql.Append("'" + objLembrete.StrDescricao + "', ");
            this.stbSql.Append("'" + objLembrete.StrEmail + "',");
            this.stbSql.Append("'" + objLembrete.StrTelefone + "');");

            mtdDBInsertUpdate();
        }

        public void MtdUpdate(Lembrete objLembrete)
        {
            this.stbSql.Append("UPDATE Lembrete SET ");
            this.stbSql.Append("Nome = '" + objLembrete.StrNome + "', ");
            this.stbSql.Append("Data = '" + objLembrete.StrData + "', ");
            this.stbSql.Append("Descricao = '" + objLembrete.StrDescricao + "', ");
            this.stbSql.Append("Email = '" + objLembrete.StrEmail + "', ");
            this.stbSql.Append("Telefone = '" + objLembrete.StrTelefone + "'; ");
        }

        public Lembrete MtdSelect()
        {
            Lembrete objLembrete = new Lembrete();
            this.strSql = "SELECT TOP 1 * from LEMBRETE ORDER BY ID DESC;";
            mtdAbrirConexao();
            while (this.dr.Read())
            {
                objLembrete = new Lembrete(dr["Nome"].ToString(), Convert.ToDateTime(dr["Data"]), dr["Descricao"].ToString(),
                    dr["Email"].ToString(), dr["Telefone"].ToString());
            }
            mtdFecharConexao();
            return objLembrete;
        }

        public ICollection<Lembrete> MtdSelectAll()
        {
            ICollection<Lembrete> objLembrete = new List<Lembrete>();
            this.strSql = "SELECT * FROM Lembrete;";
            mtdAbrirConexao();
            while (this.dr.Read())
            {
                objLembrete.Add(new Lembrete(dr["Nome"].ToString(), Convert.ToDateTime(dr["Data"]), dr["Descricao"].ToString(),
                    dr["Email"].ToString(), dr["Telefone"].ToString()));
            }
            mtdFecharConexao();
            return objLembrete;
        }

        public Lembrete MtdSelectConteudo(string strConteudo)
        {
            Lembrete objLembrete = new Lembrete();
            this.strSql = "SELECT * FROM LEMBRETE WHERE NOME LIKE '%" + strConteudo + "%' OR " +
                " DATA LIKE '%" + strConteudo + "%' OR " +
                " DESCRICAO LIKE '%" + strConteudo + "%' OR " +
                " EMAIL LIKE '%" + strConteudo + "%' OR " +
                " TELEFONE LIKE '%" + strConteudo + "%';";

            mtdAbrirConexao();
            if (this.dr.Read())
            {
                objLembrete = new Lembrete(dr["Nome"].ToString(), Convert.ToDateTime(dr["Data"]), dr["Descricao"].ToString(),
                    dr["Email"].ToString(), dr["Telefone"].ToString());
            }
            mtdFecharConexao();
            return objLembrete;
        }

        public void MtdSelectDate(DateTime dttData)
        {
            List<Lembrete> objLembrete = new List<Lembrete>();
            this.strSql = "SELECT * FROM Lembrete WHERE Data = '" + dttData + "';";
            mtdAbrirConexao();
            while (this.dr.Read())
            {
                objLembrete.Add(new Lembrete(dr["Nome"].ToString(), Convert.ToDateTime(dr["Data"].ToString()), dr["Descricao"].ToString(),
                    dr["Email"].ToString(), dr["Telefone"].ToString()));
            }
            mtdFecharConexao();
        }
    }
}
