namespace Layout.Views
{
    partial class UserControlAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAutor));
            label1 = new Label();
            text_AutorNome = new TextBox();
            label2 = new Label();
            bt_salvar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(158, 12);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Autor";
            // 
            // text_AutorNome
            // 
            text_AutorNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_AutorNome.Location = new Point(128, 120);
            text_AutorNome.Name = "text_AutorNome";
            text_AutorNome.Size = new Size(350, 29);
            text_AutorNome.TabIndex = 10;
            text_AutorNome.KeyPress += text_AutorNome_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(13, 124);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Nome Autor:";
            // 
            // bt_salvar
            // 
            bt_salvar.BackColor = Color.FromArgb(35, 40, 45);
            bt_salvar.FlatAppearance.BorderSize = 0;
            bt_salvar.FlatStyle = FlatStyle.Flat;
            bt_salvar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_salvar.ForeColor = Color.White;
            bt_salvar.Location = new Point(147, 214);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(234, 40);
            bt_salvar.TabIndex = 20;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = false;
            bt_salvar.Click += bt_salvar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // UserControlAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(bt_salvar);
            Controls.Add(text_AutorNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlAutor";
            Size = new Size(505, 294);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox text_AutorNome;
        private Label label2;
        private Button bt_salvar;
        private PictureBox pictureBox1;
    }
}
