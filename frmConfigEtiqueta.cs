using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace e2Etiquetas
{
    public partial class frmConfigEtiqueta : Form
    {
        /// Parametro para o form
        /// de modelos para impressão
        private ComboBox cmbb;

        private string update;
        private string etqInicial;

        ///variavel que controla
        ///o desenho da pagina
        public static string porta;
        List<string> Tpapel = new List<string>();

        ///Vars do banco
        ConEtq ce = new ConEtq();

        /// construtor com parametro
        /// ComboBox para atualizar
        /// a ComboBox do form(pai) que o chama
        public frmConfigEtiqueta(ComboBox cmbb)
        {
            InitializeComponent();
            this.cmbb = cmbb;
        }

        public frmConfigEtiqueta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblFormato_Click(object sender, EventArgs e)
        {
            if (this.ddlTipoPapel.DroppedDown == false)
                this.ddlTipoPapel.DroppedDown = true;
            else
                this.ddlTipoPapel.DroppedDown = false;
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblEtqVert_Click(object sender, EventArgs e)
        {
            this.txtNumV.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblEtqHor_Click(object sender, EventArgs e)
        {
            this.txtNumH.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblLargEtq_Click(object sender, EventArgs e)
        {
            this.txtTamH.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblAltEtq_Click(object sender, EventArgs e)
        {
            this.txtTamV.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblMargEsq_Click(object sender, EventArgs e)
        {
            this.txtMargemE.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblMargSup_Click(object sender, EventArgs e)
        {
            this.txtMargemT.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblEspcCol_Click(object sender, EventArgs e)
        {
            this.txtEspCol.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblEspLin_Click(object sender, EventArgs e)
        {
            this.txtEspLin.Focus();
        }

        /// <summary>
        /// Load
        /// </summary>
        private void frmConfigEtiqueta_Load(object sender, EventArgs e)
        {
            try
            {
                //Tpapel.Add("A4");
                //Tpapel.Add("Carta");
                //Tpapel.Add("Contínuo");
                //ce.PreencheEtq();
                //PreencheDDL();
                //ce.PreencheEtiqueta();
                //PreencheCampos(Dados.etiqueta);
                //etqInicial = Dados.etiqueta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Troca tipo do papel
        /// troca a emulação
        /// </summary>
        private void ddlTipoPapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dados.papel = this.ddlTipoPapel.Text;
            DesenhaPapel();
        }

        /// <summary>
        /// Salvar uma nova etiqueta ou
        /// alterar um ja existente
        /// </summary>
        private void tbtnSalvar_Click(object sender, EventArgs e)
        {
            ///Validações campos em branco
            if (string.IsNullOrEmpty(this.ddlModelo.Text.Trim()) || string.IsNullOrEmpty(this.txtEspCol.Text.Trim()) || string.IsNullOrEmpty(this.txtEspLin.Text.Trim())
                || string.IsNullOrEmpty(this.txtMargemE.Text.Trim()) || string.IsNullOrEmpty(this.txtMargemT.Text.Trim()) || string.IsNullOrEmpty(this.txtNumH.Text.Trim())
                || string.IsNullOrEmpty(this.txtNumV.Text.Trim()) || string.IsNullOrEmpty(this.txtTamH.Text.Trim()) || string.IsNullOrEmpty(this.txtTamV.Text.Trim())) 
            {
                MessageBox.Show("Existe campos em branco ou nulo!","Etiqueta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
                        
            ///Verifica se não é um das etiquetas do sistema
            if ((Dados.IDEtq >= 1 && Dados.IDEtq <= 30 ) && this.ddlModelo.Text == Dados.etiqueta)
            {
                MessageBox.Show("Não é permitido alteração ou exclusão deste modelo!\nModelo padrão do sistema!", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                SalvarModelo(this.ddlModelo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar sua etiqueta!\n" + ex.Message, "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Excluir
        /// </summary>
        private void tbtnExcluir_Click(object sender, EventArgs e)
        {
            ///Verifica se não é um das etiquetas do sistema
            if ((Dados.IDEtq >= 1 && Dados.IDEtq <= 30) && this.ddlModelo.Text == Dados.etiqueta)
            {
                MessageBox.Show("Não é permitido alteração ou exclusão deste modelo!\nModelo padrão do sistema!", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DialogResult = MessageBox.Show("Deseja realmente excluir a etiqueta " + this.ddlModelo.Text + " ?", "Etiquetas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                    DeletarModelo(this.ddlModelo.Text);
                else
                    MessageBox.Show("Operação cancelada!", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir a etiqueta " + this.ddlModelo.Text + " !\n" + ex.Message, "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Atualizar a emulação
        /// </summary>
        private void tbtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //ce.PreencheEtq();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Etiqueta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// antes de fechar devolve os parametros ao frmConfigImpressao
        /// </summary>
        private void frmConfigEtiqueta_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmbb.DataSource = null;
            cmbb.Items.Clear();
            try
            {
                //ce.PreencheEtq();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbb.DataSource = Dados.etiquetas;
            ///Se estiver vazio retorne com o mesmo valor
            ///quando este form foi aberto
            if (string.IsNullOrEmpty(this.ddlModelo.Text))
            {
                etqInicial = "Pimaco 3080/3180";
                this.ddlModelo.SelectedItem = etqInicial;
                Dados.etiqueta = etqInicial;
                return;
            }

            Dados.etiqueta = this.ddlModelo.Text;
        }

        /// <summary>
        /// Salvar uma nova etiqueta ou
        /// Atualizar uma outra
        /// </summary>
        private void SalvarModelo(string modelo)
        {
            ///Converte para double e formata a string
            Dados.papel = this.ddlTipoPapel.Text;
            Dados.DistH = float.Parse(string.Format("{00:0.00}", Convert.ToDouble(this.txtEspCol.Text.Replace(".", ","))));
            Dados.DistV = float.Parse(string.Format("{00:0.00}", Convert.ToDouble(this.txtEspLin.Text.Replace(".", ","))));
            Dados.MargemE = float.Parse(string.Format("{0:0.00}", Convert.ToDouble(this.txtMargemE.Text.Replace(".", ","))));
            Dados.MargemT = float.Parse(string.Format("{0:0.00}", Convert.ToDouble(this.txtMargemT.Text.Replace(".", ","))));
            Dados.NumH = Convert.ToInt32(this.txtNumH.Text);
            Dados.NumV = Convert.ToInt32(this.txtNumV.Text);
            Dados.TamH = float.Parse(string.Format("{0:0.00}", Convert.ToDouble(this.txtTamH.Text.Replace(".", ","))));
            Dados.TamV = float.Parse(string.Format("{0:0.00}", Convert.ToDouble(this.txtTamV.Text.Replace(".", ","))));            
            Dados.etiqueta = modelo;

            ///Verify if is update or save
            if (this.ddlModelo.Text == update)
            {                
                DialogResult = MessageBox.Show("Deseja realmente alterar a etiqueta " + this.ddlModelo.Text + " ?", "Etiquetas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        //ce.AtualizaEtiqueta();
                        //MessageBox.Show("Etiqueta " + Dados.etiqueta + " alterada com sucesso!", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        /////atualiza as DownLists
                        //this.ddlTipoPapel.DataSource = null;
                        //this.ddlModelo.DataSource = null;
                        //ce.PreencheEtq();
                        PreencheDDL();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            ///End update

            try
            {
                ///Salvar
                //ce.SalvaEtiqueta();
                /////atualiza as DownLists
                //this.ddlTipoPapel.DataSource = null;
                //this.ddlModelo.DataSource = null;
                //ce.PreencheEtq();
                PreencheDDL();

                MessageBox.Show("Etiqueta " + modelo + " salva com sucesso!", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        /// <summary>
        /// Excluir a etiqueta
        /// </summary>
        private void DeletarModelo(string modelo)
        {
            try
            {
                //ce.DeletaEtiqueta();

                /////atualiza as DownLists
                //this.ddlTipoPapel.DataSource = null;
                //this.ddlModelo.DataSource = null;
                //ce.PreencheEtq();
                PreencheDDL();

                MessageBox.Show("Modelo " + modelo + " exluído com sucesso!", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Preenche as DownLists
        /// </summary>
        private void PreencheDDL()
        {
            this.ddlModelo.DataSource = Dados.etiquetas;
            this.ddlModelo.SelectedItem = Dados.etiqueta;
            this.ddlTipoPapel.DataSource = Tpapel;
            this.ddlTipoPapel.SelectedItem = Dados.papel;
        }

        /// <summary>
        /// Emulação do papel
        /// </summary>
        private void DesenhaPapel()
        {
            ///setando as unidades
            this.pbPagina.CreateGraphics().PageUnit = GraphicsUnit.Millimeter;
            this.pbSombra.CreateGraphics().PageUnit = GraphicsUnit.Millimeter;

            ///Configurar tamanho do picturebox de acordo com tipo do papel            
            switch (this.ddlTipoPapel.Text)
            {
                case "A4":
                    this.pbPagina.Width = 210;
                    this.pbPagina.Height = 297;
                    this.pbSombra.Width = 210;
                    this.pbSombra.Height = 297;
                    this.pbPagina.Scale(1.15f);
                    this.pbSombra.Scale(1.15f);
                    this.pbPagina.Location = new Point(12, 19);
                    this.pbSombra.Location = new Point(18, 26);
                    break;

                case "Carta":
                    this.pbPagina.Width = 216;
                    this.pbPagina.Height = 280;
                    this.pbSombra.Width = 216;
                    this.pbSombra.Height = 280;
                    this.pbPagina.Scale(1.15f);
                    this.pbSombra.Scale(1.15f);
                    this.pbPagina.Location = new Point(12, 19);
                    this.pbSombra.Location = new Point(18, 26);
                    break;

                case "Contínuo":
                    this.pbPagina.Width = 110;
                    this.pbPagina.Height = 280;
                    this.pbSombra.Width = 110;
                    this.pbSombra.Height = 280;
                    this.pbPagina.Scale(1.15f);
                    this.pbSombra.Scale(1.15f);
                    this.pbPagina.Location = new Point(12, 19);
                    this.pbSombra.Location = new Point(18, 26);
                    break;

                default:
                    this.pbPagina.Width = 200;
                    this.pbPagina.Height = 300;
                    this.pbSombra.Width = 200;
                    this.pbSombra.Height = 300;
                    break;
            }
        }

        /// <summary>
        /// Preenche os campos recebendo o parametro da DownList
        /// </summary>
        private void PreencheCampos(string etiqueta)
        {
            this.txtEspCol.Text = string.Format("{00:0.00}", Convert.ToDouble(Dados.DistH));
            this.txtEspLin.Text = string.Format("{00:0.00}", Convert.ToDouble(Dados.DistV));
            this.txtMargemE.Text = string.Format("{00:0.00}", Convert.ToDouble(Dados.MargemE));
            this.txtMargemT.Text = string.Format("{00:0.00}", Convert.ToDouble(Dados.MargemT));
            this.txtNumH.Text = Dados.NumH.ToString();
            this.txtNumV.Text = Dados.NumV.ToString();
            this.txtTamH.Text = string.Format("{00:0.00}", Convert.ToDouble(Dados.TamH));
            this.txtTamV.Text = string.Format("{00:0.00}", Convert.ToDouble(Dados.TamV));
            Etiqueta();
        }

        /// <summary>
        /// Configura o tamanho das etiquetas
        /// </summary>
        private void Etiqueta()
        {
            ///tamanho em mm
            int x = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtMargemE.Text)));
            int y = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtMargemT.Text)));
            int EspCol = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtEspCol.Text)));
            int EspLin = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtEspLin.Text)));
            Dados.lrect.Clear();

            ///desenhar as etiquetas
            this.pbPagina.Image = new Bitmap(283, 387);
            Graphics g = Graphics.FromImage(this.pbPagina.Image);
            Pen pen = new Pen(Color.Black, 1);
            g.PageUnit = GraphicsUnit.Millimeter;
            g.PageScale = 0.3f;

            for (int i = 0; i < Convert.ToInt32(this.txtNumH.Text); i++)
            {

                Rectangle rec = new Rectangle();

                ///posição
                rec.X = x;

                rec.Y = y;

                ///tamanho em mm
                rec.Width = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtTamH.Text)));
                rec.Height = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtTamV.Text)));

                Dados.lrect.Add(rec);

                ///declara
                g.DrawRectangle(pen, rec);
                y += rec.Height + EspLin;

                for (int j = 0; j < (Convert.ToInt32(this.txtNumV.Text) - 1); j++)
                {
                    rec.X = x;
                    rec.Y = y;

                    ///tamanho em mm
                    rec.Width = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtTamH.Text)));
                    rec.Height = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtTamV.Text)));

                    ///declara
                    g.DrawRectangle(pen, rec);
                    ///incrementa a coluna
                    y += rec.Height + EspLin;
                    ///copia o rect para o array
                    Dados.lrect.Add(rec);
                }
                ///incrementa a linha e reseta y
                x += rec.Width + EspCol;
                y = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.txtMargemT.Text)));

            }            
            ///desenha
            g.Dispose();
            this.pbPagina.Invalidate();           
        }

        /// <summary>
        /// Troca o nome da etiqueta
        /// refaz emulação
        /// </summary>
        private void ddlModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ddlModelo.Text))
                this.ddlModelo.SelectedItem = Dados.etiqueta;

            update = this.ddlModelo.Text;
            Dados.etiqueta = this.ddlModelo.Text;
            try
            {
                //ce.PreencheEtiqueta();
                //PreencheCampos(this.ddlModelo.Text);
                //ce.GetIDEtq();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
