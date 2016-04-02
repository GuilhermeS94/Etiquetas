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

        public bool ExcluirModelo(int id)
        {
            using (SqlConnection con = new SqlConnection(str_con))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM Modelo WHERE Id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            return true;
        }

        public bool SalvarModelo(ModeloEtq mod)
        {
            using (SqlConnection con = new SqlConnection(str_con))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(@"INSERT INTO Modelo
                      (Id_etiqueta, nome, fonte_barcode, fonte_legenda, tam_font_bc, tam_font_leg,
                       conteudo, tipo_papel, inicio, intervalo, formato, prefixo)
                      VALUES
                      (@id_etq, @nome, @fonte_bc, @fonte_leg, @t_fonte_bc, @t_fonte_leg,
                       @conteudo, @t_papel, @inicio, @intervalo, @formato, @prefixo)",
                      con))
                {
                    command.Parameters.AddWithValue("@id_etq", mod.etiqueta.id);
                    command.Parameters.AddWithValue("@nome", mod.nome);
                    command.Parameters.AddWithValue("@fonte_bc", mod.fonte_barcode);
                    command.Parameters.AddWithValue("@fonte_leg", mod.fonte_legenda);
                    command.Parameters.AddWithValue("@t_fonte_bc", mod.tam_font_bc);
                    command.Parameters.AddWithValue("@t_fonte_leg", mod.tam_font_leg);
                    command.Parameters.AddWithValue("@conteudo", mod.conteudo);
                    command.Parameters.AddWithValue("@t_papel", mod.tipo_papel);
                    command.Parameters.AddWithValue("@inicio", mod.inicio);
                    command.Parameters.AddWithValue("@intervalo", mod.intervalo);
                    command.Parameters.AddWithValue("@formato", mod.formato);
                    command.Parameters.AddWithValue("@prefixo", mod.prefixo);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            return true;
        }

        public bool AtualizarModelo(ModeloEtq mod)
        {
            using (SqlConnection con = new SqlConnection(str_con))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(@"UPDATE Modelo SET Id_etiqueta = @id_etq,
                      nome = @nome, fonte_barcode = @fonte_bc, fonte_legenda = @fonte_leg,
                      tam_font_bc = @t_fonte_bc, tam_font_leg = @t_fonte_leg,
                      conteudo = @conteudo, tipo_papel = @t_papel, inicio = @inicio, intervalo = @intervalo,
                      formato = @formato, prefixo = @prefixo WHERE Id = @id", con))
                {
                    command.Parameters.AddWithValue("@id", mod.id);
                    command.Parameters.AddWithValue("@id_etq", mod.etiqueta.id);
                    command.Parameters.AddWithValue("@nome", mod.nome);
                    command.Parameters.AddWithValue("@fonte_bc", mod.fonte_barcode);
                    command.Parameters.AddWithValue("@fonte_leg", mod.fonte_legenda);
                    command.Parameters.AddWithValue("@t_fonte_bc", mod.tam_font_bc);
                    command.Parameters.AddWithValue("@t_fonte_leg", mod.tam_font_leg);
                    command.Parameters.AddWithValue("@conteudo", mod.conteudo);
                    command.Parameters.AddWithValue("@t_papel", mod.tipo_papel);
                    command.Parameters.AddWithValue("@inicio", mod.inicio);
                    command.Parameters.AddWithValue("@intervalo", mod.intervalo);
                    command.Parameters.AddWithValue("@formato", mod.formato);
                    command.Parameters.AddWithValue("@prefixo", mod.prefixo);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            return true;
        }
    }
}
