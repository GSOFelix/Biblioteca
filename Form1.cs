using Layout.common;
using Layout.View;

namespace Layout
{
    public partial class Form1 : Form
    {
        bool menuLateralExpand = true;
        UserControlLivro livro;
        UserControlUsuario usuario;
        UserControlEmprestimo emprestimo;

        public Form1()
        {
            InitializeComponent();
            ConfiguracoesForm.ArredondarBordas(menuLateral, 15);
            ConfiguracoesForm.ArredondarBordas(this, 15);
            ConfiguracoesForm.LoadControls(new UserControlHome(), containerPai);
            livro = new UserControlLivro();
            usuario = new UserControlUsuario();
            emprestimo = new UserControlEmprestimo();
        }

        private void menuLateralTimer_Tick(object sender, EventArgs e)
        {
            if (menuLateralExpand)
            {
                menuLateral.Width -= 10;
                if (menuLateral.Width == menuLateral.MinimumSize.Width)
                {
                    menuLateralExpand = false;
                    menuLateralTimer.Stop();
                }
            }
            else
            {
                menuLateral.Width += 10;
                if (menuLateral.Width == menuLateral.MaximumSize.Width)
                {
                    menuLateralExpand = true;
                    menuLateralTimer.Stop();
                }
            }
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            menuLateralTimer.Start();

        }

        private void bt_Livro_Click(object sender, EventArgs e)
        {
            livro.Dock = DockStyle.Fill;
            containerPai.Controls.Clear();
            containerPai.Controls.Add(livro);
        }

        private void bt_Usuario_Click(object sender, EventArgs e)
        {
            usuario.Dock = DockStyle.Fill;
            containerPai.Controls.Clear();
            containerPai.Controls.Add(usuario);
        }

        private void bt_emprestimo_Click(object sender, EventArgs e)
        {
            emprestimo.Dock = DockStyle.Fill;
            containerPai.Controls.Clear();
            containerPai.Controls.Add(emprestimo);
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
