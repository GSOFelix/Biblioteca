using Layout.Model;
using Layout.Request;
using Layout.Response;
using System.Data;


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
        Task<Response<bool>> VerificaStatus(int Livro_id);
        Task<Response<DataTable?>> GetAll(string query); 
    }
}
