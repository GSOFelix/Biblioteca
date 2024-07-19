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

namespace Layout.Views
{
    public partial class UserControlAutor : UserControl
    {
        private readonly IBibliotecaHandler _handler;
        public UserControlAutor()
        {
            InitializeComponent();
            var dataBaseService = new DataBaseService(ConfiguracoesForm.connectionString);
            _handler = new BibliotecaHandler(dataBaseService);
        }

        private async void bt_salvar_Click(object sender, EventArgs e)
        {
            var autor = new AutorRequest
            {
                nome = text_AutorNome.Text,
            };

            try
            {
                var result = await _handler.CreateAutor(autor);
                if (result.Data is not null)
                {
                    MessageBox.Show($"{result.Menssage}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{result.Menssage}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                text_AutorNome.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_AutorNome.Clear();
            }
        }

        private void text_AutorNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
    }
}
