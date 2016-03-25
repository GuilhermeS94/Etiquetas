using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloEtq
    {
        public int id;
        public Etiqueta etiqueta;
        public string nome;
        public string fonte_barcode;
        public string fonte_legenda;
        public byte tam_font_bc;
        public byte tam_font_leg;
        public string conteudo;
        public string tipo_papel;
        public int inicio;
        public int intervalo;
        public string formato;
        public string prefixo;
        public int quantidade;
    }
}
