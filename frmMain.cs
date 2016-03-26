using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Configuration;
using Controle;
using Modelo;
//Zebra using:
using System.Runtime.InteropServices;
using System.IO;

namespace e2Etiquetas
{
    public partial class frmMain : Form
    {
        ConEtq ce = new ConEtq();

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Caso click no label exibe/esconde dropdownlist
        /// </summary>
        private void lblModelo_Click(object sender, EventArgs e)
        {
            if (ddlImpressao.DroppedDown == false)
                this.ddlImpressao.DroppedDown = true;
            else
                this.ddlImpressao.DroppedDown = false;
        }

        /// <summary>
        /// Chama form de configurações de impressao
        /// </summary>
        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfigImpressao modelo = new frmConfigImpressao(this.ddlImpressao);
            modelo.ShowDialog();
            this.ddlImpressao.SelectedItem = Dados.modelo;
        }

        /// <summary>
        /// Chama o contador
        /// </summary>
        private void btnImportar_Click(object sender, EventArgs e)
        {
            //ce.SelectCont();
            FrmCont count = new FrmCont(this.Lv);
            count.ShowDialog();
            this.btnTodos.Text = "Marcar Todos";

            foreach (ListViewItem item in this.Lv.Items)
            {
                item.Checked = false;
            }
            if (this.Lv.Items.Count == 0)
            {
                this.statusLabel.Visible = true;
                this.statusLabel.Text = "Aguardando importação...";
                return;
            }
            this.statusLabel.Visible = true;
            this.statusLabel.Text = "Aguardando marcações...";
        }

        private void tbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// Configuração das checkboxes
        /// Marcar ou não TODAS e
        /// alterar texto do botão                
        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (this.Lv.Items.Count == 0)
            {
                if (this.statusLabel.Text != "Aguardando importação...")
                    this.statusLabel.Text = "Aguardando importação...";

                return;
            }

