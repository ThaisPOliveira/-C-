
namespace BD_csharp
{
    partial class formproduto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_alt = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_prod = new System.Windows.Forms.TextBox();
            this.nmc_quant = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.btn_busca = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_quant)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BD_csharp.Properties.Resources.prod_fundo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(800, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(277, 415);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_alt
            // 
            this.btn_alt.Location = new System.Drawing.Point(358, 415);
            this.btn_alt.Name = "btn_alt";
            this.btn_alt.Size = new System.Drawing.Size(75, 23);
            this.btn_alt.TabIndex = 8;
            this.btn_alt.Text = "Alterar";
            this.btn_alt.UseVisualStyleBackColor = true;
            this.btn_alt.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(439, 415);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "Deletar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 30, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 105, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "quantidade:";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(20, 20);
            this.txt_cod.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(221, 20);
            this.txt_cod.TabIndex = 16;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(20, 106);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(221, 111);
            this.txt_desc.TabIndex = 17;
            // 
            // txt_prod
            // 
            this.txt_prod.Location = new System.Drawing.Point(20, 63);
            this.txt_prod.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(221, 20);
            this.txt_prod.TabIndex = 19;
            // 
            // nmc_quant
            // 
            this.nmc_quant.Location = new System.Drawing.Point(20, 240);
            this.nmc_quant.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.nmc_quant.Name = "nmc_quant";
            this.nmc_quant.Size = new System.Drawing.Size(120, 20);
            this.nmc_quant.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 41);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(466, 328);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(190, 311);
            this.flowLayoutPanel3.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "preço";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.txt_cod);
            this.flowLayoutPanel4.Controls.Add(this.txt_prod);
            this.flowLayoutPanel4.Controls.Add(this.txt_desc);
            this.flowLayoutPanel4.Controls.Add(this.nmc_quant);
            this.flowLayoutPanel4.Controls.Add(this.txt_preco);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(199, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(254, 311);
            this.flowLayoutPanel4.TabIndex = 23;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(20, 283);
            this.txt_preco.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(221, 20);
            this.txt_preco.TabIndex = 21;
            // 
            // txt_busca
            // 
            this.txt_busca.Location = new System.Drawing.Point(171, 3);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(207, 20);
            this.txt_busca.TabIndex = 22;
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(384, 3);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(75, 23);
            this.btn_busca.TabIndex = 24;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Buscar por código";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label6);
            this.flowLayoutPanel5.Controls.Add(this.txt_busca);
            this.flowLayoutPanel5.Controls.Add(this.btn_busca);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(466, 32);
            this.flowLayoutPanel5.TabIndex = 26;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(171, 12);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(478, 386);
            this.flowLayoutPanel6.TabIndex = 27;
            // 
            // formproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.btn_alt);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "formproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.formproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_quant)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_alt;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_prod;
        private System.Windows.Forms.NumericUpDown nmc_quant;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
    }
}