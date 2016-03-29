namespace e2Etiquetas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ddlImpressao = new System.Windows.Forms.ComboBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.gbFrame1 = new System.Windows.Forms.GroupBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.gbFrame3 = new System.Windows.Forms.GroupBox();
            this.Lv = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.procurar = new System.Windows.Forms.OpenFileDialog();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pdImprimir = new System.Windows.Forms.PrintDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSair = new System.Windows.Forms.ToolStripButton();
            this.gbFrame1.SuspendLayout();
            this.gbFrame3.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlImpressao
            // 
            this.ddlImpressao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlImpressao.FormattingEnabled = true;
            this.ddlImpressao.Location = new System.Drawing.Point(16, 36);
            this.ddlImpressao.Name = "ddlImpressao";
            this.ddlImpressao.Size = new System.Drawing.Size(395, 21);
            this.ddlImpressao.TabIndex = 1;
            this.ddlImpressao.TextChanged += new System.EventHandler(this.ddlImpressao_TextChanged);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfig.Location = new System.Drawing.Point(335, 64);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Navy;
            this.lblModelo.Location = new System.Drawing.Point(13, 23);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(134, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo de impressão :";
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // gbFrame1
            // 
            this.gbFrame1.Controls.Add(this.ddlImpressao);
            this.gbFrame1.Controls.Add(this.lblModelo);
            this.gbFrame1.Controls.Add(this.btnConfig);
            this.gbFrame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFrame1.ForeColor = System.Drawing.Color.Navy;
            this.gbFrame1.Location = new System.Drawing.Point(12, 49);
            this.gbFrame1.Name = "gbFrame1";
            this.gbFrame1.Size = new System.Drawing.Size(432, 90);
            this.gbFrame1.TabIndex = 7;
            this.gbFrame1.TabStop = false;
            this.gbFrame1.Text = "Definições";
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImportar.Location = new System.Drawing.Point(98, 218);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(100, 23);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // gbFrame3
            // 
            this.gbFrame3.Controls.Add(this.Lv);
            this.gbFrame3.Controls.Add(this.btnTodos);
            this.gbFrame3.Controls.Add(this.btnImprimir);
            this.gbFrame3.Controls.Add(this.btnImportar);
            this.gbFrame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFrame3.ForeColor = System.Drawing.Color.Navy;
            this.gbFrame3.Location = new System.Drawing.Point(12, 161);
            this.gbFrame3.Name = "gbFrame3";
            this.gbFrame3.Size = new System.Drawing.Size(432, 245);
            this.gbFrame3.TabIndex = 9;
            this.gbFrame3.TabStop = false;
            this.gbFrame3.Text = "Seleção";
            // 
            // Lv
            // 
            this.Lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo});
            this.Lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv.Location = new System.Drawing.Point(16, 20);
            this.Lv.Name = "Lv";
            this.Lv.Size = new System.Drawing.Size(395, 192);
            this.Lv.TabIndex = 12;
            this.Lv.UseCompatibleStateImageBehavior = false;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 180;
            // 
            // btnTodos
            // 
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTodos.Location = new System.Drawing.Point(204, 218);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(100, 23);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Marcar Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Location = new System.Drawing.Point(310, 218);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // procurar
            // 
            this.procurar.InitialDirectory = "c:\\";
            this.procurar.Title = "Arquivos de entrada";
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.stsStatus.Location = new System.Drawing.Point(0, 420);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(456, 22);
            this.stsStatus.TabIndex = 10;
            // 
            // statusLabel
            // 
            this.statusLabel.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusLabel.LinkColor = System.Drawing.Color.Black;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.Visible = false;
            // 
            // pdImprimir
            // 
            this.pdImprimir.UseEXDialog = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(456, 37);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(456, 442);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.gbFrame3);
            this.Controls.Add(this.gbFrame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbFrame1.ResumeLayout(false);
            this.gbFrame1.PerformLayout();
            this.gbFrame3.ResumeLayout(false);
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlImpressao;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox gbFrame1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.GroupBox gbFrame3;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.OpenFileDialog procurar;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.PrintDialog pdImprimir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSair;
        private System.Windows.Forms.ListView Lv;

    }
}

