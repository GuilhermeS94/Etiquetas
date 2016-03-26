using System;
using System.Windows.Forms;
using System.Configuration;

namespace e2Etiquetas
{
    public class ConEtq : Dados
    {

        /// <summary>
        /// Preenche o array de etq
        /// </summary>
    //    public void PreencheEtq()
	   // {
    //        ConEtq.etiquetas.Clear();
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();

    //        dbManager.ExecuteReader("SELECT nm_etiqueta FROM etiqueta_tipo");
		  //  while(dbManager.DataReader.Read())
		  //  {
			 //   //Talvez precise do ToString()
    //            ConEtq.etiquetas.Add(dbManager.DataReader.GetString(0));
		  //  }

    //        dbManager.CloseReader();
    //        dbManager.Close();
	   // }

    //    //TODO MUDAR FORMA DE ACESSO AO BANCO
    //    //TODO MUDAR O NOME DAS TABELAS

    //    /// <summary>
    //    /// Preenche Array de Modelos
    //    /// </summary>
    //    public void PreencheModelo()
	   // {
    //        ConEtq.modelos.Clear();
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);
            

    //        dbManager.Open();
		  //  dbManager.ExecuteReader("SELECT nm_modelo FROM etiqueta_modelo");

    //        while (dbManager.DataReader.Read()) 
		  //  {
			 //   //Talvez precise do ToString()
    //            ConEtq.modelos.Add(dbManager.DataReader.GetString(0));
		  //  }

    //        dbManager.CloseReader();
    //        dbManager.Close();
	   // }

    //    /// <summary>
    //    /// Preenche o form de Modelos
    //    /// </summary>
    //    /// <param name="modelo"></param>
    //    public void PreencheImpressao(string modelo) 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteReader("SELECT id_modelo, fonte_barcode, fonte_nome, tam_fonte_bc, tam_fonte_nm, conteudo, nm_etiqueta, "+
		  //                    "inicio, intervalo, formato, prefixo, tipo_papel FROM etiqueta_modelo T1 "+
		  //                    "INNER JOIN etiqueta_tipo T2 on "+
    //                          "T1.id_etiqueta = T2.id_etiqueta "+
    //                          "WHERE nm_modelo = '"+ ConEtq.modelo +"'");


    //        while (dbManager.DataReader.Read())
    //        {
    //            ConEtq.FonteBC = dbManager.DataReader["fonte_barcode"].ToString();
    //            ConEtq.FonteNM = dbManager.DataReader["fonte_nome"].ToString();
    //            ConEtq.conteudo = dbManager.DataReader["conteudo"].ToString();
    //            ConEtq.TamFonteBC = float.Parse(dbManager.DataReader["tam_fonte_bc"].ToString());
    //            ConEtq.TamFonteNM = float.Parse(dbManager.DataReader["tam_fonte_nm"].ToString());
    //            ConEtq.etiqueta = dbManager.DataReader["nm_etiqueta"].ToString();
    //            ConEtq.IDModelo = int.Parse(dbManager.DataReader["id_modelo"].ToString());
    //            ConEtq.papel = dbManager.DataReader["tipo_papel"].ToString();
    //            ///Gerador
    //            ConEtq.inicio = int.Parse(dbManager.DataReader["inicio"].ToString());
    //            ConEtq.inter = int.Parse(dbManager.DataReader["intervalo"].ToString());
    //            ConEtq.formato = dbManager.DataReader["formato"].ToString();
    //            ConEtq.prefixo = dbManager.DataReader["prefixo"].ToString();
    //        }

    //        dbManager.CloseReader();
    //        dbManager.Close();

    //        GetIDEtq();
    //    }

    //    /// <summary>
    //    /// Preenche o form de Etiquetas
    //    /// </summary>
    //    public void PreencheEtiqueta() 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteReader("SELECT id_etiqueta, disth, distv, margeme, margemt, numh, numv, tamh, tamv FROM etiqueta_tipo "+
    //                          "WHERE nm_etiqueta = '" + ConEtq.etiqueta + "'");


    //        while (dbManager.DataReader.Read())
    //        {
    //            ConEtq.DistH = float.Parse(dbManager.DataReader["disth"].ToString());
    //            ConEtq.DistV = float.Parse(dbManager.DataReader["distv"].ToString());
    //            ConEtq.MargemE = float.Parse(dbManager.DataReader["margeme"].ToString());
    //            ConEtq.MargemT = float.Parse(dbManager.DataReader["margemt"].ToString());
    //            ConEtq.NumH = int.Parse(dbManager.DataReader["numh"].ToString());
    //            ConEtq.NumV = int.Parse(dbManager.DataReader["numv"].ToString());
    //            ConEtq.TamH = float.Parse(dbManager.DataReader["tamh"].ToString());
    //            ConEtq.TamV = float.Parse(dbManager.DataReader["tamv"].ToString());
    //            ConEtq.IDEtq = int.Parse(dbManager.DataReader["id_etiqueta"].ToString());
    //        }

