using Layout.Model;
using Layout.Request;
using Layout.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout.Handles.Interfaces
{
    public interface IBibliotecaHandler
    {
        Task<Response<Autor?>> CreateAutor(AutorRequest request);
        Task<Response<Autor?>> GetAutorById(int Autor_id);
        Task<Response<Livro?>> CreateLivro(LivroRequest request);
        Task<Response<Livro?>> GetLivroById(int livro_id);
        Task<Response<Usuario?>> CreateUsuario(UsuarioRequest request);
        Task<Response<Usuario?>> GetUsuarioById(int usuario_id);
        Task<Response<Emprestimo?>> CreateEmprestimo(EmprestimoRequest request);
        Task<bool> VerificaStatus(int Livro_id);
        Task<DataTable> GetAll(string query); 
    }
}
