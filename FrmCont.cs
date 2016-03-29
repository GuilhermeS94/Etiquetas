using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Modelo;
using Controle;

namespace e2Etiquetas
{
    public partial class FrmCont : Form
    {
        private ListView lvw;
        private int idModelo;
        private ModeloEtq mod;

        public FrmCont()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrecarga:
        /// Passar o list view como param
        /// para listar a qtde de etq
        /// </summary>
        public FrmCont(ListView lvw, int idModelo)
        {
            InitializeComponent();
            this.lvw = lvw;
            this.idModelo = idModelo;
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblQtd_Click(object sender, EventArgs e)
        {
            this.txtQtd.Focus();
        }

        private void tbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validações em quantidade e tipo de valor
        /// </summary>
        private void btnQtd_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Dados Inválidos!\n"+ex.Message, "Contador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Monta a string e lista a quantidade
        /// de etq
        /// </summary>
        public void Preencher()
        {
            try
            {
                ///antes de tudo limpa o que já esta no listview
                lvw.Items.Clear();
                lvw.View = View.Details;
                lvw.CheckBoxes = true;
                int cod = mod.inicio;
                int qnt = int.Parse(this.txtQtd.Text);
                string texto = string.Empty;
                ListViewItem list = null;
                for (int i = 0; i < qnt; i++)
                {
                    texto = string.Format("{0}{1:" + mod.formato + ".##}", mod.prefixo, cod);
                    list = new ListViewItem(texto);
                    lvw.Items.Add(list);
                    cod += mod.intervalo;
                }

                bool atualiza = ModeloDAO.getMDAO().AtualizaContador(mod.id, qnt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gerar as etiquetas!\n" + ex.Message, "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Load
        /// </summary>
        private void FrmCont_Load(object sender, EventArgs e)
        {
            mod = ModeloDAO.getMDAO().GetModelo(this.idModelo);
            this.txtQtd.Text = mod.quantidade.ToString();
        }

        /// <summary>
        /// Validação e preenchimento
        /// </summary>
        private void Validar() 
        {
            Regex regex = new Regex("^[0-9]*$");
            if(!regex.IsMatch(this.txtQtd.Text.Trim()))
            {
                MessageBox.Show("Dados Inválidos!", "Contador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (int.Parse(this.txtQtd.Text.Trim()) > 10000)
            {
                MessageBox.Show("O limite foi excedido!\nO sistema gera 10000 etiquetas por vez!", "Contador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtQtd.Text = string.Empty;
                return;
            }

            Preencher();
            this.Close();
        }

        /// <summary>
        /// Quando ENTER for pressionado
        /// </summary>
        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Validar();
        }

    }
}
