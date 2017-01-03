using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class CLmapTB_A2_WS2
    {
        private String rq_sql;
        private int id;
        private String nom;
        private String prenom;

        public string selectAll()
        {
            this.rq_sql = "SELECT * FROM TB_A2_WS2;";
            return rq_sql;
        }

        public string selectByName()
        {
            this.rq_sql = "SELECT * FROM TB_A2_WS2 WHERE nom = " + nom + ";";
            return rq_sql;
        }

        public string delete()
        {
            this.rq_sql = "DELETE FROM TB_A2_WS2 WHERE id = " + id + ";";
            return rq_sql;
        }

        public string insert()
        {
            this.rq_sql = "INSERT INTO TB_A2_WS2 (id, nom, prenom)" + "VALUES ('" + id + "','" + nom + "','" + prenom +"');";
            return rq_sql;
        }

        public string update()
        {
            this.rq_sql = "UPDATE TB_A2_WS2  SET nom = " + nom + " , prenom = " + prenom + " WHERE id = " + id + ");";
            return rq_sql;
        }

        public int Id
        {
            get{return this.id;}
            set{id = value;}
        }

        public string Nom
        {
            get{return this.Nom;}
            set{Nom = value;}
        }

        public string Prenom
        {
            get{return this.Prenom;}
            set{Prenom = value;}
        }
    }
}
