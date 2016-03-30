using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controle
{
    public class ModeloDAO
    {
        private static ModeloDAO mDAO;
        private ModeloDAO() { }

        public static ModeloDAO getMDAO()
        {
            if (mDAO == null) mDAO = new ModeloDAO();
            return mDAO;
        }
        private string str_con = @"Data Source=GS\SQLEXPRESS;Initial Catalog=Etiquetas;Integrated Security=True";

        public List<ModeloEtq> ListarModelos()
        {
            List<ModeloEtq> modelos = new List<ModeloEtq>();
            using (SqlConnection con = new SqlConnection(str_con))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Modelo", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modelos.Add(
                            new ModeloEtq
                            {
                                id = int.Parse(reader["Id"].ToString()),
                                etiqueta = EtiquetaDAO.getEDAO().GetEtiqueta(int.Parse(reader["Id_etiqueta"].ToString())),
                                nome = reader["nome"].ToString(),
                                fonte_barcode = reader["fonte_barcode"].ToString(),
                                fonte_legenda = reader["fonte_legenda"].ToString(),
                                tam_font_bc = byte.Parse(reader["tam_font_bc"].ToString()),
                                tam_font_leg = byte.Parse(reader["tam_font_leg"].ToString()),
                                conteudo = reader["conteudo"].ToString(),
                                tipo_papel = reader["tipo_papel"].ToString(),
                                quantidade = int.Parse(reader["quantidade"].ToString()),
                                inicio = int.Parse(reader["inicio"].ToString()),
                                intervalo = int.Parse(reader["intervalo"].ToString()),
                                formato = reader["formato"].ToString(),
                                prefixo = reader["prefixo"].ToString()
                            });
                        }
                    }
                }
                con.Close();
            }
            return modelos;
        }

        public ModeloEtq GetModelo(int id)
        {
            ModeloEtq modelo = null;
            using (SqlConnection con = new SqlConnection(str_con))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Modelo WHERE Id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            modelo =
                            new ModeloEtq
                            {
                                id = int.Parse(reader["Id"].ToString()),
                                etiqueta = EtiquetaDAO.getEDAO().GetEtiqueta(int.Parse(reader["Id_etiqueta"].ToString())),
                                nome = reader["nome"].ToString(),
                                fonte_barcode = reader["fonte_barcode"].ToString(),
                                fonte_legenda = reader["fonte_legenda"].ToString(),
                                tam_font_bc = byte.Parse(reader["tam_font_bc"].ToString()),
                                tam_font_leg = byte.Parse(reader["tam_font_leg"].ToString()),
                                conteudo = reader["conteudo"].ToString(),
                                tipo_papel = reader["tipo_papel"].ToString(),
                                quantidade = int.Parse(reader["quantidade"].ToString()),
                                inicio = int.Parse(reader["inicio"].ToString()),
                                intervalo = int.Parse(reader["intervalo"].ToString()),
                                formato = reader["formato"].ToString(),
                                prefixo = reader["prefixo"].ToString()
                            };
                        }
                    }
                }
                con.Close();
            }
            return modelo;
        }

        public bool AtualizaContador(int id, int quantidade)
        {
            using (SqlConnection con = new SqlConnection(str_con))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Modelo SET quantidade = @QTD WHERE Id = @id", con))
                {
                    command.Parameters.AddWithValue("@QTD", quantidade);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            return true;
        }
    }
}
