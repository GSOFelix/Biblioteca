namespace Layout.View
{
    partial class UserControlEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEmprestimo));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            text_dataEmp = new TextBox();
            label4 = new Label();
            text_UserNome = new TextBox();
            text_UserId = new TextBox();
            label3 = new Label();
            text_LivroNome = new TextBox();
            text_LivroId = new TextBox();
            label2 = new Label();
            text_dataRet = new TextBox();
            label5 = new Label();
            text_Total = new TextBox();
            label6 = new Label();
            bt_salvar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(258, 39);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 2;
            label1.Text = "Emprestimo";
            // 
            // text_dataEmp
            // 
            text_dataEmp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_dataEmp.Location = new Point(156, 214);
            text_dataEmp.Name = "text_dataEmp";
            text_dataEmp.Size = new Size(108, 29);
            text_dataEmp.TabIndex = 20;
            text_dataEmp.KeyPress += text_dataEmp_KeyPress;
            text_dataEmp.Leave += text_dataEmp_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(14, 218);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 16;
            label4.Text = "Data Emprestimo:";
            // 
            // text_UserNome
            // 
            text_UserNome.Enabled = false;
            text_UserNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_UserNome.Location = new Point(213, 138);
            text_UserNome.Name = "text_UserNome";
            text_UserNome.Size = new Size(293, 29);
            text_UserNome.TabIndex = 15;
            text_UserNome.TabStop = false;
            // 
            // text_UserId
            // 
            text_UserId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_UserId.Location = new Point(156, 138);
            text_UserId.Name = "text_UserId";
            text_UserId.Size = new Size(51, 29);
            text_UserId.TabIndex = 10;
            text_UserId.KeyDown += text_UserId_KeyDown;
            text_UserId.KeyPress += text_UserId_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(78, 142);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 13;
            label3.Text = "Usuário:";
            // 
            // text_LivroNome
            // 
            text_LivroNome.Enabled = false;
            text_LivroNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_LivroNome.Location = new Point(213, 173);
            text_LivroNome.Name = "text_LivroNome";
            text_LivroNome.Size = new Size(293, 29);
            text_LivroNome.TabIndex = 20;
            text_LivroNome.TabStop = false;
            // 
            // text_LivroId
            // 
            text_LivroId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_LivroId.Location = new Point(156, 173);
            text_LivroId.Name = "text_LivroId";
            text_LivroId.Size = new Size(51, 29);
            text_LivroId.TabIndex = 20;
            text_LivroId.KeyDown += text_LivroId_KeyDown;
            text_LivroId.KeyPress += text_LivroId_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(97, 177);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 18;
            label2.Text = "Livro:";
            // 
            // text_dataRet
            // 
            text_dataRet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_dataRet.Location = new Point(156, 253);
            text_dataRet.Name = "text_dataRet";
            text_dataRet.Size = new Size(108, 29);
            text_dataRet.TabIndex = 30;
            text_dataRet.KeyPress += text_dataRet_KeyPress;
            text_dataRet.Leave += text_dataRet_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(40, 257);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 21;
            label5.Text = "Data Retorno:";
            // 
            // text_Total
            // 
            text_Total.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            text_Total.Location = new Point(156, 297);
            text_Total.Name = "text_Total";
            text_Total.Size = new Size(108, 29);
            text_Total.TabIndex = 40;
            text_Total.KeyPress += text_Total_KeyPress;
            text_Total.Leave += text_Total_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(58, 301);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 23;
            label6.Text = "Valor Total:";
            // 
            // bt_salvar
            // 
            bt_salvar.BackColor = Color.FromArgb(35, 40, 45);
            bt_salvar.FlatAppearance.BorderSize = 0;
            bt_salvar.FlatStyle = FlatStyle.Flat;
            bt_salvar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_salvar.ForeColor = Color.White;
            bt_salvar.Location = new Point(418, 287);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(134, 48);
            bt_salvar.TabIndex = 50;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = false;
            bt_salvar.Click += bt_salvar_Click;
            // 
            // UserControlEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(bt_salvar);
            Controls.Add(text_Total);
            Controls.Add(label6);
            Controls.Add(text_dataRet);
            Controls.Add(label5);
            Controls.Add(text_LivroNome);
            Controls.Add(text_LivroId);
            Controls.Add(label2);
            Controls.Add(text_dataEmp);
            Controls.Add(label4);
            Controls.Add(text_UserNome);
            Controls.Add(text_UserId);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "UserControlEmprestimo";
            Size = new Size(594, 400);
            Load += UserControlEmprestimo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox text_dataEmp;
        private Label label4;
        private TextBox text_UserNome;
        private TextBox text_UserId;
        private Label label3;
        private TextBox text_LivroNome;
        private TextBox text_LivroId;
        private Label label2;
        private TextBox text_dataRet;
        private Label label5;
        private TextBox text_Total;
        private Label label6;
        private Button bt_salvar;
    }
}
