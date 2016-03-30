using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Modelo;
using Controle;

namespace e2Etiquetas
{
    public partial class frmConfigImpressao : Form
    {
        List<string> conteudos = new List<string>();
        List<string> fonteBC = new List<string>();
        private ComboBox cmbb;
        ConEtq ce = new ConEtq();
        public string update;
        private string mdlInicial;

        private ModeloEtq mod;
        private Etiqueta etq;

        /// construtor com parametro
        /// ComboBox para atualizar
        /// a ComboBox do form(pai) que o chama
        public frmConfigImpressao(ComboBox cmbb)
        {
            InitializeComponent();
            this.cmbb = cmbb;
        }

        public frmConfigImpressao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblModeloImp_Click(object sender, EventArgs e)
        {
            if (ddlImpressao.DroppedDown == false)
                this.ddlImpressao.DroppedDown = true;
            else
                this.ddlImpressao.DroppedDown = false;
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblModeloEti_Click(object sender, EventArgs e)
        {
            if (ddlEtiqueta.DroppedDown == false)
                this.ddlEtiqueta.DroppedDown = true;
            else
                this.ddlEtiqueta.DroppedDown = false;
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblCod_Click(object sender, EventArgs e)
        {
            if (this.ddlFonteCodigo.DroppedDown == false)
                this.ddlFonteCodigo.DroppedDown = true;
            else
                this.ddlFonteCodigo.DroppedDown = false;
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblTFonteBarCode_Click(object sender, EventArgs e)
        {
            this.txtTFonteBarCode.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblTFonteNome_Click(object sender, EventArgs e)
        {
            this.txtTFonteNome.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblConteudo_Click(object sender, EventArgs e)
        {
            if (this.ddlConteudo.DroppedDown == false)
                this.ddlConteudo.DroppedDown = true;
            else
                this.ddlConteudo.DroppedDown = false;
        }
        
        /// <summary>
        /// chama o Frm das Etiquetas passando a 
        /// DownList como parâmetro
        /// </summary>
        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmConfigEtiqueta f = new frmConfigEtiqueta(this.ddlEtiqueta);
            f.ShowDialog();
            this.ddlEtiqueta.SelectedItem = Dados.etiqueta;
        }

        /// <summary>
        /// Load
        /// </summary>
        private void frmConfigImpressao_Load(object sender, EventArgs e)
        {
            try
            {
                this.mod = ModeloDAO.getMDAO().GetModelo(this.cmbb.SelectedIndex);
                PreencheCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modelos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Font dialog
        /// </summary>
        private void btnFonte_Click(object sender, EventArgs e)
        {
            ///Abre FontDialog, se pressionar OK
            if (this.fntDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ///verifica o tamanho
                if (this.fntDialog.Font.SizeInPoints < 9.75 || this.fntDialog.Font.SizeInPoints > 72)
                {
                    MessageBox.Show("O tamanho da fonte deve estar entre 10 e 72 pontos!", "Fontes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTFonteNome.Text = "";
                    this.txtFonteNome.Text = "";
                }
                else
                {
                    this.txtTFonteNome.Text = this.fntDialog.Font.Size.ToString();
                    this.txtFonteNome.Text = "Arial Narrow";
                }
            }
        }

        /// <summary>
        /// salvar/alterar Modelo
        /// </summary>
        private void tbtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarModelo(this.ddlImpressao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar seu modelo!\n" + ex.Message, "Modelos de Impressão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Deletar modelo
        /// </summary>
        private void tbtnExcluir_Click(object sender, EventArgs e)
        {
            if (Dados.IDModelo == 1 && this.ddlImpressao.Text == "Modelo 1")
            {
                MessageBox.Show("Não é permitido excluir este modelo!\nModelo padrão do sistema!", "Modelos de Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DialogResult = MessageBox.Show("Deseja realmente excluir o modelo " + this.ddlImpressao.Text + " ?", "Modelos de Impressão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ///Solicita confirmação
                if (DialogResult == DialogResult.Yes)
                    ExcluirModelo(this.ddlImpressao.Text);
                else
                    MessageBox.Show("Operação cancelada!", "Modelos de Impressão",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o modelo " + this.ddlImpressao.Text + " !\n" + ex.Message, "Modelos de Impressão");
            }
        }

        /// <summary>
        /// Troca o modelo repreenche as variaveis
        /// </summary>
        private void ddlImpressao_SelectedIndexChanged(object sender, EventArgs e)
        {
            update = this.ddlImpressao.Text;
            Dados.modelo = this.ddlImpressao.Text;
            try
            {
                //ce.PreencheImpressao(this.ddlImpressao.Text);
                //PreencheCampos(this.ddlImpressao.Text);
                //ce.GetIDMdl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        
        /// <summary>
        /// preenche as DownLists
        /// </summary>
        public void PreencheDDL()
        {
            this.ddlEtiqueta.DataSource = Dados.etiquetas;
            this.ddlEtiqueta.SelectedItem = Dados.etiqueta;

            this.ddlImpressao.DataSource = Dados.modelos;

            ///Soment Cod, ou Cod e Nome
            conteudos.Clear();
            conteudos.Add("Codigo e Nome");
            conteudos.Add("Somente Codigo");
            this.ddlConteudo.DataSource = conteudos;
            this.ddlConteudo.SelectedItem = Dados.conteudo;

            ///BarCode Fontes
            fonteBC.Clear();
            fonteBC.Add("Free 3 of 9 Extended");
            fonteBC.Add("Code128A");
            fonteBC.Add("IDAutomationHC39M");
            this.ddlFonteCodigo.DataSource = fonteBC;
            this.ddlFonteCodigo.SelectedItem = Dados.FonteBC;
        }

        /// <summary>
        /// Le vars preenchida do banco
        /// </summary>
        private void PreencheCampos()
        {
            this.txtTFonteBarCode.Text = mod.tam_font_bc.ToString();// Dados.TamFonteBC.ToString();
            this.txtTFonteNome.Text = mod.tam_font_leg.ToString();// Dados.TamFonteNM.ToString();
            this.txtFonteNome.Text = mod.fonte_legenda;// Dados.FonteNM;          

            ///Gerador
            this.txtInicio.Text = mod.inicio.ToString();// Dados.inicio.ToString();
            this.txtFormato.Text = mod.formato;// Dados.formato;
            this.txtIntervalo.Text = mod.intervalo.ToString();// Dados.inter.ToString();
            this.txtPrefixo.Text = mod.prefixo;// Dados.prefixo;

            ///DDL's
            this.ddlEtiqueta.Items.Insert(0, StaticVars.ETIQUETA_DEFAULT);
            foreach (var etq in EtiquetaDAO.getEDAO().ListarEtiquetas())
            {
                this.ddlEtiqueta.Items.Insert(etq.id, etq.nome);
            }
            this.ddlEtiqueta.SelectedIndex = mod.etiqueta.id;

            this.ddlImpressao.Items.Insert(0, StaticVars.MODELO_DEFAULT);
            foreach (var modelo in ModeloDAO.getMDAO().ListarModelos())
            {
                this.ddlImpressao.Items.Insert(modelo.id, modelo.nome);
            }
            this.ddlImpressao.SelectedIndex = mod.id;

            this.ddlConteudo.Items.Insert(0, StaticVars.CONTEUDO_BL);
            this.ddlConteudo.Items.Insert(1, StaticVars.CONTEUDO_B);
            this.ddlConteudo.SelectedText = mod.conteudo;

            this.ddlFonteCodigo.Items.Insert(0, StaticVars.FONTE_CODE128);
            this.ddlFonteCodigo.Items.Insert(1, StaticVars.FONTE_3OF9);
            this.ddlFonteCodigo.Items.Insert(2, StaticVars.FONTE_3OF9EXTENDED);
            this.ddlFonteCodigo.SelectedText = mod.conteudo;
        }

        /// <summary>
        /// salva nas vars e insere/altera no banco
        /// </summary>
        private void SalvarModelo(string modelo)
        {
            Dados.modelo = modelo;
            Dados.FonteBC = this.ddlFonteCodigo.Text;
            Dados.FonteNM = this.txtFonteNome.Text;
            Dados.TamFonteBC = float.Parse(this.txtTFonteBarCode.Text.Replace(".", ","));
            Dados.TamFonteNM = float.Parse(this.txtTFonteNome.Text.Replace(".", ","));
            Dados.etiqueta = this.ddlEtiqueta.Text;
            ///Modelo - Gerador
            Dados.inicio = int.Parse(this.txtInicio.Text);
            Dados.inter = int.Parse(this.txtIntervalo.Text);
            Dados.formato = this.txtFormato.Text;
            Dados.prefixo = this.txtPrefixo.Text;

            ///verifica campos obrigatórios em branco            
            if (this.txtInicio.Text.Trim().Equals("") || this.txtIntervalo.Text.Trim().Equals("") || 
                this.txtFormato.Text.Trim().Equals("") || this.ddlImpressao.Text.Trim().Equals("") ||
                this.txtTFonteBarCode.Text.Trim().Equals("") || this.txtTFonteNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Dados inválidos!\nHá campo(s) em branco.", "Modelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(this.txtIntervalo.Text.Trim()) == 0)
            {
                MessageBox.Show("Dados de sequência inválidos!\nCom zero a sequência não pode ser gerada!", "Sequencial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ///Save or Updade?
            if (this.ddlImpressao.Text == update)
            {      
                DialogResult = MessageBox.Show("Deseja realmente alterar o modelo " + modelo + " ?", "Etiquetas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    ///atualiza
                    //ce.AtualizaModelo();
                    /////atualiza form
                    //this.ddlImpressao.DataSource = null;
                    //ce.PreencheModelo();
                    PreencheDDL();
                    ///informa usuário
                    MessageBox.Show("Modelo " + Dados.modelo + " alterado com sucesso!", "Etiquetas");
                    return;
                }
                else
                    return;
            }
            try
            {
                //ce.SalvaModelo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Modelo " + Dados.modelo + " salvo com sucesso!", "Modelo");
            this.ddlImpressao.DataSource = null;
            try
            {
                //ce.PreencheModelo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PreencheDDL();
        }

        /// <summary>
        /// o ID ja esta capturado é só deletar
        /// </summary>
        private void ExcluirModelo(string modelo)
        {
            try
            {
                //ce.DeletaModelo();
                //MessageBox.Show("Modelo " + modelo + " excluído com sucesso!", "Modelos de Impressão");
                //this.ddlImpressao.DataSource = null;
                //ce.PreencheModelo();
                PreencheDDL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        ///Form Gerador
        ///Vars e métodos que eram
        ///do form que gera o sequencial
        ///e o sequancial não gera mais arquivo .txt
        private void lblInicio_Click(object sender, EventArgs e)
        {
            this.txtInicio.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblFormato_Click(object sender, EventArgs e)
        {
            this.txtFormato.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblIntervalo_Click(object sender, EventArgs e)
        {
            this.txtIntervalo.Focus();
        }

        /// <summary>
        /// Foco no campo correspondente ao Label
        /// </summary>
        private void lblPrefixo_Click(object sender, EventArgs e)
        {
            this.txtPrefixo.Focus();
        }

        /// <summary>
        /// Troca o conteudo
        /// atualiza param
        /// </summary>
        private void ddlConteudo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///atualizar params
            Dados.conteudo = this.ddlConteudo.Text;
        }

        /// <summary>
        /// Troca etiqueta
        /// atualiza param
        /// </summary>
        private void ddlEtiqueta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ddlEtiqueta.Text))
                this.ddlEtiqueta.SelectedItem = Dados.etiqueta;

            ///atualizar params
            Dados.etiqueta = this.ddlEtiqueta.Text;
            try
            {
                //ce.GetIDEtq();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Se o modelo for CONTINUO
        /// os tamanhos são outros
        /// fora dos padrões,
        /// então SUGERE-SE os tamanhos
        /// relativos
        /// </summary>
        private void txtTFonteBarCode_MouseHover(object sender, EventArgs e)
        {
            if(Dados.papel == "Contínuo")
                tltTBarcode.Show("Tamanho sugerido aproximadamente o dobro\nda altura da etiqueta em milímetros.", this.txtTFonteBarCode);
        }

        private void txtTFonteNome_MouseHover(object sender, EventArgs e)
        {
            if(Dados.papel == "Contínuo")
                tltTNome.Show("Tamanho sugerido aproximadamente metade\ndas unidades a mais do que o padrão.",this.txtTFonteNome);
        }

        private void lblTFonteBarCode_MouseHover(object sender, EventArgs e)
        {
            if (Dados.papel == "Contínuo")
                tltTBarcode.Show("Tamanho sugerido aproximadamente o dobro\nda altura da etiqueta em milímetros.", this.lblTFonteBarCode);
        }

        private void lblTFonteNome_MouseHover(object sender, EventArgs e)
        {
            if (Dados.papel == "Contínuo")
                tltTNome.Show("Tamanho sugerido aproximadamente metade\ndas unidades a mais do que o padrão.", this.lblTFonteNome);
        }
    }
}
