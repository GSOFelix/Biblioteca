namespace Layout.View
{
    partial class UserControlUsuario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUsuario));
            bt_Salvar = new Button();
            label7 = new Label();
            text_idade = new TextBox();
            label4 = new Label();
            text_cpf = new TextBox();
            label3 = new Label();
            text_Nome = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            text_rua = new TextBox();
            text_bairro = new TextBox();
            label6 = new Label();
            text_numero = new TextBox();
            label8 = new Label();
            text_cidade = new TextBox();
            label9 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // bt_Salvar
            // 
            bt_Salvar.BackColor = Color.FromArgb(35, 40, 45);
            bt_Salvar.FlatAppearance.BorderSize = 0;
            bt_Salvar.FlatStyle = FlatStyle.Flat;
            bt_Salvar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Salvar.ForeColor = Color.White;
            bt_Salvar.Location = new Point(453, 331);
            bt_Salvar.Name = "bt_Salvar";
            bt_Salvar.Size = new Size(116, 40);
            bt_Salvar.TabIndex = 80;
            bt_Salvar.Text = "Salvar";
            bt_Salvar.UseVisualStyleBackColor = false;
            bt_Salvar.Click += bt_Salvar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(86, 219);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 29;
            label7.Text = "Rua:";
            // 
            // text_idade
            // 
            text_idade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_idade.Location = new Point(133, 180);
            text_idade.MaxLength = 3;
            text_idade.Name = "text_idade";
            text_idade.Size = new Size(75, 29);
            text_idade.TabIndex = 30;
            text_idade.KeyPress += text_idade_KeyPress;
            text_idade.Leave += text_idade_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(74, 184);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 23;
            label4.Text = "Idade:";
            // 
            // text_cpf
            // 
            text_cpf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_cpf.Location = new Point(133, 144);
            text_cpf.MaxLength = 11;
            text_cpf.Name = "text_cpf";
            text_cpf.Size = new Size(153, 29);
            text_cpf.TabIndex = 20;
            text_cpf.KeyPress += text_cpf_KeyPress;
            text_cpf.Leave += text_cpf_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(86, 149);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 20;
            label3.Text = "CPF:";
            // 
            // text_Nome
            // 
            text_Nome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_Nome.Location = new Point(133, 109);
            text_Nome.Name = "text_Nome";
            text_Nome.Size = new Size(350, 29);
            text_Nome.TabIndex = 10;
            text_Nome.KeyPress += text_Nome_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(75, 108);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 18;
            label2.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(190, 25);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 16;
            label1.Text = "Cadastro de Usuario";
            // 
            // text_rua
            // 
            text_rua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_rua.Location = new Point(133, 215);
            text_rua.Name = "text_rua";
            text_rua.Size = new Size(259, 29);
            text_rua.TabIndex = 40;
            text_rua.KeyPress += text_rua_KeyPress;
            // 
            // text_bairro
            // 
            text_bairro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_bairro.Location = new Point(133, 250);
            text_bairro.Name = "text_bairro";
            text_bairro.Size = new Size(259, 29);
            text_bairro.TabIndex = 60;
            text_bairro.KeyPress += text_bairro_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(70, 254);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 33;
            label6.Text = "Bairro:";
            // 
            // text_numero
            // 
            text_numero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_numero.Location = new Point(484, 219);
            text_numero.Name = "text_numero";
            text_numero.Size = new Size(76, 29);
            text_numero.TabIndex = 50;
            text_numero.KeyPress += text_numero_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(408, 223);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 35;
            label8.Text = "Número:";
            // 
            // text_cidade
            // 
            text_cidade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_cidade.Location = new Point(133, 285);
            text_cidade.Name = "text_cidade";
            text_cidade.Size = new Size(259, 29);
            text_cidade.TabIndex = 70;
            text_cidade.KeyPress += text_cidade_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(65, 289);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 37;
            label9.Text = "Cidade:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UserControlUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(text_cidade);
            Controls.Add(label9);
            Controls.Add(text_numero);
            Controls.Add(label8);
            Controls.Add(text_bairro);
            Controls.Add(label6);
            Controls.Add(text_rua);
            Controls.Add(bt_Salvar);
            Controls.Add(label7);
            Controls.Add(text_idade);
            Controls.Add(label4);
            Controls.Add(text_cpf);
            Controls.Add(label3);
            Controls.Add(text_Nome);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "UserControlUsuario";
            Size = new Size(594, 400);
            KeyPress += UserControlUsuario_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_Salvar;
        private Label label7;
        private TextBox text_idade;
        private Label label4;
        private TextBox text_cpf;
        private Label label3;
        private TextBox text_Nome;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox text_rua;
        private TextBox text_bairro;
        private Label label6;
        private TextBox text_numero;
        private Label label8;
        private TextBox text_cidade;
        private Label label9;
        private ErrorProvider errorProvider1;
    }
}
