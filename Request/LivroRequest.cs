using Layout.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout.Request
{
    public class LivroRequest
    {
        public string Localizacao { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public int Autor_Id { get; set; }
        public int Ano { get; set; }
        public int Status { get; set; } = (int)EStatus.Disponivel;
        public string Tipo_Lieterario { get; set; } = string.Empty;
    }
}
