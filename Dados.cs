using System.Collections.Generic;
using System.Drawing;

namespace e2Etiquetas
{
    public class Dados
    {
        ///Form Main
        public string[] lines;
        public static string conteudo;
        public static string modelo;
        public static string impressora;
        public static List<string> sNome = new List<string>();
        public static List<string> sCodigo = new List<string>();
        public static List<string> chk = new List<string>();
        public static List<Rectangle> lrect = new List<Rectangle>();

        ///Form Modelo
        public static string FonteBC;
        public static string FonteNM;
        public static float TamFonteBC;
        public static float TamFonteNM;
        public static string etiqueta;

        ///Modelo - Gerador
        public int i;
        public static int inicio;

        //public static int fim;
        public static int contETQ;
        public static int inter;
        public static string formato;
        public static string prefixo;

        ///Form Etiquetas
        public static float DistH;
        public static float DistV;
        public static float MargemE;
        public static float MargemT;
        public static int NumH;
        public static int NumV;
        public static float TamH;
        public static float TamV;
        public static string papel;
        public static string erro;

        ///List frmConfigEtiqueta efrmConfigImpressao
        public static List<string> etiquetas = new List<string>();

        ///List frmConfigImpressa e frmMain
        public static List<string> modelos = new List<string>();

        public static int IDEtq;
        public static int IDModelo;
        
    }
}
