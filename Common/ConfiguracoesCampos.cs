using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout.common
{
    public class ConfiguracoesCampos
    {
        public static string MascaraCpf(string cpf)
        {
            string cpfFormatado = "";

            for (int i = 0; i < cpf.Length; i++)
            {
                cpfFormatado += cpf[i];

                if (i == 2 || i == 5)
                    cpfFormatado += ".";

                if (i == 8)
                    cpfFormatado += "-";
            }
            return cpfFormatado;
        }

        public static void LimpaCampos(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        public static string MascaraData(string data)
        {
            if (DateTime.TryParseExact(data, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataConvertida))
            {

                return dataConvertida.ToString("dd/MM/yyyy");
            }

            return data;

        }

        public static string MascaraDecimal(string valor)
        {
            bool decimalConvert = decimal.TryParse(valor, out decimal valorFormatado);

            if (decimalConvert)
            {
                return valorFormatado.ToString("C");
            }

            return valor;

        }
    }
}
