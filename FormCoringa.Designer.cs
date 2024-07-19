namespace Layout
{
    partial class FormCoringa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCoringa = new Panel();
            SuspendLayout();
            // 
            // panelCoringa
            // 
            panelCoringa.Dock = DockStyle.Fill;
            panelCoringa.Location = new Point(0, 0);
            panelCoringa.Name = "panelCoringa";
            panelCoringa.Size = new Size(505, 294);
            panelCoringa.TabIndex = 0;
            // 
            // FormCoringa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 294);
            Controls.Add(panelCoringa);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCoringa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCoringa";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCoringa;
    }
}