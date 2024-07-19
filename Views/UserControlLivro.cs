using Layout.common;
using Layout.Enums;
using Layout.Handles;
using Layout.Handles.Interfaces;
using Layout.Request;
using Layout.Service;
using Layout.Views;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout.View
{
    public partial class UserControlLivro : UserControl
    {
        private readonly IBibliotecaHandler _handler;
        public UserControlLivro()
        {
            InitializeComponent();
            var dataBaseService = new DataBaseService(ConfiguracoesForm.connectionString);
            _handler = new BibliotecaHandler(dataBaseService);
            cb_status.Text = EStatus.Disponivel.ToString();
        }

        private void bt_novoAutor_Click(object sender, EventArgs e)
        {
            FormCoringa coringa = new FormCoringa("Cadastro de Autor", new UserControlAutor());
            coringa.ShowDialog();
        }

        private async void text_autor_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(text_autor.Text))
            {
                text_autorNome.Text = "";
            }

            if (e.KeyCode == Keys.A)
            {
                text_autor.Text = "";

                DataTable? dt = new DataTable();

                string query = "SELECT * FROM AUTOR ORDER BY NOME";

                try
                {
                    var request = await _handler.GetAll(query);
                    dt = request.Data;
                }
                catch(Exception ex) 
                {
                    MessageBox.Show($"{ex.Message}");
                }

                FormPesquisa pesquisa = new FormPesquisa(dt);

                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    int ID = pesquisa.SelectId;
                    string? nome = pesquisa.Nome;

                    text_autor.Text = ID.ToString();
                    text_autorNome.Text = nome;
                }
            }
        }

        #region KeyPress
        private void text_titulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_autor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_localizacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_tipoLit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
        #endregion

        private async void bt_salvar_Click(object sender, EventArgs e)
        {
            #region Validações
            if (string.IsNullOrEmpty(text_titulo.Text) ||
                string.IsNullOrEmpty(text_autorNome.Text) ||
                string.IsNullOrEmpty(text_localizacao.Text) ||
                string.IsNullOrEmpty(text_ano.Text) ||
                string.IsNullOrEmpty(text_tipoLit.Text))
            {
                MessageBox.Show("Existem campos em branco!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(text_ano.Text, out int ano))
            {
                MessageBox.Show("Campo \"ANO\" deve ser númerico!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            var request = new LivroRequest
            {
                Titulo = text_titulo.Text,
                Autor_Id = Convert.ToInt32(text_autor.Text),
                Localizacao = text_localizacao.Text,
                Ano = ano
            };

            try
            {
                var livro = await _handler.CreateLivro(request);

                if (livro.Data is not null)
                {
                    MessageBox.Show($"{livro.Menssage}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{livro.Menssage}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ConfiguracoesCampos.LimpaCampos(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void text_autor_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(text_autor.Text) && int.TryParse(text_autor.Text,out int auto_id))
            {
                try
                {
                    var autor = await _handler.GetAutorById(auto_id);

                    if (autor.Data is not null)
                    {
                        text_autorNome.Text = autor.Data.Nome;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