            if (this.btnTodos.Text == "Marcar Todos")
            {
                foreach (ListViewItem item in this.Lv.Items)
                    item.Checked = true;
                this.btnTodos.Text = "Desmarcar Todos";
                this.statusLabel.Text = "Pronto para impressão";
            }
            else
            {
                foreach (ListViewItem item in this.Lv.Items)
                    item.Checked = false;
                this.btnTodos.Text = "Marcar Todos";
                this.statusLabel.Text = "Aguardando marcações...";
            }

        }

        /// <summary>
        /// Mandar imprimir
        /// </summary>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.statusLabel.Text = "Aguardando escolha da impressora...";
            // tem impressoras?
            if (PrinterSettings.InstalledPrinters.Count == 0)
            {
                this.statusLabel.Text = "Não há impresoras instaladas!";
                MessageBox.Show("Não há impresoras instaladas!", "Impressoras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(this.Lv.Items.Count == 0)
            {
                this.statusLabel.Text = "As etiquetas não foram importadas!";
                MessageBox.Show("Não há etiquetas importadas!", "Impressoras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool porta = false;

            //enquanto o botao cancel for clicado
            while (porta == false)
            {
                DialogResult = this.pdImprimir.ShowDialog();

                if (DialogResult == DialogResult.Cancel)
                {
                    DialogResult confirma = new DialogResult();
                    ///realmente deseja cancelar
                    confirma = MessageBox.Show("Realmente deseja cancelar a impressão?", "Impressão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    ///sim
                    while (confirma == DialogResult.Yes)
                    {
                        this.statusLabel.Text = "Impressão cancelada!";
                        return;
                    }
                }
                else if (DialogResult == DialogResult.OK) 
                {
                    //sai do loop e manda imprimir
                    porta = true;
                    Dados.impressora = this.pdImprimir.PrinterSettings.PrinterName;
                }
            }
            try
            {
                Dados.modelo = this.ddlImpressao.Text;
                Printing p = new Printing();
                PreencheChecked();
                if(Dados.chk.Count == 0)
                {
                    MessageBox.Show("Não há etiquetas marcadas para impressão!","Impressão",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    this.statusLabel.Text = "Aguardando marcações...";
                    return;
                }
                //ce.PreencheImpressao(this.ddlImpressao.Text);
                //ce.PreencheEtiqueta();

                ///Desenha as etiquetas(rects)
                preencheRect(Dados.etiqueta);

                this.statusLabel.Text = "Imprimindo Etiquetas...";
                if (Dados.papel == "Contínuo")
                    PrintRaw();
                else
                    p.PrintDocument();
                this.Lv.Items.Clear();
                this.statusLabel.Text = "Fim";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível imprimir as etiquetas!\n"+ ex.Message, "Impressão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Ocorreu um erro durante a impressão!";
            }
        }

        /// <summary>
        /// Load
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.ddlImpressao.Items.Insert(0, StaticVars.MODELO_DEFAULT);                
                foreach (var modelo in ModeloDAO.getMDAO().ListarModelos())
                {
                    this.ddlImpressao.Items.Insert(modelo.id, modelo.nome);
                }
                this.ddlImpressao.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,null,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }            
        }

        /// <summary>
        /// Preencher array de rect e pegar ID do modelo
        /// </summary>
        private void ddlImpressao_TextChanged(object sender, EventArgs e)
        {
            LimpaView();
        }

        /// <summary>
        /// Preenche o array de retangulos para impressão
        /// </summary>
        private void preencheRect(string etiqueta)
        {
            ///limpa a lista
            Dados.lrect.Clear();
            //ce.GetIDMdl();
            //ce.GetIDEtq();
            //ce.PreencheRect();
            
            ///pega o modelo ve as medidas da etiqueta
            ///e gera os retangulos de acordo com as config salvas
            ///tamanho com escala e conversão de MM para Pixels(*3.78)
            int x = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.MargemE) * 3.78));
            int y = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.MargemT) * 3.78));
            int EspCol = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.DistH) * 3.78));
            int EspLin = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.DistV) * 3.78));
            int numh = Convert.ToInt32(Dados.NumH);
            int numv = Convert.ToInt32(Dados.NumV);
            int qntdeETQ = 0;

            ///se for continuo preenche com quantidade de etiquetas
            if (Dados.papel == "Contínuo")
                qntdeETQ = Dados.chk.Count - 1;
            else///se nao preenche com quantidade de etq verticais na pag.
                qntdeETQ = numv - 1;

            for (int i = 0; i < numh; i++)
            {

                Rectangle rec = new Rectangle();

                ///posição
                rec.X = x;

                rec.Y = y;

                ///tamanho com escala e conversão de MM para Pixels(*3.78)
                rec.Width = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.TamH) * 3.78));
                rec.Height = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.TamV) * 3.78));

                Dados.lrect.Add(rec);
                y += rec.Height + EspLin;

                for (int j = 0; j < qntdeETQ; j++)
                {
                    rec.X = x;
                    rec.Y = y;

                    ///tamanho com escala e conversão de MM para Pixel(*3.78)
                    rec.Width = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.TamH) * 3.78));
                    rec.Height = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.TamV) * 3.78));

                    y += rec.Height + EspLin;
                    Dados.lrect.Add(rec);
                }

                x += rec.Width + EspCol;
                ///tamanho com escala e conversão de MM para Pixel(*3.78)
                y = Convert.ToInt32(Math.Floor(Convert.ToDouble(Dados.MargemT) * 3.78));

            }
        }

        /// <summary>
        /// Preenche lista com APENAS etiquetas marcadas
        /// </summary>
        private void PreencheChecked() 
        {
            ///prencher apenas com os itens marcados
            Dados.chk.Clear();
            for (int c = 0; c < this.Lv.Items.Count; c++) 
            {
                if (this.Lv.Items[c].Checked)
                    Dados.chk.Add(this.Lv.Items[c].Text);
                else
                    continue;
            }
        }

        /// <summary>
        /// Mandar imprimir em Zebra
        /// </summary>
        public void PrintRaw()
        {

            int ContEtq = 0;
            int dpmm = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("convert"));
            int LHE = 0;
            int LHT = 0;
            string code = "";
            int multiplicador = 0;
            int Tbarcode = 0;
            string s = "";
            int FOE = 0;
            int FOT = 0;
            int Tfonte = (int)Dados.TamFonteNM;


            for (int i = 0; i < Dados.chk.Count; i++)
            {
                string raw = "";
                s = Dados.chk[i];
                //Define tipo do barcode em ZPL
                if (Dados.FonteBC != "Code128A")
                {
                    multiplicador = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("code39"));
                    code = "^B3N,";
                }
                else
                {
                    multiplicador = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings.Get("code128"));
                    code = "^BC";
                }

                //Converte PX para mm (/3.78)
                //Converter mm para dots (* dpmm)
                ///Mensagem da tootip para dobrar o tamanho da etiqueta em mm
                Tbarcode = (int)Dados.TamFonteBC;

                //Opção 1(Algoritmo original)*/LHE = (int)((Dados.TamH * dpmm) - (s.Length * multiplicador) - s.Length) / 2;
                //Opção 2*/LHE = (int)(((Dados.TamH * dpmm) - (s.Length * multiplicador) - s.Length) / 10) * 6;
                //Opção 3*/LHE = (int)(((Dados.TamH * dpmm) / 9) * 4) - (((s.Length * multiplicador) / 9) * 4);
                LHT = (int)((Dados.TamV * dpmm) - Tbarcode) / 2;


                raw += "^XA";
                raw += "^LH" + LHE + "," + LHT;
                raw += "^FO1,1";
                raw += "^BY2";
                raw += code + "N," + Tbarcode + ",N,N";
                raw += "^FV" + s;
                raw += "^FS";

                ///Nome
                if (Dados.conteudo == "Codigo e Nome")
                {
                    FOE = (((s.Length * multiplicador) / 5) * 2) - s.Length;
                    FOT = (int)((Dados.TamV * dpmm) / 2) + (Tbarcode / 5);
                    raw += "^FO" + FOE + "," + FOT;
                    raw += "^ADN," + Tfonte;
                    raw += "^FV" + s;
                    raw += "^FS";
                }

                raw += "^MCY";
                raw += "^XZ";


                ///Manda para converter para RAW
                RawPrinter.SendStringToPrinter(this.pdImprimir.PrinterSettings.PrinterName, raw);

                ///Registrar o ultimo valor impresso
                ///para poder continuar de onde parou
                Dados.inicio = int.Parse(Dados.chk[i].Substring(Dados.prefixo.Length));
                ContEtq++;
            }
        }

        private void LimpaView() 
        {
            this.Lv.Items.Clear();

            if (this.btnTodos.Text == StaticVars.BTNdsTODOS_TEXT)
                this.btnTodos.Text = StaticVars.BTNmTODOS_TEXT;

            this.statusLabel.Visible = true;
            this.statusLabel.Text = string.Format("Modelo {0} selecionado.", this.ddlImpressao.Text);
        }

    }//fim classe


    /// <summary>
    /// ZEBRA
    /// </summary>
    class RawPrinter
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "etiquetas";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        /// <summary>
        /// Imprimir um arquivo
        /// passando endereço
        /// </summary>
        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }

        /// <summary>
        /// Imprimir uma string
        /// </summary>
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }

}