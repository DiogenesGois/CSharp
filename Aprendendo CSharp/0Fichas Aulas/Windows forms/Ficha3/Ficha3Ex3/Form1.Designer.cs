
namespace Ficha3Ex3 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.gb_vetor1 = new System.Windows.Forms.GroupBox();
            this.btn_inserir1 = new System.Windows.Forms.Button();
            this.tb_valor1 = new System.Windows.Forms.TextBox();
            this.tb_posicao1 = new System.Windows.Forms.TextBox();
            this.lbl_valor1 = new System.Windows.Forms.Label();
            this.lbl_posicao1 = new System.Windows.Forms.Label();
            this.gb_vetor2 = new System.Windows.Forms.GroupBox();
            this.btn_inserir2 = new System.Windows.Forms.Button();
            this.tb_valor2 = new System.Windows.Forms.TextBox();
            this.tb_posicao2 = new System.Windows.Forms.TextBox();
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.lbl_posicao2 = new System.Windows.Forms.Label();
            this.btn_valores = new System.Windows.Forms.Button();
            this.ltb_vetor1 = new System.Windows.Forms.ListBox();
            this.ltb_vetor2 = new System.Windows.Forms.ListBox();
            this.btn_somar = new System.Windows.Forms.Button();
            this.ltb_somar = new System.Windows.Forms.ListBox();
            this.gb_vetor1.SuspendLayout();
            this.gb_vetor2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_vetor1
            // 
            this.gb_vetor1.Controls.Add(this.btn_inserir1);
            this.gb_vetor1.Controls.Add(this.tb_valor1);
            this.gb_vetor1.Controls.Add(this.tb_posicao1);
            this.gb_vetor1.Controls.Add(this.lbl_valor1);
            this.gb_vetor1.Controls.Add(this.lbl_posicao1);
            this.gb_vetor1.Location = new System.Drawing.Point(12, 22);
            this.gb_vetor1.Name = "gb_vetor1";
            this.gb_vetor1.Size = new System.Drawing.Size(250, 125);
            this.gb_vetor1.TabIndex = 0;
            this.gb_vetor1.TabStop = false;
            this.gb_vetor1.Text = "Vetor 1";
            // 
            // btn_inserir1
            // 
            this.btn_inserir1.Location = new System.Drawing.Point(168, 27);
            this.btn_inserir1.Name = "btn_inserir1";
            this.btn_inserir1.Size = new System.Drawing.Size(76, 71);
            this.btn_inserir1.TabIndex = 4;
            this.btn_inserir1.Text = "Inserir";
            this.btn_inserir1.UseVisualStyleBackColor = true;
            this.btn_inserir1.Click += new System.EventHandler(this.btn_inserir1_Click);
            // 
            // tb_valor1
            // 
            this.tb_valor1.Location = new System.Drawing.Point(97, 71);
            this.tb_valor1.Name = "tb_valor1";
            this.tb_valor1.Size = new System.Drawing.Size(55, 27);
            this.tb_valor1.TabIndex = 3;
            // 
            // tb_posicao1
            // 
            this.tb_posicao1.Enabled = false;
            this.tb_posicao1.Location = new System.Drawing.Point(97, 27);
            this.tb_posicao1.Name = "tb_posicao1";
            this.tb_posicao1.Size = new System.Drawing.Size(55, 27);
            this.tb_posicao1.TabIndex = 2;
            // 
            // lbl_valor1
            // 
            this.lbl_valor1.AutoSize = true;
            this.lbl_valor1.Location = new System.Drawing.Point(19, 71);
            this.lbl_valor1.Name = "lbl_valor1";
            this.lbl_valor1.Size = new System.Drawing.Size(43, 20);
            this.lbl_valor1.TabIndex = 1;
            this.lbl_valor1.Text = "Valor";
            // 
            // lbl_posicao1
            // 
            this.lbl_posicao1.AutoSize = true;
            this.lbl_posicao1.Location = new System.Drawing.Point(19, 30);
            this.lbl_posicao1.Name = "lbl_posicao1";
            this.lbl_posicao1.Size = new System.Drawing.Size(59, 20);
            this.lbl_posicao1.TabIndex = 0;
            this.lbl_posicao1.Text = "Posição";
            // 
            // gb_vetor2
            // 
            this.gb_vetor2.Controls.Add(this.btn_inserir2);
            this.gb_vetor2.Controls.Add(this.tb_valor2);
            this.gb_vetor2.Controls.Add(this.tb_posicao2);
            this.gb_vetor2.Controls.Add(this.lbl_valor2);
            this.gb_vetor2.Controls.Add(this.lbl_posicao2);
            this.gb_vetor2.Location = new System.Drawing.Point(277, 22);
            this.gb_vetor2.Name = "gb_vetor2";
            this.gb_vetor2.Size = new System.Drawing.Size(250, 125);
            this.gb_vetor2.TabIndex = 1;
            this.gb_vetor2.TabStop = false;
            this.gb_vetor2.Text = "Vetor 2";
            // 
            // btn_inserir2
            // 
            this.btn_inserir2.Location = new System.Drawing.Point(162, 27);
            this.btn_inserir2.Name = "btn_inserir2";
            this.btn_inserir2.Size = new System.Drawing.Size(76, 71);
            this.btn_inserir2.TabIndex = 9;
            this.btn_inserir2.Text = "Inserir";
            this.btn_inserir2.UseVisualStyleBackColor = true;
            this.btn_inserir2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_valor2
            // 
            this.tb_valor2.Location = new System.Drawing.Point(91, 71);
            this.tb_valor2.Name = "tb_valor2";
            this.tb_valor2.Size = new System.Drawing.Size(55, 27);
            this.tb_valor2.TabIndex = 8;
            // 
            // tb_posicao2
            // 
            this.tb_posicao2.Enabled = false;
            this.tb_posicao2.Location = new System.Drawing.Point(91, 27);
            this.tb_posicao2.Name = "tb_posicao2";
            this.tb_posicao2.Size = new System.Drawing.Size(55, 27);
            this.tb_posicao2.TabIndex = 7;
            // 
            // lbl_valor2
            // 
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.Location = new System.Drawing.Point(13, 71);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(43, 20);
            this.lbl_valor2.TabIndex = 6;
            this.lbl_valor2.Text = "Valor";
            // 
            // lbl_posicao2
            // 
            this.lbl_posicao2.AutoSize = true;
            this.lbl_posicao2.Location = new System.Drawing.Point(13, 27);
            this.lbl_posicao2.Name = "lbl_posicao2";
            this.lbl_posicao2.Size = new System.Drawing.Size(59, 20);
            this.lbl_posicao2.TabIndex = 5;
            this.lbl_posicao2.Text = "Posição";
            // 
            // btn_valores
            // 
            this.btn_valores.Location = new System.Drawing.Point(98, 175);
            this.btn_valores.Name = "btn_valores";
            this.btn_valores.Size = new System.Drawing.Size(209, 55);
            this.btn_valores.TabIndex = 2;
            this.btn_valores.Text = "Apresentar Valores";
            this.btn_valores.UseVisualStyleBackColor = true;
            this.btn_valores.Click += new System.EventHandler(this.btn_valores_Click);
            // 
            // ltb_vetor1
            // 
            this.ltb_vetor1.FormattingEnabled = true;
            this.ltb_vetor1.ItemHeight = 20;
            this.ltb_vetor1.Location = new System.Drawing.Point(98, 237);
            this.ltb_vetor1.Name = "ltb_vetor1";
            this.ltb_vetor1.Size = new System.Drawing.Size(91, 184);
            this.ltb_vetor1.TabIndex = 3;
            // 
            // ltb_vetor2
            // 
            this.ltb_vetor2.FormattingEnabled = true;
            this.ltb_vetor2.ItemHeight = 20;
            this.ltb_vetor2.Location = new System.Drawing.Point(205, 237);
            this.ltb_vetor2.Name = "ltb_vetor2";
            this.ltb_vetor2.Size = new System.Drawing.Size(102, 184);
            this.ltb_vetor2.TabIndex = 4;
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(368, 175);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(94, 55);
            this.btn_somar.TabIndex = 5;
            this.btn_somar.Text = "Somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // ltb_somar
            // 
            this.ltb_somar.FormattingEnabled = true;
            this.ltb_somar.ItemHeight = 20;
            this.ltb_somar.Location = new System.Drawing.Point(371, 237);
            this.ltb_somar.Name = "ltb_somar";
            this.ltb_somar.Size = new System.Drawing.Size(91, 184);
            this.ltb_somar.TabIndex = 6;
            this.ltb_somar.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.ltb_somar);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.ltb_vetor2);
            this.Controls.Add(this.ltb_vetor1);
            this.Controls.Add(this.btn_valores);
            this.Controls.Add(this.gb_vetor2);
            this.Controls.Add(this.gb_vetor1);
            this.Name = "Form1";
            this.Text = "Soma de Vetores";
            this.gb_vetor1.ResumeLayout(false);
            this.gb_vetor1.PerformLayout();
            this.gb_vetor2.ResumeLayout(false);
            this.gb_vetor2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_vetor1;
        private System.Windows.Forms.Button btn_inserir1;
        private System.Windows.Forms.TextBox tb_valor1;
        private System.Windows.Forms.TextBox tb_posicao1;
        private System.Windows.Forms.Label lbl_valor1;
        private System.Windows.Forms.Label lbl_posicao1;
        private System.Windows.Forms.GroupBox gb_vetor2;
        private System.Windows.Forms.Button btn_inserir2;
        private System.Windows.Forms.TextBox tb_valor2;
        private System.Windows.Forms.TextBox tb_posicao2;
        private System.Windows.Forms.Label lbl_valor2;
        private System.Windows.Forms.Label lbl_posicao2;
        private System.Windows.Forms.Button btn_valores;
        private System.Windows.Forms.ListBox ltb_vetor1;
        private System.Windows.Forms.ListBox ltb_vetor2;
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.ListBox ltb_somar;
    }
}

