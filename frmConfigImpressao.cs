using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Modelo;
using Controle;
using System.Text.RegularExpressions;

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
                    this.txtTFonteNome.Text = string.Empty;
                    this.txtFonteNome.Text = string.Empty;
                }
                else
                {
                    this.txtTFonteNome.Text = this.fntDialog.Font.Size.ToString();
                    this.txtFonteNome.Text = this.fntDialog.Font.Name;
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
            if (this.ddlImpressao.SelectedIndex == 0)
            {
                MessageBox.Show("Não é permitido excluir este modelo!\nModelo padrão do sistema!", "Modelos de Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DialogResult = MessageBox.Show("Deseja realmente excluir o modelo " + this.ddlImpressao.Text + " ?", "Modelos de Impressão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ///Solicita confirmação
                if (DialogResult == DialogResult.Yes)
                    ExcluirModelo(this.ddlImpressao.SelectedIndex);
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
            if (this.ddlImpressao.SelectedIndex == 0)
                return;
            try
            {
                this.mod = ModeloDAO.getMDAO().GetModelo(this.ddlImpressao.SelectedIndex);
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
            this.txtTFonteBarCode.Text = mod.tam_font_bc.ToString();
            this.txtTFonteNome.Text = mod.tam_font_leg.ToString();
            this.txtFonteNome.Text = mod.fonte_legenda;

            ///Gerador
            this.txtInicio.Text = mod.inicio.ToString();
            this.txtFormato.Text = mod.formato;
            this.txtIntervalo.Text = mod.intervalo.ToString();
            this.txtPrefixo.Text = mod.prefixo;

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
            if (mod.conteudo.Equals(StaticVars.CONTEUDO_BL))
                this.ddlConteudo.SelectedIndex = 0;
            else
                this.ddlConteudo.SelectedIndex = 1;

            this.ddlFonteCodigo.Items.Insert(0, StaticVars.FONTE_CODE128);
            this.ddlFonteCodigo.Items.Insert(1, StaticVars.FONTE_3OF9);
            this.ddlFonteCodigo.Items.Insert(2, StaticVars.FONTE_3OF9EXTENDED);

            switch (mod.fonte_barcode)
            {
                case StaticVars.FONTE_CODE128:
                    this.ddlFonteCodigo.SelectedIndex = 0;
                    break;

                case StaticVars.FONTE_3OF9:
                    this.ddlFonteCodigo.SelectedIndex = 1;
                    break;

                default:
                    this.ddlFonteCodigo.SelectedIndex = 2;
                    break;
            }
        }

        /// <summary>
        /// salva nas vars e insere/altera no banco
        /// </summary>
        private void SalvarModelo(string modelo)
        {   
            //verifica campos vazios
            if (this.txtInicio.Text.Trim().Equals("") || this.txtIntervalo.Text.Trim().Equals("") || 
                this.txtFormato.Text.Trim().Equals("") || this.ddlImpressao.Text.Trim().Equals("") ||
                this.txtTFonteBarCode.Text.Trim().Equals("") || this.txtTFonteNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Dados inválidos!\nHá campo(s) em branco.", "Modelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //verifica tipos numéricos INTEIROS
            Regex regex = new Regex("^[0-9]*$");
            if (!regex.IsMatch(this.txtTFonteBarCode.Text.Trim()) ||
                !regex.IsMatch(this.txtTFonteNome.Text.Trim()) ||
                !regex.IsMatch(this.txtInicio.Text.Trim()) ||
                !regex.IsMatch(this.txtIntervalo.Text.Trim()))
            {
                MessageBox.Show("Dados preenchidos não são do tipo Inteiro!", "Campos Numéricos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //verifica se a sequência não é 0
            if (int.Parse(this.txtIntervalo.Text.Trim()) == 0)
            {
                MessageBox.Show("Dados de sequência inválidos!\nCom zero a sequência não pode ser gerada!", "Sequencial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ModeloEtq mod = new ModeloEtq();
            mod.nome = this.ddlImpressao.Text;
            mod.fonte_barcode = this.ddlFonteCodigo.SelectedText;
            mod.fonte_legenda = this.txtTFonteNome.Text.Trim();
            mod.tam_font_bc = byte.Parse(this.txtTFonteBarCode.Text.Trim());
            mod.tam_font_leg = byte.Parse(this.txtTFonteNome.Text.Trim());
            mod.etiqueta = EtiquetaDAO.getEDAO().GetEtiqueta(this.ddlEtiqueta.SelectedIndex);
            mod.inicio = int.Parse(this.txtInicio.Text.Trim());
            mod.intervalo = int.Parse(this.txtIntervalo.Text.Trim());
            mod.formato = this.txtFormato.Text.Trim();
            mod.prefixo = this.txtPrefixo.Text.Trim();

            //Atualizar modelo?
            if (this.ddlImpressao.Text.Trim().Equals(this.mod.nome))
            {      
                DialogResult = MessageBox.Show("Deseja realmente alterar o modelo " + this.mod.nome + " ?", "Etiquetas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    //update
                    MessageBox.Show("Modelo " + this.mod.nome + " alterado com sucesso!", "Etiquetas");
                    return;
                }
                else
                    return;
            }
            try
            {
                //salvar novo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Modelo " + mod.nome + " salvo com sucesso!", "Modelo");
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
        private void ExcluirModelo(int idModelo)
        {
            try
            {
                bool excluiu = false;
                excluiu = ModeloDAO.getMDAO().ExcluirModelo(idModelo);

                if (excluiu == false)
                    throw new Exception("Não foi possível excluir o Modelo selecionado.");
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
        /// Se o modelo for CONTINUO
        /// os tamanhos são outros
        /// fora dos padrões,
        /// então SUGERE-SE os tamanhos
        /// relativos
        /// </summary>
        private void txtTFonteBarCode_MouseHover(object sender, EventArgs e)
        {
            if(this.mod.tipo_papel.Equals("Contínuo"))
                tltTBarcode.Show("Tamanho sugerido aproximadamente o dobro\nda altura da etiqueta em milímetros.", this.txtTFonteBarCode);
        }

        private void txtTFonteNome_MouseHover(object sender, EventArgs e)
        {
            if(this.mod.tipo_papel.Equals("Contínuo"))
                tltTNome.Show("Tamanho sugerido aproximadamente metade\ndas unidades a mais do que o padrão.",this.txtTFonteNome);
        }

        private void lblTFonteBarCode_MouseHover(object sender, EventArgs e)
        {
            if (this.mod.tipo_papel.Equals("Contínuo"))
                tltTBarcode.Show("Tamanho sugerido aproximadamente o dobro\nda altura da etiqueta em milímetros.", this.lblTFonteBarCode);
        }

        private void lblTFonteNome_MouseHover(object sender, EventArgs e)
        {
            if (this.mod.tipo_papel.Equals("Contínuo"))
                tltTNome.Show("Tamanho sugerido aproximadamente metade\ndas unidades a mais do que o padrão.", this.lblTFonteNome);
        }
    }
}
