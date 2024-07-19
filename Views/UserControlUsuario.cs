using Layout.common;
using Layout.Handles;
using Layout.Handles.Interfaces;
using Layout.Request;
using Layout.Service;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout.View
{
    public partial class UserControlUsuario : UserControl
    {
        private readonly IBibliotecaHandler _handler;
        private bool semErros = false;

        public UserControlUsuario()
        {
            InitializeComponent();
            var dataBaseService = new DataBaseService(ConfiguracoesForm.connectionString);
            _handler = new BibliotecaHandler(dataBaseService);
        }

        private void text_cpf_Leave(object sender, EventArgs e)
        {
            bool cpfInformado = long.TryParse(text_cpf.Text, out long cpf);

            if (cpfInformado && text_cpf.Text.Length == 11)
            {
                semErros = true;
                text_cpf.Text = ConfiguracoesCampos.MascaraCpf(text_cpf.Text);
            }
            else
            {
                errorProvider1.SetError(text_cpf, "Informe apenas números para CPF e com tamanho de 11");
                semErros = false;
            }


        }

        private void text_idade_Leave(object sender, EventArgs e)
        {
            bool idadeInformada = int.TryParse(text_idade.Text, out int idade);

            if (!idadeInformada)
            {
                errorProvider1.SetError(text_idade, "Por favor, insira um número válido para a idade.");
                semErros = false;
            }
            else
            {
                semErros = true;
                errorProvider1.Dispose();
            }

        }

        private async void bt_Salvar_Click(object sender, EventArgs e)
        {
            #region Validações
            if (!semErros)
            {
                MessageBox.Show("Campos com erros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(text_Nome.Text) ||
               string.IsNullOrEmpty(text_cpf.Text) ||
               string.IsNullOrEmpty(text_idade.Text) ||
               string.IsNullOrEmpty(text_rua.Text) ||
               string.IsNullOrEmpty(text_numero.Text) ||
               string.IsNullOrEmpty(text_bairro.Text) ||
               string.IsNullOrEmpty(text_cidade.Text))
            {
                MessageBox.Show("Existem campos em branco!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            var usuario = new UsuarioRequest
            {
                Nome = text_Nome.Text,
                Cpf = text_cpf.Text.Replace(".", "").Replace("-", ""),
                Idade = Convert.ToInt32(text_idade.Text),
                Rua = text_rua.Text,
                Numero = text_numero.Text,
                Bairro = text_bairro.Text,
                Cidade = text_cidade.Text,
            };

            try
            {
                var result = await _handler.CreateUsuario(usuario);

                if (result.Data is not null)
                {
                    MessageBox.Show($"{result.Menssage}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{result.Menssage}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ConfiguracoesCampos.LimpaCampos(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region KeyPress
        private void UserControlUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_rua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        private void text_cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
        #endregion
    }
}
