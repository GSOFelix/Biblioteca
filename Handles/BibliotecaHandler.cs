using Layout.Handles.Interfaces;
using Layout.Model;
using Layout.Request;
using Layout.Response;
using Layout.Service;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout.Handles
{
    public class BibliotecaHandler : IBibliotecaHandler
    {
        private readonly DataBaseService _dataBaseService;

        public BibliotecaHandler(DataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;

        }

        public async Task<Response<Autor?>> CreateAutor(AutorRequest request)
        {
            var autor = new Autor
            {
                Nome = request.nome,
            };

            try
            {
                using (var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    string query = "INSERT INTO AUTOR (NOME) VALUES (@NOME)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NOME", autor.Nome);
                        await cmd.ExecuteNonQueryAsync();
                    }

                    await conn.CloseAsync();
                }

                return new Response<Autor?>(autor, "Autor criado com sucesso.");
            }
            catch (MySqlException ex)
            {
                return new Response<Autor?>(null, $"Erro ao criar autor: {ex.Message}");
            }
            catch (Exception ex)
            {
                return new Response<Autor?>(null, $"Erro ao criar autor: {ex.Message}");
            }
        }

        public async Task<Response<Emprestimo?>> CreateEmprestimo(EmprestimoRequest request)
        {
            var emprestimo = new Emprestimo
            {
                User_Id = request.User_Id,
                Livro_Id = request.Livro_Id,
                Data_Emprestimo = request.Data_Emprestimo,
                Data_Retorno = request.Data_Retorno,
                Data_Status = request.Data_Status,
                Valor_Total = request.Valor_Total,
            };

            try
            {
                using (var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    string queryEmprestimo = "INSERT INTO EMPRESTIMOS " +
                        "(USUARIOS_ID,LIVROS_ID,DATA_EMPRESTIMO,DATA_RETORNO,DATA_STATUS,VALOR_TOTAL,VALOR_PAGO,MULTA)" +
                        "VALUES (@user,@livros,@dte,@dtr,@dts,@total,@pago,@multa)";

                    string queryStatus = "UPDATE LIVROS SET STATUS  = 1 WHERE ID = @livro_id";

                    using (var transaction = await conn.BeginTransactionAsync())
                    {
                        try
                        {
                            //Comando para inserir emprestimo na tabela EMPRESTIMO
                            using (var empCmd = new MySqlCommand(queryEmprestimo, conn, transaction))
                            {
                                empCmd.Parameters.AddWithValue("@user", emprestimo.User_Id);
                                empCmd.Parameters.AddWithValue("@livros", emprestimo.Livro_Id);
                                empCmd.Parameters.AddWithValue("@dte", emprestimo.Data_Emprestimo);
                                empCmd.Parameters.AddWithValue("@dtr", emprestimo.Data_Retorno);
                                empCmd.Parameters.AddWithValue("@dts", emprestimo.Data_Status);
                                empCmd.Parameters.AddWithValue("@total", emprestimo.Valor_Total);
                                empCmd.Parameters.AddWithValue("@pago", emprestimo.Valor_Pago);
                                empCmd.Parameters.AddWithValue("@multa", emprestimo.Multa);
                                await empCmd.ExecuteNonQueryAsync();
                            }
                            //Comando para atualizar o status do livro na tabela LIVRO.
                            using (var staCmd = new MySqlCommand(queryStatus, conn, transaction))
                            {
                                staCmd.Parameters.AddWithValue("@livro_id", emprestimo.Livro_Id);
                                await staCmd.ExecuteNonQueryAsync();
                            }
                            await transaction.CommitAsync();
                        }
                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            return new Response<Emprestimo?>(null, $"Erro ao salvar: {ex.Message}");
                        }
                        await conn.CloseAsync();
                    }
                }
                return new Response<Emprestimo?>(emprestimo, "Emprestimo criado com sucesso!");
            }
            catch (MySqlException ex)
            {
                return new Response<Emprestimo?>(null, $"Erro ao salvar: {ex.Message}");
            }
        }

        public async Task<Response<Livro?>> CreateLivro(LivroRequest request)
        {
            var livro = new Livro
            {
                Localizacao = request.Localizacao,
                Titulo = request.Titulo,
                Autor_Id = request.Autor_Id,
                Ano = request.Ano,
                Status = request.Status,
                Tipo_Lieterario = request.Tipo_Lieterario,
            };

            try
            {
                using (var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    string query = "INSERT INTO LIVROS (LOCALIZACAO,TITULO,AUTOR_ID,ANO,STATUS,TIPO_LITERARIO)" +
                        "VALUES (@LOC,@TITULO,@AUTOR,@ANO,@STATUS,@TIPO )";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LOC", livro.Localizacao);
                        cmd.Parameters.AddWithValue("@TITULO", livro.Titulo);
                        cmd.Parameters.AddWithValue("@AUTOR", livro.Autor_Id);
                        cmd.Parameters.AddWithValue("@ANO", livro.Ano);
                        cmd.Parameters.AddWithValue("@STATUS", livro.Status);
                        cmd.Parameters.AddWithValue("@TIPO", livro.Tipo_Lieterario);
                        await cmd.ExecuteNonQueryAsync();
                    }
                    await conn.CloseAsync();
                }

                return new Response<Livro?>(livro, "Livro cadastrado com sucesso.");
            }
            catch (MySqlException ex)
            {
                return new Response<Livro?>(null, $"Erro ao criar Livro: {ex.Message}");
            }
            catch (Exception ex)
            {
                return new Response<Livro?>(null, $"Erro ao criar Livro: {ex.Message}");
            }
        }

        public async Task<Response<Usuario?>> CreateUsuario(UsuarioRequest request)
        {
            var usuario = new Usuario
            {
                Nome = request.Nome,
                Cpf = request.Cpf,
                Idade = request.Idade,
                Rua = request.Rua,
                Bairro = request.Bairro,
                Numero = request.Numero,
                Cidade = request.Cidade,
            };

            try
            {
                using (var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    string query = "INSERT INTO USUARIOS (NOME,CPF,IDADE,RUA,BAIRRO,NUMERO,CIDADE)" +
                        "VALUES (@nome,@cpf,@idade,@rua,@bairro,@numero,@cidade)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                        cmd.Parameters.AddWithValue("@idade", usuario.Idade);
                        cmd.Parameters.AddWithValue("@rua", usuario.Rua);
                        cmd.Parameters.AddWithValue("@bairro", usuario.Bairro);
                        cmd.Parameters.AddWithValue("@numero", usuario.Numero);
                        cmd.Parameters.AddWithValue("@cidade", usuario.Cidade);
                        await cmd.ExecuteNonQueryAsync();
                    }
                    await conn.CloseAsync();
                }

                return new Response<Usuario?>(usuario, "Usuario criado com sucesso.");
            }
            catch (MySqlException ex)
            {
                return new Response<Usuario?>(null, $"Erro ao criar Usuário: {ex.Message}");
            }
            catch (Exception ex)
            {
                return new Response<Usuario?>(null, $"Erro ao criar Usuário: {ex.Message}");
            }
        }

        public async Task<DataTable> GetAll(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            await adapter.FillAsync(dt);
                        }
                    }
                    await conn.CloseAsync();
                }
                return dt;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public async Task<Response<Autor?>> GetAutorById(int Autor_id)
        {
            var autor = new Autor();    
            try
            {
                using(var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    string query = "SELECT  * FROM AUTOR WHERE ID = @ID";

                    using(var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", Autor_id);

                        using(var reader = await cmd.ExecuteReaderAsync())
                        {
                            if(await reader.ReadAsync())
                            {
                                autor.Id = (int)reader[0];
                                autor.Nome = reader[1].ToString();
                            }
                        }
                    }
                    await conn.CloseAsync();                    
                }
                return new Response<Autor?>(autor);
             
            }
            catch(MySqlException ex)
            {
                return new Response<Autor?>(null,$"erro: {ex.Message}");
            }
            catch(Exception ex)
            {
                return new Response<Autor?>(null, $"erro: {ex.Message}");
            }
        }

        public async Task<Response<Livro?>> GetLivroById(int livro_id)
        {
            var livro = new Livro();
            try
            {
                using (var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    string query = "SELECT ID,TITULO FROM LIVROS WHERE ID = @ID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", livro_id);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                livro.Id = (int)reader[0];
                                livro.Titulo = reader[1].ToString();
                            }
                        }
                    }
                    await conn.CloseAsync();
                }
                return new Response<Livro?>(livro);

            }
            catch (MySqlException ex)
            {
                return new Response<Livro?>(null, $"erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                return new Response<Livro?>(null, $"erro: {ex.Message}");
            }
        }

        public async Task<Response<Usuario?>> GetUsuarioById(int usuario_id)
        {
            var usuario = new Usuario();
            try
            {
                using (var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    string query = "SELECT ID,NOME FROM USUARIOS WHERE ID = @ID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", usuario_id);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                usuario.Id = (int)reader[0];
                                usuario.Nome = reader[1].ToString();
                            }
                        }
                    }
                    await conn.CloseAsync();
                }
                return new Response<Usuario?>(usuario);

            }
            catch (MySqlException ex)
            {
                return new Response<Usuario?>(null, $"erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                return new Response<Usuario?>(null, $"erro: {ex.Message}");
            }
        }

        public async Task<bool> VerificaStatus(int Livro_id)
        {
            int status = 0;
            try
            {
                using (var conn = _dataBaseService.GetConnection())
                {
                    await conn.OpenAsync();

                    string query = "SELECT STATUS FROM LIVROS WHERE ID  = @LIVRO_ID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@livro_id", Livro_id);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                status = Convert.ToInt32(reader[0]);
                            }

                        }
                    }
                    await conn.CloseAsync();
                }

                return status == 0;
            }
            catch (MySqlException ex)
            {
                return false;

            }
        }
    }
}
