namespace Layout
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuLateral = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            bt_menu = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            bt_Livro = new Button();
            panel4 = new Panel();
            bt_Usuario = new Button();
            panel5 = new Panel();
            bt_emprestimo = new Button();
            panel3 = new Panel();
            bt_sair = new Button();
            menuLateralTimer = new System.Windows.Forms.Timer(components);
            containerPai = new Panel();
            menuLateral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bt_menu).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuLateral
            // 
            menuLateral.BackColor = Color.FromArgb(35, 40, 45);
            menuLateral.Controls.Add(panel1);
            menuLateral.Controls.Add(panel2);
            menuLateral.Controls.Add(panel4);
            menuLateral.Controls.Add(panel5);
            menuLateral.Controls.Add(panel3);
            menuLateral.Dock = DockStyle.Left;
            menuLateral.Location = new Point(0, 0);
            menuLateral.MaximumSize = new Size(165, 447);
            menuLateral.MinimumSize = new Size(68, 447);
            menuLateral.Name = "menuLateral";
            menuLateral.Size = new Size(165, 447);
            menuLateral.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bt_menu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // bt_menu
            // 
            bt_menu.Image = (Image)resources.GetObject("bt_menu.Image");
            bt_menu.Location = new Point(14, 26);
            bt_menu.Name = "bt_menu";
            bt_menu.Size = new Size(45, 39);
            bt_menu.SizeMode = PictureBoxSizeMode.Zoom;
            bt_menu.TabIndex = 0;
            bt_menu.TabStop = false;
            bt_menu.Click += bt_menu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(bt_Livro);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 59);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 174);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(210, 79);
            button2.TabIndex = 2;
            button2.Text = "            Autor";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // bt_Livro
            // 
            bt_Livro.FlatStyle = FlatStyle.Flat;
            bt_Livro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Livro.Image = (Image)resources.GetObject("bt_Livro.Image");
            bt_Livro.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Livro.Location = new Point(-16, -9);
            bt_Livro.Name = "bt_Livro";
            bt_Livro.Padding = new Padding(35, 0, 0, 0);
            bt_Livro.Size = new Size(210, 79);
            bt_Livro.TabIndex = 1;
            bt_Livro.TabStop = false;
            bt_Livro.Text = "          Livro";
            bt_Livro.TextAlign = ContentAlignment.MiddleLeft;
            bt_Livro.UseVisualStyleBackColor = true;
            bt_Livro.Click += bt_Livro_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(bt_Usuario);
            panel4.Location = new Point(3, 174);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 59);
            panel4.TabIndex = 1;
            // 
            // bt_Usuario
            // 
            bt_Usuario.FlatStyle = FlatStyle.Flat;
            bt_Usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Usuario.Image = (Image)resources.GetObject("bt_Usuario.Image");
            bt_Usuario.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Usuario.Location = new Point(-16, -9);
            bt_Usuario.Name = "bt_Usuario";
            bt_Usuario.Padding = new Padding(36, 0, 0, 0);
            bt_Usuario.Size = new Size(210, 79);
            bt_Usuario.TabIndex = 3;
            bt_Usuario.TabStop = false;
            bt_Usuario.Text = "         Usuário";
            bt_Usuario.TextAlign = ContentAlignment.MiddleLeft;
            bt_Usuario.UseVisualStyleBackColor = true;
            bt_Usuario.Click += bt_Usuario_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(bt_emprestimo);
            panel5.Location = new Point(3, 239);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 59);
            panel5.TabIndex = 1;
            // 
            // bt_emprestimo
            // 
            bt_emprestimo.FlatStyle = FlatStyle.Flat;
            bt_emprestimo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_emprestimo.Image = (Image)resources.GetObject("bt_emprestimo.Image");
            bt_emprestimo.ImageAlign = ContentAlignment.MiddleLeft;
            bt_emprestimo.Location = new Point(-16, -10);
            bt_emprestimo.Name = "bt_emprestimo";
            bt_emprestimo.Padding = new Padding(35, 0, 0, 0);
            bt_emprestimo.Size = new Size(210, 79);
            bt_emprestimo.TabIndex = 4;
            bt_emprestimo.TabStop = false;
            bt_emprestimo.Text = "         Empréstimo";
            bt_emprestimo.TextAlign = ContentAlignment.MiddleLeft;
            bt_emprestimo.UseVisualStyleBackColor = true;
            bt_emprestimo.Click += bt_emprestimo_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(bt_sair);
            panel3.Location = new Point(3, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 59);
            panel3.TabIndex = 3;
            // 
            // bt_sair
            // 
            bt_sair.FlatStyle = FlatStyle.Flat;
            bt_sair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_sair.Image = (Image)resources.GetObject("bt_sair.Image");
            bt_sair.ImageAlign = ContentAlignment.MiddleLeft;
            bt_sair.Location = new Point(-16, -10);
            bt_sair.Name = "bt_sair";
            bt_sair.Padding = new Padding(35, 0, 0, 0);
            bt_sair.Size = new Size(210, 79);
            bt_sair.TabIndex = 4;
            bt_sair.TabStop = false;
            bt_sair.Text = "         Sair";
            bt_sair.TextAlign = ContentAlignment.MiddleLeft;
            bt_sair.UseVisualStyleBackColor = true;
            bt_sair.Click += bt_sair_Click;
            // 
            // menuLateralTimer
            // 
            menuLateralTimer.Interval = 10;
            menuLateralTimer.Tick += menuLateralTimer_Tick;
            // 
            // containerPai
            // 
            containerPai.Dock = DockStyle.Fill;
            containerPai.Location = new Point(165, 0);
            containerPai.Name = "containerPai";
            containerPai.Size = new Size(594, 400);
            containerPai.TabIndex = 1;
            containerPai.TabStop = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(759, 400);
            Controls.Add(containerPai);
            Controls.Add(menuLateral);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyPress += Form1_KeyPress;
            menuLateral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bt_menu).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel menuLateral;
        private Panel panel1;
        private Panel panel2;
        private Button bt_Livro;
        private Button button2;
        private Panel panel4;
        private Button bt_Usuario;
        private Panel panel5;
        private Button bt_emprestimo;
        private PictureBox bt_menu;
        private Label label1;
        private System.Windows.Forms.Timer menuLateralTimer;
        private Panel containerPai;
        private Panel panel3;
        private Button bt_sair;
    }
}
