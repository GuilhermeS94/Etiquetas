namespace e2Etiquetas
{
    partial class frmConfigImpressao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigImpressao));
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.lblModeloImp = new System.Windows.Forms.Label();
            this.lblModeloEti = new System.Windows.Forms.Label();
            this.ddlEtiqueta = new System.Windows.Forms.ComboBox();
            this.ddlImpressao = new System.Windows.Forms.ComboBox();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.gbFonte = new System.Windows.Forms.GroupBox();
            this.btnFonte = new System.Windows.Forms.Button();
            this.lblTFonteNome = new System.Windows.Forms.Label();
            this.lblTFonteBarCode = new System.Windows.Forms.Label();
            this.txtTFonteNome = new System.Windows.Forms.TextBox();
            this.txtTFonteBarCode = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtFonteNome = new System.Windows.Forms.TextBox();
            this.ddlFonteCodigo = new System.Windows.Forms.ComboBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.gbImpressao = new System.Windows.Forms.GroupBox();
            this.ddlConteudo = new System.Windows.Forms.ComboBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.fntDialog = new System.Windows.Forms.FontDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSair = new System.Windows.Forms.ToolStripButton();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.txtPrefixo = new System.Windows.Forms.TextBox();
            this.lblPrefixo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.tltTBarcode = new System.Windows.Forms.ToolTip(this.components);
            this.tltTNome = new System.Windows.Forms.ToolTip(this.components);
            this.gbConfig.SuspendLayout();
            this.gbFonte.SuspendLayout();
            this.gbImpressao.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.lblModeloImp);
            this.gbConfig.Controls.Add(this.lblModeloEti);
            this.gbConfig.Controls.Add(this.ddlEtiqueta);
            this.gbConfig.Controls.Add(this.ddlImpressao);
            this.gbConfig.Controls.Add(this.btnConfigurar);
            this.gbConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfig.ForeColor = System.Drawing.Color.Navy;
            this.gbConfig.Location = new System.Drawing.Point(16, 48);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(435, 144);
            this.gbConfig.TabIndex = 8;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Configurações";
            // 
            // lblModeloImp
            // 
            this.lblModeloImp.AutoSize = true;
            this.lblModeloImp.Location = new System.Drawing.Point(21, 29);
            this.lblModeloImp.Name = "lblModeloImp";
            this.lblModeloImp.Size = new System.Drawing.Size(135, 13);
            this.lblModeloImp.TabIndex = 4;
            this.lblModeloImp.Text = "Modelo de Impressão :";
            this.lblModeloImp.Click += new System.EventHandler(this.lblModeloImp_Click);
            // 
            // lblModeloEti
            // 
            this.lblModeloEti.AutoSize = true;
            this.lblModeloEti.Location = new System.Drawing.Point(21, 75);
            this.lblModeloEti.Name = "lblModeloEti";
            this.lblModeloEti.Size = new System.Drawing.Size(125, 13);
            this.lblModeloEti.TabIndex = 3;
            this.lblModeloEti.Text = "Modelo de Etiqueta :";
            this.lblModeloEti.Click += new System.EventHandler(this.lblModeloEti_Click);
            // 
            // ddlEtiqueta
            // 
            this.ddlEtiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlEtiqueta.FormattingEnabled = true;
            this.ddlEtiqueta.Location = new System.Drawing.Point(24, 88);
            this.ddlEtiqueta.Name = "ddlEtiqueta";
            this.ddlEtiqueta.Size = new System.Drawing.Size(389, 21);
            this.ddlEtiqueta.TabIndex = 2;
            this.ddlEtiqueta.SelectedIndexChanged += new System.EventHandler(this.ddlEtiqueta_SelectedIndexChanged);
            // 
            // ddlImpressao
            // 
            this.ddlImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlImpressao.FormattingEnabled = true;
            this.ddlImpressao.Location = new System.Drawing.Point(24, 43);
            this.ddlImpressao.MaxLength = 50;
            this.ddlImpressao.Name = "ddlImpressao";
            this.ddlImpressao.Size = new System.Drawing.Size(389, 21);
            this.ddlImpressao.TabIndex = 1;
            this.ddlImpressao.SelectedIndexChanged += new System.EventHandler(this.ddlImpressao_SelectedIndexChanged);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfigurar.Location = new System.Drawing.Point(338, 115);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 3;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // gbFonte
            // 
            this.gbFonte.Controls.Add(this.btnFonte);
            this.gbFonte.Controls.Add(this.lblTFonteNome);
            this.gbFonte.Controls.Add(this.lblTFonteBarCode);
            this.gbFonte.Controls.Add(this.txtTFonteNome);
            this.gbFonte.Controls.Add(this.txtTFonteBarCode);
            this.gbFonte.Controls.Add(this.lblNome);
            this.gbFonte.Controls.Add(this.txtFonteNome);
            this.gbFonte.Controls.Add(this.ddlFonteCodigo);
            this.gbFonte.Controls.Add(this.lblCod);
            this.gbFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFonte.ForeColor = System.Drawing.Color.Navy;
            this.gbFonte.Location = new System.Drawing.Point(16, 205);
            this.gbFonte.Name = "gbFonte";
            this.gbFonte.Size = new System.Drawing.Size(435, 100);
            this.gbFonte.TabIndex = 9;
            this.gbFonte.TabStop = false;
            this.gbFonte.Text = "Fonte";
            // 
            // btnFonte
            // 
            this.btnFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFonte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFonte.Location = new System.Drawing.Point(240, 62);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(25, 20);
            this.btnFonte.TabIndex = 6;
            this.btnFonte.Text = "...";
            this.btnFonte.UseVisualStyleBackColor = true;
            this.btnFonte.Click += new System.EventHandler(this.btnFonte_Click);
            // 
            // lblTFonteNome
            // 
            this.lblTFonteNome.AutoSize = true;
            this.lblTFonteNome.Location = new System.Drawing.Point(298, 65);
            this.lblTFonteNome.Name = "lblTFonteNome";
            this.lblTFonteNome.Size = new System.Drawing.Size(67, 13);
            this.lblTFonteNome.TabIndex = 12;
            this.lblTFonteNome.Text = "Tamanho :";
            this.lblTFonteNome.Click += new System.EventHandler(this.lblTFonteNome_Click);
            this.lblTFonteNome.MouseHover += new System.EventHandler(this.lblTFonteNome_MouseHover);
            // 
            // lblTFonteBarCode
            // 
            this.lblTFonteBarCode.AutoSize = true;
            this.lblTFonteBarCode.Location = new System.Drawing.Point(298, 30);
            this.lblTFonteBarCode.Name = "lblTFonteBarCode";
            this.lblTFonteBarCode.Size = new System.Drawing.Size(67, 13);
            this.lblTFonteBarCode.TabIndex = 11;
            this.lblTFonteBarCode.Text = "Tamanho :";
            this.lblTFonteBarCode.Click += new System.EventHandler(this.lblTFonteBarCode_Click);
            this.lblTFonteBarCode.MouseHover += new System.EventHandler(this.lblTFonteBarCode_MouseHover);
            // 
            // txtTFonteNome
            // 
            this.txtTFonteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTFonteNome.Location = new System.Drawing.Point(371, 62);
            this.txtTFonteNome.MaxLength = 5;
            this.txtTFonteNome.Name = "txtTFonteNome";
            this.txtTFonteNome.Size = new System.Drawing.Size(45, 20);
            this.txtTFonteNome.TabIndex = 7;
            this.txtTFonteNome.MouseHover += new System.EventHandler(this.txtTFonteNome_MouseHover);
            // 
            // txtTFonteBarCode
            // 
            this.txtTFonteBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTFonteBarCode.Location = new System.Drawing.Point(371, 27);
            this.txtTFonteBarCode.MaxLength = 5;
            this.txtTFonteBarCode.Name = "txtTFonteBarCode";
            this.txtTFonteBarCode.Size = new System.Drawing.Size(45, 20);
            this.txtTFonteBarCode.TabIndex = 5;
            this.txtTFonteBarCode.MouseHover += new System.EventHandler(this.txtTFonteBarCode_MouseHover);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(76, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome :";
            // 
            // txtFonteNome
            // 
            this.txtFonteNome.Enabled = false;
            this.txtFonteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFonteNome.Location = new System.Drawing.Point(129, 62);
            this.txtFonteNome.Name = "txtFonteNome";
            this.txtFonteNome.Size = new System.Drawing.Size(110, 20);
            this.txtFonteNome.TabIndex = 7;
            // 
            // ddlFonteCodigo
            // 
            this.ddlFonteCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFonteCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFonteCodigo.FormattingEnabled = true;
            this.ddlFonteCodigo.Location = new System.Drawing.Point(129, 26);
            this.ddlFonteCodigo.Name = "ddlFonteCodigo";
            this.ddlFonteCodigo.Size = new System.Drawing.Size(136, 21);
            this.ddlFonteCodigo.TabIndex = 4;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(11, 29);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(112, 13);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Código de Barras :";
            this.lblCod.Click += new System.EventHandler(this.lblCod_Click);
            // 
            // gbImpressao
            // 
            this.gbImpressao.Controls.Add(this.ddlConteudo);
            this.gbImpressao.Controls.Add(this.lblConteudo);
            this.gbImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImpressao.ForeColor = System.Drawing.Color.Navy;
            this.gbImpressao.Location = new System.Drawing.Point(16, 317);
            this.gbImpressao.Name = "gbImpressao";
            this.gbImpressao.Size = new System.Drawing.Size(435, 63);
            this.gbImpressao.TabIndex = 10;
            this.gbImpressao.TabStop = false;
            this.gbImpressao.Text = "Impressão";
            // 
            // ddlConteudo
            // 
            this.ddlConteudo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlConteudo.FormattingEnabled = true;
            this.ddlConteudo.Location = new System.Drawing.Point(129, 26);
            this.ddlConteudo.Name = "ddlConteudo";
            this.ddlConteudo.Size = new System.Drawing.Size(284, 21);
            this.ddlConteudo.TabIndex = 8;
            this.ddlConteudo.SelectedIndexChanged += new System.EventHandler(this.ddlConteudo_SelectedIndexChanged);
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Location = new System.Drawing.Point(54, 29);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(69, 13);
            this.lblConteudo.TabIndex = 13;
            this.lblConteudo.Text = "Conteúdo :";
            this.lblConteudo.Click += new System.EventHandler(this.lblConteudo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSalvar,
            this.toolStripSeparator1,
            this.tbtnExcluir,
            this.toolStripSeparator2,
            this.tbtnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 37);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSalvar
            // 
            this.tbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSalvar.Image")));
            this.tbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSalvar.Name = "tbtnSalvar";
            this.tbtnSalvar.Size = new System.Drawing.Size(34, 34);
            this.tbtnSalvar.Text = "Salvar";
            this.tbtnSalvar.Click += new System.EventHandler(this.tbtnSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tbtnExcluir
            // 
            this.tbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExcluir.Image")));
            this.tbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExcluir.Name = "tbtnExcluir";
            this.tbtnExcluir.Size = new System.Drawing.Size(34, 34);
            this.tbtnExcluir.Text = "Excluir";
            this.tbtnExcluir.Click += new System.EventHandler(this.tbtnExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tbtnSair
            // 
            this.tbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSair.Image")));
            this.tbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSair.Name = "tbtnSair";
            this.tbtnSair.Size = new System.Drawing.Size(34, 34);
            this.tbtnSair.Text = "Sair";
            this.tbtnSair.Click += new System.EventHandler(this.tbtnSair_Click);
            // 
            // txtFormato
            // 
            this.txtFormato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormato.Location = new System.Drawing.Point(235, 39);
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(170, 20);
            this.txtFormato.TabIndex = 10;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(232, 26);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(60, 13);
            this.lblFormato.TabIndex = 10;
            this.lblFormato.Text = "Formato :";
            this.lblFormato.Click += new System.EventHandler(this.lblFormato_Click);
            // 
            // txtPrefixo
            // 
            this.txtPrefixo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrefixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefixo.Location = new System.Drawing.Point(235, 87);
            this.txtPrefixo.Name = "txtPrefixo";
            this.txtPrefixo.Size = new System.Drawing.Size(170, 20);
            this.txtPrefixo.TabIndex = 12;
            // 
            // lblPrefixo
            // 
            this.lblPrefixo.AutoSize = true;
            this.lblPrefixo.Location = new System.Drawing.Point(232, 74);
            this.lblPrefixo.Name = "lblPrefixo";
            this.lblPrefixo.Size = new System.Drawing.Size(54, 13);
            this.lblPrefixo.TabIndex = 6;
            this.lblPrefixo.Text = "Prefixo :";
            this.lblPrefixo.Click += new System.EventHandler(this.lblPrefixo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFormato);
            this.groupBox1.Controls.Add(this.lblFormato);
            this.groupBox1.Controls.Add(this.txtPrefixo);
            this.groupBox1.Controls.Add(this.lblPrefixo);
            this.groupBox1.Controls.Add(this.txtIntervalo);
            this.groupBox1.Controls.Add(this.lblIntervalo);
            this.groupBox1.Controls.Add(this.txtInicio);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(16, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 120);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Sequência";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervalo.Location = new System.Drawing.Point(28, 87);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(170, 20);
            this.txtIntervalo.TabIndex = 11;
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Location = new System.Drawing.Point(25, 74);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(65, 13);
            this.lblIntervalo.TabIndex = 2;
            this.lblIntervalo.Text = "Intervalo :";
            this.lblIntervalo.Click += new System.EventHandler(this.lblIntervalo_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.Location = new System.Drawing.Point(28, 39);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(170, 20);
            this.txtInicio.TabIndex = 9;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(25, 26);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(48, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Início :";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // tltTBarcode
            // 
            this.tltTBarcode.AutomaticDelay = 200;
            this.tltTBarcode.AutoPopDelay = 7000;
            this.tltTBarcode.InitialDelay = 200;
            this.tltTBarcode.ReshowDelay = 40;
            this.tltTBarcode.ShowAlways = true;
            // 
            // tltTNome
            // 
            this.tltTNome.AutomaticDelay = 200;
            this.tltTNome.AutoPopDelay = 7000;
            this.tltTNome.InitialDelay = 200;
            this.tltTNome.ReshowDelay = 40;
            // 
            // frmConfigImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbImpressao);
            this.Controls.Add(this.gbFonte);
            this.Controls.Add(this.gbConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos de Impressão";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfigImpressao_FormClosing);
            this.Load += new System.EventHandler(this.frmConfigImpressao_Load);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.gbFonte.ResumeLayout(false);
            this.gbFonte.PerformLayout();
            this.gbImpressao.ResumeLayout(false);
            this.gbImpressao.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.GroupBox gbFonte;
        private System.Windows.Forms.GroupBox gbImpressao;
        private System.Windows.Forms.ComboBox ddlImpressao;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Label lblModeloEti;
        private System.Windows.Forms.Label lblModeloImp;
        private System.Windows.Forms.TextBox txtFonteNome;
        private System.Windows.Forms.ComboBox ddlFonteCodigo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTFonteNome;
        private System.Windows.Forms.Label lblTFonteBarCode;
        private System.Windows.Forms.TextBox txtTFonteNome;
        private System.Windows.Forms.TextBox txtTFonteBarCode;
        private System.Windows.Forms.ComboBox ddlConteudo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.FontDialog fntDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnSair;
        private System.Windows.Forms.TextBox txtFormato;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TextBox txtPrefixo;
        private System.Windows.Forms.Label lblPrefixo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Button btnFonte;
        private System.Windows.Forms.ComboBox ddlEtiqueta;
        private System.Windows.Forms.ToolTip tltTBarcode;
        private System.Windows.Forms.ToolTip tltTNome;
    }
}