    //        dbManager.CloseReader();
    //        dbManager.Close();
    //        frmConfigEtiqueta.porta = ConEtq.etiqueta;
    //    }

    //    /// <summary>
    //    /// Salvar uma nova etiqueta
    //    /// </summary>
    //    public void SalvaEtiqueta() 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteNonQuery("INSERT INTO etiqueta_tipo (disth, distv, margeme, margemt, nm_etiqueta, numh, numv, tamh, tamv) "+
    //                          "VALUES('" + ConEtq.DistH.ToString().Replace(",", ".") +
    //                          "','" + ConEtq.DistV.ToString().Replace(",", ".") +
    //                          "', '" + ConEtq.MargemE.ToString().Replace(",", ".") +
    //                          "', '" + ConEtq.MargemT.ToString().Replace(",", ".") +
    //                          "', '" + ConEtq.etiqueta + "', '" + ConEtq.NumH + "', '" + ConEtq.NumV +
    //                          "', '" + ConEtq.TamH.ToString().Replace(",", ".") +
    //                          "', '" + ConEtq.TamV.ToString().Replace(",", ".") + "')");

    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Atualizar uma etiqueta
    //    /// </summary>
    //    public void AtualizaEtiqueta() 
    //    {
    //        //IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteNonQuery("UPDATE etiqueta_tipo SET disth = '" + ConEtq.DistH.ToString().Replace(",", ".") + 
    //                          "', distv = '" + ConEtq.DistV.ToString().Replace(",", ".") +
    //                          "', margeme = '" + ConEtq.MargemE.ToString().Replace(",", ".") +
    //                          "', margemt = '" + ConEtq.MargemT.ToString().Replace(",", ".") +
    //                          "', nm_etiqueta = '" + ConEtq.etiqueta + "', numh = '" + ConEtq.NumH + "', numv ='" + ConEtq.NumV +
    //                          "', tamh = '" + ConEtq.TamH.ToString().Replace(",", ".") +
    //                          "', tamv = '" + ConEtq.TamV.ToString().Replace(",", ".") + "' " +
    //                          "WHERE id_etiqueta = '" + ConEtq.IDEtq + "'");

    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Excluir etiqueta
    //    /// </summary>
    //    public void DeletaEtiqueta() 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteNonQuery("DELETE FROM etiqueta_tipo WHERE id_etiqueta = '" + ConEtq.IDEtq + "'");

    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Salvar um novo Modelo para impressão
    //    /// </summary>
    //    public void SalvaModelo()
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteNonQuery("INSERT INTO etiqueta_modelo (id_etiqueta,nm_modelo,fonte_barcode,fonte_nome,tam_fonte_bc,tam_fonte_nm, "+
    //                          "Conteudo,tipo_papel,inicio,intervalo,formato,prefixo) " +
    //                          "VALUES ('" + ConEtq.IDEtq + "','" + ConEtq.modelo + "','" + ConEtq.FonteBC +
    //                          "','" + ConEtq.FonteNM + "','" + ConEtq.TamFonteBC.ToString().Replace(",", ".") +
    //                          "','" + ConEtq.TamFonteNM.ToString().Replace(",", ".") + "', '" + ConEtq.conteudo +
    //                          "','" + ConEtq.papel + "','" + ConEtq.inicio + "','" + ConEtq.inter + "','" + ConEtq.formato +
    //                          "','" + ConEtq.prefixo + "')");

    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Atualizar um Modelo
    //    /// </summary>
    //    public void AtualizaModelo()
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteNonQuery("UPDATE etiqueta_modelo SET id_etiqueta = '" + ConEtq.IDEtq + "', nm_modelo = '" + ConEtq.modelo +
    //                          "', fonte_barcode = '" + ConEtq.FonteBC + "', fonte_nome = '" + ConEtq.FonteNM +
    //                          "', tam_fonte_bc = '" + ConEtq.TamFonteBC.ToString().Replace(",", ".") +
    //                          "', tam_fonte_nm = '" + ConEtq.TamFonteNM.ToString().Replace(",",".") +
    //                          "', Conteudo = '" + ConEtq.conteudo + "', tipo_papel = '" + ConEtq.papel +
    //                          "', inicio = '" + ConEtq.inicio + "', intervalo = '" + ConEtq.inter +
    //                          "', formato = '" + ConEtq.formato + "', prefixo = '" + ConEtq.prefixo + "'" +
    //                          "WHERE id_modelo = '" + ConEtq.IDModelo + "'");

    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Deletar um Modelo
    //    /// </summary>
    //    public void DeletaModelo()
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteNonQuery("DELETE FROM etiqueta_modelo WHERE id_modelo = '" + ConEtq.IDModelo + "'");
            
    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Pegar o ID do Modelo
    //    /// </summary>
    //    public void GetIDMdl() 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteReader("SELECT id_modelo FROM etiqueta_modelo WHERE nm_modelo = '" + ConEtq.modelo + "'");


    //        while (dbManager.DataReader.Read())
    //        {
    //            ConEtq.IDModelo = int.Parse(dbManager.DataReader["id_modelo"].ToString());
    //        }

    //        dbManager.CloseReader();
    //        dbManager.Close();

    //        GetIDEtq();
    //    }

    //    /// <summary>
    //    /// Pegar o ID da Etiqueta
    //    /// </summary>
    //    public void GetIDEtq() 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteReader("SELECT id_etiqueta FROM etiqueta_tipo WHERE nm_etiqueta = '" + ConEtq.etiqueta + "'");


    //        while (dbManager.DataReader.Read())
    //        {
    //            ConEtq.IDEtq = int.Parse(dbManager.DataReader["id_etiqueta"].ToString());
    //        }

    //        dbManager.CloseReader();
    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Pega as medidas da etiqueta para o array de Rect
    //    /// </summary>
    //    public void PreencheRect() 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteReader("SELECT margeme, margemt, disth, distv, numh, numv, tamh, tamv FROM etiqueta_tipo "+
    //                          "WHERE id_etiqueta = '" + ConEtq.IDEtq + "'");


    //        while (dbManager.DataReader.Read())
    //        {
    //            ConEtq.DistH = float.Parse(dbManager.DataReader["disth"].ToString());
    //            ConEtq.DistV = float.Parse(dbManager.DataReader["distv"].ToString());
    //            ConEtq.MargemE = float.Parse(dbManager.DataReader["margeme"].ToString());
    //            ConEtq.MargemT = float.Parse(dbManager.DataReader["margemt"].ToString());
    //            ConEtq.NumH = int.Parse(dbManager.DataReader["numh"].ToString());
    //            ConEtq.NumV = int.Parse(dbManager.DataReader["numv"].ToString());
    //            ConEtq.TamH = float.Parse(dbManager.DataReader["tamh"].ToString());
    //            ConEtq.TamV = float.Parse(dbManager.DataReader["tamv"].ToString());
    //        }

    //        dbManager.CloseReader();
    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Preenche a lista de etq para imprimir
    //    /// </summary>
    //    public void PreencheVIew() 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteReader("SELECT inicio, formato, intervalo, prefixo FROM etiqueta_modelo " +
    //                          "WHERE id_modelo = '" + ConEtq.IDModelo + "'");


    //        while (dbManager.DataReader.Read())
    //        {
    //            ConEtq.inicio = int.Parse(dbManager.DataReader["inicio"].ToString());
    //            ConEtq.formato = dbManager.DataReader["formato"].ToString();
    //            ConEtq.inter = int.Parse(dbManager.DataReader["intervalo"].ToString());
    //            ConEtq.prefixo = dbManager.DataReader["prefixo"].ToString();
    //        }

    //        dbManager.CloseReader();
    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Atualizar Contador de etiquetas
    //    /// </summary>
    //    public void SalvaCont()
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteNonQuery("UPDATE etiqueta_modelo SET qtd_etiqueta = '"+ ConEtq.contETQ +"' "+
    //                          "WHERE id_modelo = '"+ ConEtq.IDModelo +"'");
            

    //        dbManager.ExecuteNonQuery("UPDATE etiqueta_modelo SET inicio = '" + (ConEtq.inicio + 1) + "' " +
    //                          "WHERE id_modelo = '" + ConEtq.IDModelo + "'");

    //        dbManager.Close();


    //    }

    //    /// <summary>
    //    /// Retorna o contador
    //    /// </summary>
    //    public void SelectCont()
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteReader("Select qtd_etiqueta FROM etiqueta_modelo " +
    //                          "WHERE id_modelo = '" + ConEtq.IDModelo + "'");

            
    //        while (dbManager.DataReader.Read())
    //        {
    //            ConEtq.contETQ = int.Parse(dbManager.DataReader["qtd_etiqueta"].ToString());
    //        }

    //        dbManager.CloseReader();
    //        dbManager.Close();
    //    }

    //    /// <summary>
    //    /// Tem as tabelas?
    //    /// </summary>
    //  /*  public void Verifica() 
    //    {
    //        IDBManager dbManager = new DBManager(tipoDb, conexao);

    //        dbManager.Open();
    //        dbManager.ExecuteReader("Select qtd_etiqueta FROM etiqueta_modelo " +
    //                          "WHERE id_modelo = '" + ConEtq.IDModelo + "'");


    //        while (dbManager.DataReader.Read())
    //        {
    //            ConEtq.contETQ = int.Parse(dbManager.DataReader["qtd_etiqueta"].ToString());
    //        }

    //        dbManager.CloseReader();
    //        dbManager.Close();
    //    }
    //*/
    }
}
