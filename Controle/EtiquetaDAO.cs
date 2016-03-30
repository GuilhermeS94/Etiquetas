using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Controle
{
    public class EtiquetaDAO
    {
        private static EtiquetaDAO eDAO;
        private EtiquetaDAO() { }

        public static EtiquetaDAO getEDAO()
        {
            if (eDAO == null) eDAO = new EtiquetaDAO();
            return eDAO;
        }
        private string str_con = @"Data Source=GS\SQLEXPRESS;Initial Catalog=Etiquetas;Integrated Security=True";


        public List<Etiqueta> ListarEtiquetas()
        {
            List<Etiqueta> etiquetas = new List<Etiqueta>();
            using (SqlConnection con = new SqlConnection(str_con))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Etiqueta", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            etiquetas.Add(
                            new Etiqueta
                            {
                                id = int.Parse(reader["Id"].ToString()),
                                nome = reader["nome"].ToString(),
                                distH = float.Parse(reader["distH"].ToString()),
                                distV = float.Parse(reader["distV"].ToString()),
                                margemE = float.Parse(reader["margemE"].ToString()),
                                margemT = float.Parse(reader["margemT"].ToString()),
                                largura = float.Parse(reader["largura"].ToString()),
                                altura = float.Parse(reader["altura"].ToString()),
                                numH = byte.Parse(reader["numH"].ToString()),
                                numV = byte.Parse(reader["numV"].ToString())
                            });
                        }
                    }
                }
                con.Close();
            }
            return etiquetas;
        }

        public Etiqueta GetEtiqueta(int id)
        {
            Etiqueta etq = null;
            using (SqlConnection con = new SqlConnection(str_con))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Etiqueta WHERE Id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            etq =
                            new Etiqueta
                            {
                                id = int.Parse(reader["Id"].ToString()),
                                nome = reader["nome"].ToString(),
                                distH = float.Parse(reader["distH"].ToString()),
                                distV = float.Parse(reader["distV"].ToString()),
                                margemE = float.Parse(reader["margemE"].ToString()),
                                margemT = float.Parse(reader["margemT"].ToString()),
                                largura = float.Parse(reader["largura"].ToString()),
                                altura = float.Parse(reader["altura"].ToString()),
                                numH = byte.Parse(reader["numH"].ToString()),
                                numV = byte.Parse(reader["numV"].ToString())
                            };
                        }
                    }
                }
                con.Close();
            }
            return etq;
        }

    }
}
