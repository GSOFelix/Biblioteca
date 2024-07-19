using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout.Model
{
    public class Emprestimo
    {
        public int User_Id { get; set; }

        public int Livro_Id { get; set; }

        public DateTime Data_Emprestimo { get; set; }

        public DateTime Data_Retorno { get; set; }

        public DateTime Data_Status { get; set; }

        public decimal Valor_Total { get; set; }

        public decimal Valor_Pago { get; set; } = 0.00m;

        public decimal Multa { get; set; } = 0.00m;
    }
}
