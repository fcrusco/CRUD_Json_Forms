namespace CrudJsonWinForms
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
            lblNome = new Label();
            lblSobrenome = new Label();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            lstPessoas = new ListBox();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(0, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(0, 46);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(86, 20);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(408, 263);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(508, 263);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(608, 263);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.Location = new Point(12, 85);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(689, 164);
            lstPessoas.TabIndex = 5;
            lstPessoas.SelectedIndexChanged += lstPessoas_SelectedIndexChanged;
            lstPessoas.DoubleClick += lstPessoas_DoubleClick;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(95, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(606, 27);
            txtNome.TabIndex = 6;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(95, 39);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(606, 27);
            txtSobrenome.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 299);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lstPessoas);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "CRUD - Windows Forms - Json";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private ListBox lstPessoas;
        private TextBox txtNome;
        private TextBox txtSobrenome;
    }
}
