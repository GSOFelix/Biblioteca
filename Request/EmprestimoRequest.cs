using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout.Request
{
    public class EmprestimoRequest
    {
        public int User_Id { get; set; }

        public int Livro_Id { get; set; }

        public DateTime Data_Emprestimo { get; set; }

        public DateTime Data_Retorno { get; set; }

        public DateTime Data_Status { get; set; } = DateTime.Now;

        public decimal Valor_Total { get; set; }
    }
}
