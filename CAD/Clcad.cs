using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAD
{
    public class Clcad
    {
        private string cnx;
        private string rq_sql;
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        private SqlCommand command;
        private DataSet dataset;

        public Clcad()
        {
            this.rq_sql = null;
            this.cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maxime\documents\visual studio 2015\Projects\eXia_sln_WS2\CAD\DB_A2_WS2.mdf;Integrated Security=True";
            this.connection = new SqlConnection(this.cnx);
            this.command = null;
            this.adapter = null;
            this.dataset = new DataSet();
        }

        public void actionRows(string rq_sql)
        {
            this.rq_sql = rq_sql;
            this.command.CommandText = this.rq_sql;
            this.connection.Open();
            this.command.ExecuteNonQuery();
            this.connection.Close();
        }

        public DataSet getRows(string rq_sql, string dataTablename)
        {
            this.dataset = new DataSet();
            this.rq_sql = rq_sql;
            this.command = new SqlCommand(this.rq_sql, this.connection);
            this.adapter = new SqlDataAdapter(this.command);
            this.adapter.Fill(this.dataset, "TB_A2_WS2");
            return null;
        }

        public string Cnx
        {
            get{return cnx;}
            set{cnx = value;}
        }

        public string Re_sql
        {
            get{return rq_sql;}
            set{rq_sql = value;}
        }

        public SqlDataAdapter Adapter
        {
            get{return adapter;}
            set{adapter = value;}
        }

        public SqlConnection Connection
        {
            get{return connection;}
            set{connection = value;}
        }

        public SqlCommand Command
        {
            get{return command;}
            set{command = value;}
        }

        public DataSet Dataset
        {
            get{return dataset;}
            set{dataset = value;}
        }

    }
}
