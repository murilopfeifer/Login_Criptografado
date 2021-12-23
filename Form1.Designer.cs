
namespace DesafioCriptografia
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
            this.btn_cadastroS = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_senha = new System.Windows.Forms.TextBox();
            this.btn_cadastroA = new System.Windows.Forms.Button();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txB_loginNome = new System.Windows.Forms.TextBox();
            this.txB_loginSenha = new System.Windows.Forms.TextBox();
            this.btn_EntrarA = new System.Windows.Forms.Button();
            this.lbl_loginSenha = new System.Windows.Forms.Label();
            this.lbl_loginNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastroS
            // 
            this.btn_cadastroS.Location = new System.Drawing.Point(39, 210);
            this.btn_cadastroS.Name = "btn_cadastroS";
            this.btn_cadastroS.Size = new System.Drawing.Size(100, 23);
            this.btn_cadastroS.TabIndex = 0;
            this.btn_cadastroS.Text = "Cad. Simetrico";
            this.btn_cadastroS.UseVisualStyleBackColor = true;
            this.btn_cadastroS.Click += new System.EventHandler(this.btn_cadastroS_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(39, 40);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(40, 15);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(39, 112);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(100, 23);
            this.txtbox_email.TabIndex = 2;
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(39, 58);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(100, 23);
            this.txtbox_nome.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_nome);
            this.groupBox1.Controls.Add(this.txtbox_senha);
            this.groupBox1.Controls.Add(this.btn_cadastroA);
            this.groupBox1.Controls.Add(this.btn_cadastroS);
            this.groupBox1.Controls.Add(this.lblsenha);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.txtbox_email);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 304);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastre seu Usuário";
            // 
            // txtbox_senha
            // 
            this.txtbox_senha.Location = new System.Drawing.Point(39, 167);
            this.txtbox_senha.Name = "txtbox_senha";
            this.txtbox_senha.Size = new System.Drawing.Size(100, 23);
            this.txtbox_senha.TabIndex = 4;
            // 
            // btn_cadastroA
            // 
            this.btn_cadastroA.Location = new System.Drawing.Point(39, 238);
            this.btn_cadastroA.Name = "btn_cadastroA";
            this.btn_cadastroA.Size = new System.Drawing.Size(100, 41);
            this.btn_cadastroA.TabIndex = 0;
            this.btn_cadastroA.Text = "Cad. Assimetrico";
            this.btn_cadastroA.UseVisualStyleBackColor = true;
            this.btn_cadastroA.Click += new System.EventHandler(this.btn_cadastroA_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(39, 149);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(39, 15);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(39, 94);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(36, 15);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txB_loginNome);
            this.groupBox2.Controls.Add(this.txB_loginSenha);
            this.groupBox2.Controls.Add(this.btn_EntrarA);
            this.groupBox2.Controls.Add(this.lbl_loginSenha);
            this.groupBox2.Controls.Add(this.lbl_loginNome);
            this.groupBox2.Location = new System.Drawing.Point(257, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // txB_loginNome
            // 
            this.txB_loginNome.Location = new System.Drawing.Point(39, 58);
            this.txB_loginNome.Name = "txB_loginNome";
            this.txB_loginNome.Size = new System.Drawing.Size(100, 23);
            this.txB_loginNome.TabIndex = 3;
            // 
            // txB_loginSenha
            // 
            this.txB_loginSenha.Location = new System.Drawing.Point(39, 112);
            this.txB_loginSenha.Name = "txB_loginSenha";
            this.txB_loginSenha.Size = new System.Drawing.Size(100, 23);
            this.txB_loginSenha.TabIndex = 4;
            // 
            // btn_EntrarA
            // 
            this.btn_EntrarA.Location = new System.Drawing.Point(51, 149);
            this.btn_EntrarA.Name = "btn_EntrarA";
            this.btn_EntrarA.Size = new System.Drawing.Size(75, 23);
            this.btn_EntrarA.TabIndex = 0;
            this.btn_EntrarA.Text = "Entrar";
            this.btn_EntrarA.UseVisualStyleBackColor = true;
            this.btn_EntrarA.Click += new System.EventHandler(this.btn_EntrarS_Click);
            // 
            // lbl_loginSenha
            // 
            this.lbl_loginSenha.AutoSize = true;
            this.lbl_loginSenha.Location = new System.Drawing.Point(39, 94);
            this.lbl_loginSenha.Name = "lbl_loginSenha";
            this.lbl_loginSenha.Size = new System.Drawing.Size(39, 15);
            this.lbl_loginSenha.TabIndex = 1;
            this.lbl_loginSenha.Text = "Senha";
            // 
            // lbl_loginNome
            // 
            this.lbl_loginNome.AutoSize = true;
            this.lbl_loginNome.Location = new System.Drawing.Point(39, 40);
            this.lbl_loginNome.Name = "lbl_loginNome";
            this.lbl_loginNome.Size = new System.Drawing.Size(40, 15);
            this.lbl_loginNome.TabIndex = 1;
            this.lbl_loginNome.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastroS;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbox_senha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txB_loginNome;
        private System.Windows.Forms.TextBox txB_loginSenha;
        private System.Windows.Forms.Button btn_EntrarA;
        private System.Windows.Forms.Label lbl_loginSenha;
        private System.Windows.Forms.Label lbl_loginNome;
        private System.Windows.Forms.Button btn_cadastroA;
    }
}

