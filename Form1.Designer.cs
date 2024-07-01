
namespace BD_csharp
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.djsgbhkdsa = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_logar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckb_mostrarsenha = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.var_guardanome = new System.Windows.Forms.Label();
            this.var_guardanivel = new System.Windows.Forms.Label();
            this.img_fundo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // djsgbhkdsa
            // 
            this.djsgbhkdsa.AutoSize = true;
            this.djsgbhkdsa.Location = new System.Drawing.Point(115, 91);
            this.djsgbhkdsa.Name = "djsgbhkdsa";
            this.djsgbhkdsa.Size = new System.Drawing.Size(91, 30);
            this.djsgbhkdsa.TabIndex = 1;
            this.djsgbhkdsa.Text = "SENHA";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(53, 48);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(200, 37);
            this.txt_login.TabIndex = 2;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(53, 122);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(200, 37);
            this.txt_senha.TabIndex = 3;
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Location = new System.Drawing.Point(53, 304);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(200, 32);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Location = new System.Drawing.Point(53, 253);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(200, 32);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_logar
            // 
            this.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logar.Location = new System.Drawing.Point(53, 201);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(200, 32);
            this.btn_logar.TabIndex = 6;
            this.btn_logar.Text = "LOGAR";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ckb_mostrarsenha);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.btn_logar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Controls.Add(this.djsgbhkdsa);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.txt_login);
            this.panel1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(241, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 353);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ckb_mostrarsenha
            // 
            this.ckb_mostrarsenha.AutoSize = true;
            this.ckb_mostrarsenha.Location = new System.Drawing.Point(48, 161);
            this.ckb_mostrarsenha.Name = "ckb_mostrarsenha";
            this.ckb_mostrarsenha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckb_mostrarsenha.Size = new System.Drawing.Size(205, 34);
            this.ckb_mostrarsenha.TabIndex = 10;
            this.ckb_mostrarsenha.Text = "Mostrar senha";
            this.ckb_mostrarsenha.UseVisualStyleBackColor = true;
            this.ckb_mostrarsenha.CheckedChanged += new System.EventHandler(this.ckb_mostrarsenha_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.var_guardanome);
            this.groupBox1.Controls.Add(this.var_guardanivel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(55, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "vars";
            this.groupBox1.Visible = false;
            // 
            // var_guardanome
            // 
            this.var_guardanome.AutoSize = true;
            this.var_guardanome.Location = new System.Drawing.Point(6, 16);
            this.var_guardanome.Name = "var_guardanome";
            this.var_guardanome.Size = new System.Drawing.Size(35, 13);
            this.var_guardanome.TabIndex = 1;
            this.var_guardanome.Text = "fatima";
            // 
            // var_guardanivel
            // 
            this.var_guardanivel.AutoSize = true;
            this.var_guardanivel.Location = new System.Drawing.Point(6, 29);
            this.var_guardanivel.Name = "var_guardanivel";
            this.var_guardanivel.Size = new System.Drawing.Size(57, 13);
            this.var_guardanivel.TabIndex = 0;
            this.var_guardanivel.Text = "bernandes";
            // 
            // img_fundo
            // 
            this.img_fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_fundo.Image = global::BD_csharp.Properties.Resources.fundo;
            this.img_fundo.Location = new System.Drawing.Point(0, 0);
            this.img_fundo.Name = "img_fundo";
            this.img_fundo.Size = new System.Drawing.Size(800, 450);
            this.img_fundo.TabIndex = 9;
            this.img_fundo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_fundo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_fundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label djsgbhkdsa;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label var_guardanome;
        private System.Windows.Forms.Label var_guardanivel;
        private System.Windows.Forms.CheckBox ckb_mostrarsenha;
        private System.Windows.Forms.PictureBox img_fundo;
    }
}

