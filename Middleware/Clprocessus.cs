using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Middleware
{
    public class Clprocessus
    {
        private DataSet oDs;
        private CLmapTB_A2_WS2 oMap;
        private CAD.Clcad oCad;
        private string rq_sql;

        public DataSet afficher(string dataTableName)
        {
            this.oDs = this.oCad.getRows(this.oMap.selectAll(), dataTableName);
            return this.oDs;
        }

        public DataSet rechercherNom(string dataTableName, string nom)
        {
            this.oDs = this.oCad.getRows(this.oMap.selectByName(), dataTableName);
            return oDs;
        }

        public void deletById()
        {
            this.oCad.actionRows(this.oMap.delete());
        }

        public void insert_update(int id, string nom, string prenom, char methode)
        {
            oMap.Id = id;
            oMap.Nom = nom;
            oMap.Prenom = prenom;
            this.oCad.actionRows(this.oMap.insert());
        }
    }
}
