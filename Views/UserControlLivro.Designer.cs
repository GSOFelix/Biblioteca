namespace Layout.View
{
    partial class UserControlLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLivro));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            text_titulo = new TextBox();
            label3 = new Label();
            text_autor = new TextBox();
            text_autorNome = new TextBox();
            text_localizacao = new TextBox();
            label4 = new Label();
            text_ano = new TextBox();
            label5 = new Label();
            text_tipoLit = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cb_status = new ComboBox();
            bt_salvar = new Button();
            bt_novoAutor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(200, 25);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Livros";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(83, 121);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Titulo:";
            // 
            // text_titulo
            // 
            text_titulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_titulo.Location = new Point(143, 117);
            text_titulo.Name = "text_titulo";
            text_titulo.Size = new Size(350, 29);
            text_titulo.TabIndex = 10;
            text_titulo.KeyPress += text_titulo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(84, 157);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Autor:";
            // 
            // text_autor
            // 
            text_autor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_autor.Location = new Point(143, 153);
            text_autor.Name = "text_autor";
            text_autor.Size = new Size(51, 29);
            text_autor.TabIndex = 20;
            text_autor.KeyDown += text_autor_KeyDown;
            text_autor.KeyPress += text_autor_KeyPress;
            text_autor.Leave += text_autor_Leave;
            // 
            // text_autorNome
            // 
            text_autorNome.Enabled = false;
            text_autorNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_autorNome.Location = new Point(200, 153);
            text_autorNome.Name = "text_autorNome";
            text_autorNome.Size = new Size(293, 29);
            text_autorNome.TabIndex = 6;
            text_autorNome.TabStop = false;
            // 
            // text_localizacao
            // 
            text_localizacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_localizacao.Location = new Point(143, 188);
            text_localizacao.Name = "text_localizacao";
            text_localizacao.Size = new Size(350, 29);
            text_localizacao.TabIndex = 30;
            text_localizacao.KeyPress += text_localizacao_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(46, 192);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 7;
            label4.Text = "Localização:";
            // 
            // text_ano
            // 
            text_ano.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_ano.Location = new Point(143, 223);
            text_ano.Name = "text_ano";
            text_ano.Size = new Size(73, 29);
            text_ano.TabIndex = 40;
            text_ano.KeyPress += text_ano_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(96, 227);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 9;
            label5.Text = "Ano:";
            // 
            // text_tipoLit
            // 
            text_tipoLit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_tipoLit.Location = new Point(143, 301);
            text_tipoLit.Name = "text_tipoLit";
            text_tipoLit.Size = new Size(350, 29);
            text_tipoLit.TabIndex = 50;
            text_tipoLit.KeyPress += text_tipoLit_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(33, 301);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 11;
            label6.Text = "Tipo Literario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(83, 263);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 13;
            label7.Text = "Status:";
            // 
            // cb_status
            // 
            cb_status.Enabled = false;
            cb_status.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(143, 260);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(121, 28);
            cb_status.TabIndex = 14;
            cb_status.TabStop = false;
            // 
            // bt_salvar
            // 
            bt_salvar.BackColor = Color.FromArgb(35, 40, 45);
            bt_salvar.FlatAppearance.BorderSize = 0;
            bt_salvar.FlatStyle = FlatStyle.Flat;
            bt_salvar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_salvar.ForeColor = Color.White;
            bt_salvar.Location = new Point(465, 348);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(116, 40);
            bt_salvar.TabIndex = 60;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = false;
            bt_salvar.Click += bt_salvar_Click;
            // 
            // bt_novoAutor
            // 
            bt_novoAutor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_novoAutor.Location = new Point(499, 154);
            bt_novoAutor.Name = "bt_novoAutor";
            bt_novoAutor.Size = new Size(43, 28);
            bt_novoAutor.TabIndex = 16;
            bt_novoAutor.TabStop = false;
            bt_novoAutor.Text = "...";
            bt_novoAutor.UseVisualStyleBackColor = true;
            bt_novoAutor.Click += bt_novoAutor_Click;
            // 
            // UserControlLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(bt_novoAutor);
            Controls.Add(bt_salvar);
            Controls.Add(cb_status);
            Controls.Add(label7);
            Controls.Add(text_tipoLit);
            Controls.Add(label6);
            Controls.Add(text_ano);
            Controls.Add(label5);
            Controls.Add(text_localizacao);
            Controls.Add(label4);
            Controls.Add(text_autorNome);
            Controls.Add(text_autor);
            Controls.Add(label3);
            Controls.Add(text_titulo);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.Maroon;
            Name = "UserControlLivro";
            Size = new Size(594, 400);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox text_titulo;
        private Label label3;
        private TextBox text_autor;
        private TextBox text_autorNome;
        private TextBox text_localizacao;
        private Label label4;
        private TextBox text_ano;
        private Label label5;
        private TextBox text_tipoLit;
        private Label label6;
        private Label label7;
        private ComboBox cb_status;
        private Button bt_salvar;
        private Button bt_novoAutor;
    }
}
