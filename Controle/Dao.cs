using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class DAO
    {
        private static DAO dao;
        private string con = @"Data Source=GS\SQLEXPRESS;Initial Catalog=Etiquetas;Integrated Security=True";
        private DAO() { }

        public DAO getDAO()
        {
            if (dao == null) dao = new DAO();
            return dao;
        }


    }
}
