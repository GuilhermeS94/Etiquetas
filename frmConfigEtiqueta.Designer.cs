namespace e2Etiquetas
{
    partial class frmConfigEtiqueta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigEtiqueta));
            this.gbVisualizacao = new System.Windows.Forms.GroupBox();
            this.pbPagina = new System.Windows.Forms.PictureBox();
            this.pbSombra = new System.Windows.Forms.PictureBox();
            this.gbModelo = new System.Windows.Forms.GroupBox();
            this.ddlModelo = new System.Windows.Forms.ComboBox();
            this.gbEstrutura = new System.Windows.Forms.GroupBox();
            this.lblEtqHor = new System.Windows.Forms.Label();
            this.lblEtqVert = new System.Windows.Forms.Label();
            this.txtNumH = new System.Windows.Forms.TextBox();
            this.txtNumV = new System.Windows.Forms.TextBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.ddlTipoPapel = new System.Windows.Forms.ComboBox();
            this.gbDimensao = new System.Windows.Forms.GroupBox();
            this.lblEspLin = new System.Windows.Forms.Label();
            this.txtEspLin = new System.Windows.Forms.TextBox();
            this.lblEspcCol = new System.Windows.Forms.Label();
            this.txtEspCol = new System.Windows.Forms.TextBox();
            this.lblMargSup = new System.Windows.Forms.Label();
            this.txtMargemT = new System.Windows.Forms.TextBox();
            this.lblMargEsq = new System.Windows.Forms.Label();
            this.txtMargemE = new System.Windows.Forms.TextBox();
            this.lblAltEtq = new System.Windows.Forms.Label();
            this.txtTamV = new System.Windows.Forms.TextBox();
            this.lblLargEtq = new System.Windows.Forms.Label();
            this.txtTamH = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSair = new System.Windows.Forms.ToolStripButton();
            this.gbVisualizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSombra)).BeginInit();
            this.gbModelo.SuspendLayout();
            this.gbEstrutura.SuspendLayout();
            this.gbDimensao.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVisualizacao
            // 
            this.gbVisualizacao.AutoSize = true;
            this.gbVisualizacao.Controls.Add(this.pbPagina);
            this.gbVisualizacao.Controls.Add(this.pbSombra);
            this.gbVisualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisualizacao.ForeColor = System.Drawing.Color.Navy;
            this.gbVisualizacao.Location = new System.Drawing.Point(479, 43);
            this.gbVisualizacao.Name = "gbVisualizacao";
            this.gbVisualizacao.Size = new System.Drawing.Size(283, 387);
            this.gbVisualizacao.TabIndex = 13;
            this.gbVisualizacao.TabStop = false;
            this.gbVisualizacao.Text = "Visualização";
            // 
            // pbPagina
            // 
            this.pbPagina.BackColor = System.Drawing.Color.White;
            this.pbPagina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPagina.Location = new System.Drawing.Point(19, 22);
            this.pbPagina.Name = "pbPagina";
            this.pbPagina.Size = new System.Drawing.Size(230, 330);
            this.pbPagina.TabIndex = 2;
            this.pbPagina.TabStop = false;
            // 
            // pbSombra
            // 
            this.pbSombra.BackColor = System.Drawing.Color.Black;
            this.pbSombra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSombra.Location = new System.Drawing.Point(26, 29);
            this.pbSombra.Name = "pbSombra";
            this.pbSombra.Size = new System.Drawing.Size(230, 330);
            this.pbSombra.TabIndex = 1;
            this.pbSombra.TabStop = false;
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.ddlModelo);
            this.gbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModelo.ForeColor = System.Drawing.Color.Navy;
            this.gbModelo.Location = new System.Drawing.Point(12, 73);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Size = new System.Drawing.Size(442, 60);
            this.gbModelo.TabIndex = 14;
            this.gbModelo.TabStop = false;
            this.gbModelo.Text = "Modelo";
            // 
            // ddlModelo
            // 
            this.ddlModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlModelo.FormattingEnabled = true;
            this.ddlModelo.Location = new System.Drawing.Point(16, 23);
            this.ddlModelo.MaxLength = 50;
            this.ddlModelo.Name = "ddlModelo";
            this.ddlModelo.Size = new System.Drawing.Size(400, 21);
            this.ddlModelo.TabIndex = 1;
            this.ddlModelo.SelectedIndexChanged += new System.EventHandler(this.ddlModelo_SelectedIndexChanged);
            // 
            // gbEstrutura
            // 
            this.gbEstrutura.Controls.Add(this.lblEtqHor);
            this.gbEstrutura.Controls.Add(this.lblEtqVert);
            this.gbEstrutura.Controls.Add(this.txtNumH);
            this.gbEstrutura.Controls.Add(this.txtNumV);
            this.gbEstrutura.Controls.Add(this.lblFormato);
            this.gbEstrutura.Controls.Add(this.ddlTipoPapel);
            this.gbEstrutura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstrutura.ForeColor = System.Drawing.Color.Navy;
            this.gbEstrutura.Location = new System.Drawing.Point(12, 162);
            this.gbEstrutura.Name = "gbEstrutura";
            this.gbEstrutura.Size = new System.Drawing.Size(442, 94);
            this.gbEstrutura.TabIndex = 15;
            this.gbEstrutura.TabStop = false;
            this.gbEstrutura.Text = "Estrutura do Documento";
            // 
            // lblEtqHor
            // 
            this.lblEtqHor.AutoSize = true;
            this.lblEtqHor.Location = new System.Drawing.Point(218, 60);
            this.lblEtqHor.Name = "lblEtqHor";
            this.lblEtqHor.Size = new System.Drawing.Size(147, 13);
            this.lblEtqHor.TabIndex = 6;
            this.lblEtqHor.Text = "Etiquetas na Horizontal :";
            this.lblEtqHor.Click += new System.EventHandler(this.lblEtqHor_Click);
            // 
            // lblEtqVert
            // 
            this.lblEtqVert.AutoSize = true;
            this.lblEtqVert.Location = new System.Drawing.Point(232, 28);
            this.lblEtqVert.Name = "lblEtqVert";
            this.lblEtqVert.Size = new System.Drawing.Size(133, 13);
            this.lblEtqVert.TabIndex = 5;
            this.lblEtqVert.Text = "Etiquetas na Vertical :";
            this.lblEtqVert.Click += new System.EventHandler(this.lblEtqVert_Click);
            // 
            // txtNumH
            // 
            this.txtNumH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumH.Location = new System.Drawing.Point(371, 57);
            this.txtNumH.MaxLength = 2;
            this.txtNumH.Name = "txtNumH";
            this.txtNumH.Size = new System.Drawing.Size(45, 20);
            this.txtNumH.TabIndex = 4;
            // 
            // txtNumV
            // 
            this.txtNumV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumV.Location = new System.Drawing.Point(371, 25);
            this.txtNumV.MaxLength = 2;
            this.txtNumV.Name = "txtNumV";
            this.txtNumV.Size = new System.Drawing.Size(45, 20);
            this.txtNumV.TabIndex = 3;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(13, 31);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(121, 13);
            this.lblFormato.TabIndex = 2;
            this.lblFormato.Text = "Formato da Página :";
            this.lblFormato.Click += new System.EventHandler(this.lblFormato_Click);
            // 
            // ddlTipoPapel
            // 
            this.ddlTipoPapel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTipoPapel.FormattingEnabled = true;
            this.ddlTipoPapel.Location = new System.Drawing.Point(16, 44);
            this.ddlTipoPapel.Name = "ddlTipoPapel";
            this.ddlTipoPapel.Size = new System.Drawing.Size(135, 21);
            this.ddlTipoPapel.TabIndex = 2;
            this.ddlTipoPapel.SelectedIndexChanged += new System.EventHandler(this.ddlTipoPapel_SelectedIndexChanged);
            // 
            // gbDimensao
            // 
            this.gbDimensao.Controls.Add(this.lblEspLin);
            this.gbDimensao.Controls.Add(this.txtEspLin);
            this.gbDimensao.Controls.Add(this.lblEspcCol);
            this.gbDimensao.Controls.Add(this.txtEspCol);
            this.gbDimensao.Controls.Add(this.lblMargSup);
            this.gbDimensao.Controls.Add(this.txtMargemT);
            this.gbDimensao.Controls.Add(this.lblMargEsq);
            this.gbDimensao.Controls.Add(this.txtMargemE);
            this.gbDimensao.Controls.Add(this.lblAltEtq);
            this.gbDimensao.Controls.Add(this.txtTamV);
            this.gbDimensao.Controls.Add(this.lblLargEtq);
            this.gbDimensao.Controls.Add(this.txtTamH);
            this.gbDimensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDimensao.ForeColor = System.Drawing.Color.Navy;
            this.gbDimensao.Location = new System.Drawing.Point(12, 286);
            this.gbDimensao.Name = "gbDimensao";
            this.gbDimensao.Size = new System.Drawing.Size(442, 117);
            this.gbDimensao.TabIndex = 16;
            this.gbDimensao.TabStop = false;
            this.gbDimensao.Text = "Dimensões (mm)";
            // 
            // lblEspLin
            // 
            this.lblEspLin.AutoSize = true;
            this.lblEspLin.Location = new System.Drawing.Point(234, 81);
            this.lblEspLin.Name = "lblEspLin";
            this.lblEspLin.Size = new System.Drawing.Size(131, 13);
            this.lblEspLin.TabIndex = 18;
            this.lblEspLin.Text = "Espaço entre Linhas :";
            this.lblEspLin.Click += new System.EventHandler(this.lblEspLin_Click);
            // 
            // txtEspLin
            // 
            this.txtEspLin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspLin.Location = new System.Drawing.Point(371, 78);
            this.txtEspLin.MaxLength = 6;
            this.txtEspLin.Name = "txtEspLin";
            this.txtEspLin.Size = new System.Drawing.Size(45, 20);
            this.txtEspLin.TabIndex = 10;
            // 
            // lblEspcCol
            // 
            this.lblEspcCol.AutoSize = true;
            this.lblEspcCol.Location = new System.Drawing.Point(226, 55);
            this.lblEspcCol.Name = "lblEspcCol";
            this.lblEspcCol.Size = new System.Drawing.Size(139, 13);
            this.lblEspcCol.TabIndex = 16;
            this.lblEspcCol.Text = "Espaço entre Colunas :";
            this.lblEspcCol.Click += new System.EventHandler(this.lblEspcCol_Click);
            // 
            // txtEspCol
            // 
            this.txtEspCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspCol.Location = new System.Drawing.Point(371, 52);
            this.txtEspCol.MaxLength = 6;
            this.txtEspCol.Name = "txtEspCol";
            this.txtEspCol.Size = new System.Drawing.Size(45, 20);
            this.txtEspCol.TabIndex = 9;
            // 
            // lblMargSup
            // 
            this.lblMargSup.AutoSize = true;
            this.lblMargSup.Location = new System.Drawing.Point(255, 29);
            this.lblMargSup.Name = "lblMargSup";
            this.lblMargSup.Size = new System.Drawing.Size(110, 13);
            this.lblMargSup.TabIndex = 14;
            this.lblMargSup.Text = "Margem Superior :";
            this.lblMargSup.Click += new System.EventHandler(this.lblMargSup_Click);
            // 
            // txtMargemT
            // 
            this.txtMargemT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargemT.Location = new System.Drawing.Point(371, 26);
            this.txtMargemT.MaxLength = 6;
            this.txtMargemT.Name = "txtMargemT";
            this.txtMargemT.Size = new System.Drawing.Size(45, 20);
            this.txtMargemT.TabIndex = 8;
            // 
            // lblMargEsq
            // 
            this.lblMargEsq.AutoSize = true;
            this.lblMargEsq.Location = new System.Drawing.Point(18, 81);
            this.lblMargEsq.Name = "lblMargEsq";
            this.lblMargEsq.Size = new System.Drawing.Size(116, 13);
            this.lblMargEsq.TabIndex = 12;
            this.lblMargEsq.Text = "Margem Esquerda :";
            this.lblMargEsq.Click += new System.EventHandler(this.lblMargEsq_Click);
            // 
            // txtMargemE
            // 
            this.txtMargemE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargemE.Location = new System.Drawing.Point(140, 78);
            this.txtMargemE.MaxLength = 6;
            this.txtMargemE.Name = "txtMargemE";
            this.txtMargemE.Size = new System.Drawing.Size(45, 20);
            this.txtMargemE.TabIndex = 7;
            // 
            // lblAltEtq
            // 
            this.lblAltEtq.AutoSize = true;
            this.lblAltEtq.Location = new System.Drawing.Point(17, 55);
            this.lblAltEtq.Name = "lblAltEtq";
            this.lblAltEtq.Size = new System.Drawing.Size(117, 13);
            this.lblAltEtq.TabIndex = 10;
            this.lblAltEtq.Text = "Altura da Etiqueta :";
            this.lblAltEtq.Click += new System.EventHandler(this.lblAltEtq_Click);
            // 
            // txtTamV
            // 
            this.txtTamV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamV.Location = new System.Drawing.Point(140, 52);
            this.txtTamV.MaxLength = 6;
            this.txtTamV.Name = "txtTamV";
            this.txtTamV.Size = new System.Drawing.Size(45, 20);
            this.txtTamV.TabIndex = 6;
            // 
            // lblLargEtq
            // 
            this.lblLargEtq.AutoSize = true;
            this.lblLargEtq.Location = new System.Drawing.Point(7, 29);
            this.lblLargEtq.Name = "lblLargEtq";
            this.lblLargEtq.Size = new System.Drawing.Size(127, 13);
            this.lblLargEtq.TabIndex = 8;
            this.lblLargEtq.Text = "Largura da Etiqueta :";
            this.lblLargEtq.Click += new System.EventHandler(this.lblLargEtq_Click);
            // 
            // txtTamH
            // 
            this.txtTamH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamH.Location = new System.Drawing.Point(140, 26);
            this.txtTamH.MaxLength = 6;
            this.txtTamH.Name = "txtTamH";
            this.txtTamH.Size = new System.Drawing.Size(45, 20);
            this.txtTamH.TabIndex = 5;
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
            this.tbtnAtualizar,
            this.toolStripSeparator3,
            this.tbtnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(774, 37);
            this.toolStrip1.TabIndex = 17;
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
            // tbtnAtualizar
            // 
            this.tbtnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAtualizar.Image")));
            this.tbtnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAtualizar.Name = "tbtnAtualizar";
            this.tbtnAtualizar.Size = new System.Drawing.Size(34, 34);
            this.tbtnAtualizar.Text = "Atualizar";
            this.tbtnAtualizar.Click += new System.EventHandler(this.tbtnAtualizar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
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
            // frmConfigEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 442);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbDimensao);
            this.Controls.Add(this.gbEstrutura);
            this.Controls.Add(this.gbModelo);
            this.Controls.Add(this.gbVisualizacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigEtiqueta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos de Etiquetas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfigEtiqueta_FormClosing);
            this.Load += new System.EventHandler(this.frmConfigEtiqueta_Load);
            this.gbVisualizacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSombra)).EndInit();
            this.gbModelo.ResumeLayout(false);
            this.gbEstrutura.ResumeLayout(false);
            this.gbEstrutura.PerformLayout();
            this.gbDimensao.ResumeLayout(false);
            this.gbDimensao.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVisualizacao;
        private System.Windows.Forms.GroupBox gbModelo;
        private System.Windows.Forms.GroupBox gbEstrutura;
        private System.Windows.Forms.GroupBox gbDimensao;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.ComboBox ddlTipoPapel;
        private System.Windows.Forms.Label lblEtqHor;
        private System.Windows.Forms.Label lblEtqVert;
        private System.Windows.Forms.TextBox txtNumH;
        private System.Windows.Forms.TextBox txtNumV;
        private System.Windows.Forms.Label lblEspLin;
        private System.Windows.Forms.TextBox txtEspLin;
        private System.Windows.Forms.Label lblEspcCol;
        private System.Windows.Forms.TextBox txtEspCol;
        private System.Windows.Forms.Label lblMargSup;
        private System.Windows.Forms.TextBox txtMargemT;
        private System.Windows.Forms.Label lblMargEsq;
        private System.Windows.Forms.TextBox txtMargemE;
        private System.Windows.Forms.Label lblAltEtq;
        private System.Windows.Forms.TextBox txtTamV;
        private System.Windows.Forms.Label lblLargEtq;
        private System.Windows.Forms.TextBox txtTamH;
        private System.Windows.Forms.PictureBox pbSombra;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnAtualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnSair;
        private System.Windows.Forms.PictureBox pbPagina;
        private System.Windows.Forms.ComboBox ddlModelo;
    }
}