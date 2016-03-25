using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e2Etiquetas
{
    public partial class FrmCont : Form
    {
        ConEtq ce = new ConEtq();
        private ListView lvw;

        public FrmCont()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrecarga:
        /// Passar o list view como param
        /// para listar a qtde de etq
        /// </summary>
        public FrmCont(ListView lvw)
        {
            InitializeComponent();
            this.lvw = lvw;
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
                ce.PreencheVIew();
                ///antes de tudo limpa o que já esta no listview
                lvw.Items.Clear();
                Dados.sNome.Clear();
                Dados.sCodigo.Clear();
                lvw.View = View.Details;
                lvw.CheckBoxes = true;

                int contador = 0;
                int qntEtq = 0;
                int cod = Dados.inicio;

                while (qntEtq < Dados.contETQ)
                {
                    Dados.sNome.Add(Dados.prefixo + string.Format("{0:" + Dados.formato + ".##}", cod));
                    Dados.sCodigo.Add(Dados.sNome[contador]);
                    ListViewItem list = new ListViewItem(Dados.sNome[contador]);
                    list.SubItems.Add(Dados.sNome[contador]);
                    lvw.Items.Add(list);
                    cod = cod + Dados.inter;
                    contador++;
                    qntEtq++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gerar as etiquetas!\n" + ex.Message, "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; ;
            }
        }

        /// <summary>
        /// Load
        /// </summary>
        private void FrmCont_Load(object sender, EventArgs e)
        {
            this.txtQtd.Text = Dados.contETQ.ToString();
        }

        /// <summary>
        /// Validação e preenchimento
        /// </summary>
        private void Validar() 
        {
            Dados.contETQ = int.Parse(this.txtQtd.Text.Trim());

            if (string.IsNullOrEmpty(this.txtQtd.Text.Trim()) || int.Parse(this.txtQtd.Text.Trim()) == 0)
            {
                MessageBox.Show("Dados Inválidos!", "Contador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((Dados.contETQ - Dados.inicio) > 10000)
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
