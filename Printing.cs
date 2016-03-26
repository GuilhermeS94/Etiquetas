using System;
using System.Drawing;
using System.Drawing.Text;
using System.Configuration;

namespace e2Etiquetas
{
    class Printing : System.Drawing.Printing.PrintDocument
    {
        #region  Property Variables
        ///Vars
        private int k = 0;
        private string Font = ConfigurationManager.AppSettings.Get("Font");
        ConEtq ce = new ConEtq();
        #endregion

        #region  OnPrintPage
        /// Override OnPrintPage
        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Base code
            base.OnPrintPage(e);

            //Method vars
            string s;
            string fonteN = Dados.FonteNM;
            string fonteBC = Dados.FonteBC;
            float tamFonte = Dados.TamFonteNM;
            float tamFonteBC = Dados.TamFonteBC;
            string etq = Dados.etiqueta;
            int qntEtq = (Dados.NumV * Dados.NumH);
            string papel = Dados.papel;
            string conteudo = Dados.conteudo;
            int etqCont = 0;
            int rectCont = 0;
            float x, y;
            System.Drawing.Font fontBC = new System.Drawing.Font("Arial Narrow", 12);
            System.Drawing.Font fontN;
                        
            if (fonteBC == "Code128A")
            {
                fonteBC = "BCW_Code128A_2";
            }

            switch (fonteBC)
            {
                case "BCW_Code128A_2":
                    fontBC = new System.Drawing.Font(fonteBC, tamFonteBC);
                    break;

                case "IDAutomationHC39M":
                    fontBC = new System.Drawing.Font(fonteBC, tamFonteBC);
                    break;

                case "Free 3 of 9 Extended":
                    fontBC = new System.Drawing.Font(fonteBC, tamFonteBC);
                    break;

                default:
                    break;
            }

            fontN = new System.Drawing.Font(fonteN, tamFonte);
            StringFormat align = new StringFormat();
            StringFormat alignBC = new StringFormat();

            for (; k < Dados.chk.Count; k++)
            {
                if (etqCont == Dados.lrect.Count)
                {
                    e.HasMorePages = true;
                    return;
                }
                
                ///Codigo
                s = Dados.chk[k];
                if (fonteBC == "IDAutomationHC39M" || fonteBC == "Free 3 of 9 Extended")
                    s = "*" + s + "*";
                else if (fonteBC == "BCW_Code128A_2")
                    s = BarCodeFonts.Code128A(s.ToCharArray());


                ///alinhamento vertical
                alignBC.LineAlignment = StringAlignment.Center;

                ///alinhamento horizontal
                ///centro
                alignBC.Alignment = StringAlignment.Center;
                ///escreve o codigo no retangulo
                e.Graphics.DrawString(s, fontBC, Brushes.Black, Dados.lrect[rectCont], alignBC);

                ///Desenhar retangulo BRANCO
                ///para cobrir fonte NATIVA
                ///do BarCode
                ///Y = Y(do rect) + AlturaRect/2 + AlturaBarCode/5
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(Dados.lrect[rectCont].X, ((Dados.lrect[rectCont].Y) + (Dados.lrect[rectCont].Height / 2) + (fontBC.Height / 5)), Dados.lrect[rectCont].Width, (Dados.lrect[rectCont].Height / 4)));
                

                ///se a impressão é diferente de Somente codigo
                if (conteudo != "Somente Codigo")
                {
                    ///Nome
                    s = Dados.chk[k];

                    ///posiciona o nome abaixo do barcode
                    ///a altura é calculada de acordo com a etiqueta
                    ///não se altera com alinhamento
                    y = (Dados.lrect[rectCont].Y + ((Dados.lrect[rectCont].Height) / 2) + (fontBC.Height / 2));

                    ///Alinhamento
                    ///centro
                    align.Alignment = StringAlignment.Center;
                    ///posiciona no meio da etiqueta
                    x = (Dados.lrect[rectCont].X + ((Dados.lrect[rectCont].Width) / 2));
                    ///escreve a string logo abaixo do BarCode
                    e.Graphics.DrawString(s, fontN, Brushes.Black, x, ((Dados.lrect[rectCont].Y) + (Dados.lrect[rectCont].Height / 2) + (fontBC.Height / 4) /*+ 1*/), align);
                }

                ///Registrar o ultimo valor impresso
                ///para poder continuar de onde parou
                Dados.inicio = int.Parse(Dados.chk[k].Substring(Dados.prefixo.Length));

                ///Apenas teste, desenhar as etiquetas
                //Pen pen2 = new Pen(Brushes.Black);
                //e.Graphics.DrawRectangle(pen2, Dados.lrect[rectCont]);
                ///apagar ^
                etqCont++;
                rectCont++;
            }

            ///salvar o ultimo valor e quantidade impressos
            Dados.contETQ = etqCont;
            //ce.SalvaCont();
        }

        #endregion

        #region PrintDocument
        public void PrintDocument()
        {
            //Create an instance of our printer class
            Printing printer = new Printing();
            k = 0;
            ///Qual impressora vai imprimir
            printer.PrinterSettings.PrinterName = Dados.impressora;
            printer.DocumentName = "etiquetas";
            ///imprime
            printer.Print();
        }
        #endregion
    }

}
