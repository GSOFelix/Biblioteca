using Layout.common;
using Layout.Handles;
using Layout.Handles.Interfaces;
using Layout.Model;
using Layout.Request;
using Layout.Service;
using Layout.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout.View
{
    public partial class UserControlEmprestimo : UserControl
    {
        private readonly IBibliotecaHandler _handler;


        public UserControlEmprestimo()
        {
            InitializeComponent();
            var dataBaseService = new DataBaseService(ConfiguracoesForm.connectionString);
            _handler = new BibliotecaHandler(dataBaseService);
        }

        private void UserControlEmprestimo_Load(object sender, EventArgs e)
        {

        }

        private async void text_UserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(text_UserId.Text))
            {
                text_UserNome.Text = "";
            }

            if (e.KeyCode == Keys.A)
            {
                text_UserId.Text = "";

                DataTable? dt = new DataTable();

                string query = "SELECT ID,NOME FROM USUARIOS ORDER BY NOME";

                try
                {
                    var request = await _handler.GetAll(query);
                    dt = request.Data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro : {ex.Message}");
                }
                
                FormPesquisa pesquisa = new FormPesquisa(dt);

                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    int ID = pesquisa.SelectId;
                    string? nome = pesquisa.Nome;

                    text_UserId.Text = ID.ToString();
                    text_UserNome.Text = nome;
                }
            }
        }

        private async void text_LivroId_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(text_LivroId.Text))
            {
                text_LivroNome.Text = "";
            }

            if (e.KeyCode == Keys.A)
            {
                text_LivroId.Text = "";

                DataTable? dt = new DataTable();

                string query = "SELECT ID,TITULO,STATUS FROM LIVROS ORDER BY TITULO";
                try
                {
                    var request = await _handler.GetAll(query);

                    dt = request.Data;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"erro: {ex.Message}");
                }
                
                FormPesquisa pesquisa = new FormPesquisa(dt);

                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    int ID = pesquisa.SelectId;
                    string? nome = pesquisa.Nome;

                    text_LivroId.Text = ID.ToString();
                    text_LivroNome.Text = nome;
                }
            }
        }

        private void text_dataEmp_Leave(object sender, EventArgs e)
        {
            text_dataEmp.Text = ConfiguracoesCampos.MascaraData(text_dataEmp.Text);
        }

        private void text_dataRet_Leave(object sender, EventArgs e)
        {
            text_dataRet.Text = ConfiguracoesCampos.MascaraData(text_dataRet.Text);
        }

        private void text_Total_Leave(object sender, EventArgs e)
        {
            text_Total.Text = ConfiguracoesCampos.MascaraDecimal(text_Total.Text);
        }

        private async void bt_salvar_Click(object sender, EventArgs e)
        {
            DateTime dataEmprestimo;
            DateTime dataRetorno;
            decimal valorTotal;
            int userId;
            int livroId;

            bool usuarioValido = int.TryParse(text_UserId.Text, out userId);
            bool livroValido = int.TryParse(text_LivroId.Text, out livroId);
            bool dataEmprestimoValida = DateTime.TryParseExact(text_dataEmp.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataEmprestimo);
            bool dataRetornoValida = DateTime.TryParseExact(text_dataRet.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataRetorno);
            bool valorTotalValido = decimal.TryParse(text_Total.Text.Replace("R$ ", ""), out valorTotal);

            #region Validações
            if (string.IsNullOrEmpty(text_UserId.Text) ||
               string.IsNullOrEmpty(text_LivroId.Text) ||
               string.IsNullOrEmpty(text_dataEmp.Text) ||
               string.IsNullOrEmpty(text_dataRet.Text) ||
               string.IsNullOrEmpty(text_Total.Text))
            {
                MessageBox.Show("Os campos não podem ficar em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dataEmprestimoValida || !dataRetornoValida || !valorTotalValido)
            {
                MessageBox.Show("Por favor, insira dados válidos nos campos de data e valor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!usuarioValido || !livroValido)
            {
                MessageBox.Show("Por favor, insira dados válidos nos campos de Usuário e Livro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var status = await _handler.VerificaStatus(livroId);
            if (!status.Data)
            {
                MessageBox.Show("Livro Indisponivel para emprestimo");
                return;
            }
            #endregion


            var request = new EmprestimoRequest
            {
                User_Id = userId,
                Livro_Id = livroId,
                Data_Emprestimo = dataEmprestimo,
                Data_Retorno = dataRetorno,
                Valor_Total = valorTotal,
            };

            try
            {
                var emprestimo = await _handler.CreateEmprestimo(request);

                if (emprestimo.Data is not null)
                {
                    MessageBox.Show($"{emprestimo.Menssage}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{emprestimo.Menssage}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                ConfiguracoesCampos.LimpaCampos(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_UserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_LivroId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_dataEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_dataRet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
    }
}
