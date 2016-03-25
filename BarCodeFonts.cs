using System;
using System.Windows.Forms;

namespace e2Etiquetas
{
    class BarCodeFonts
    {
        ///Conversão de bcode
        public static string Code128A(char[] codigo)
        {
            string encode = string.Empty;
            int asciiVal = 0;
            int bcVal = 0;
            int chkDigitTotal = 103;

            for (int i = 0; i < codigo.Length; i++)
            {
                asciiVal = (Convert.ToInt32(codigo[i]));
                if (asciiVal >= 32 && asciiVal <= 126)
                {
                    bcVal = asciiVal - 32;
                }

                encode += codigo[i];
                chkDigitTotal = chkDigitTotal + (bcVal * (i + 1));
            }

            chkDigitTotal = chkDigitTotal % 103;

            int bcChkDigitAscii;

            if (chkDigitTotal == 0)
                bcChkDigitAscii = 232;
            else if (chkDigitTotal >= 1 && chkDigitTotal <= 94)
                bcChkDigitAscii = chkDigitTotal + 32;
            else if (chkDigitTotal >= 95 && chkDigitTotal <= 99)
                bcChkDigitAscii = chkDigitTotal + 132;
            else if (chkDigitTotal >= 100 && chkDigitTotal <= 103)
                bcChkDigitAscii = chkDigitTotal + 100;

            encode = encode.Replace(" ", ((char)232).ToString());
            encode = "Ë" + encode + C128ToBars(chkDigitTotal) + "Î";

            return encode;
        }

        /// encode dos caracteres check
        public static string C128ToBars(int ascVal)
        {
            ///This function creates the check character bar-by-bar
            ///in order to hide the human readable text
            const string c = "212222222122222221121223121322" +
            "131222122213122312132212221213221312" +
            "231212112232122132122231113222123122" +
            "123221223211221132221231213212223112" +
            "312131311222321122321221312212322112" +
            "322211212123212321232121111323131123" +
            "131321112313132113132311211313231113" +
            "231311112133112331132131113123113321" +
            "133121313121211331231131213113213311" +
            "213131311123311321331121312113312311" +
            "332111314111221411431111111224111422" +
            "121124121421141122141221112214112412" +
            "122114122411142112142211241211221114" +
            "413111241112134111111242121142121241" +
            "114212124112124211411212421112421211" +
            "212141214121412121111143111341131141" +
            "114113114311411113411311113141114131" +
            "3111414111312114122112142112322331112";

            string posString;

            string ckDigitString = string.Empty;
            posString = c.Substring((6 * ascVal), 6);

            for (int i = 0; i <= 5; i++)
            {
                i++;
                if (i % 2 == 0)///Space
                {
                    i--;
                    switch (posString.Substring(i, 1))
                    {
                        case "1":
                            ckDigitString = ckDigitString + (char)184;
                            break;
                        case "2":
                            ckDigitString = ckDigitString + (char)185;
                            break;
                        case "3":
                            ckDigitString = ckDigitString + (char)186;
                            break;
                        case "4":
                            ckDigitString = ckDigitString + (char)187;
                            break;

                        default:
                            MessageBox.Show("Não foi possível gerar o BarCode!", "BarCode");
                            return "";
                    }
                }
                else
                {
                    i--;
                    switch (posString.Substring(i, 1))///bar
                    {
                        case "1":
                            ckDigitString = ckDigitString + (char)180;
                            break;
                        case "2":
                            ckDigitString = ckDigitString + (char)181;
                            break;
                        case "3":
                            ckDigitString = ckDigitString + (char)182;
                            break;
                        case "4":
                            ckDigitString = ckDigitString + (char)183;
                            break;

                        default:
                            MessageBox.Show("Não foi possível gerar o BarCode!", "BarCode");
                            return "";
                    }
                }
            }

            return ckDigitString;
        }

    }
}
