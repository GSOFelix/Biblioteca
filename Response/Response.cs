using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout.Response
{
    public class Response<TData>
    {
        public Response() { }
        public Response(TData? data, string? menssage = null)
        {
            Data = data;
            Menssage = menssage;

        }

        public TData? Data { get; set; }

        public string? Menssage { get; set; }
    }
}
