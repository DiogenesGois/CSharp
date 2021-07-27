
namespace Pokemon {
    partial class Pokemon {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_poke = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.tb_altura = new System.Windows.Forms.TextBox();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_poke
            // 
            this.lbl_poke.AutoSize = true;
            this.lbl_poke.Location = new System.Drawing.Point(39, 81);
            this.lbl_poke.Name = "lbl_poke";
            this.lbl_poke.Size = new System.Drawing.Size(45, 17);
            this.lbl_poke.TabIndex = 0;
            this.lbl_poke.Text = "Nome";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(39, 124);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(36, 17);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Tipo";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(39, 35);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(58, 17);
            this.lbl_numero.TabIndex = 2;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(39, 167);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(45, 17);
            this.lbl_altura.TabIndex = 3;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(39, 212);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(40, 17);
            this.lbl_peso.TabIndex = 4;
            this.lbl_peso.Text = "Peso";
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(126, 35);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(91, 22);
            this.tb_numero.TabIndex = 5;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(126, 81);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(200, 22);
            this.tb_nome.TabIndex = 6;
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(126, 124);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(200, 22);
            this.tb_tipo.TabIndex = 7;
            // 
            // tb_altura
            // 
            this.tb_altura.Location = new System.Drawing.Point(126, 167);
            this.tb_altura.Name = "tb_altura";
            this.tb_altura.Size = new System.Drawing.Size(200, 22);
            this.tb_altura.TabIndex = 8;
            // 
            // tb_peso
            // 
            this.tb_peso.Location = new System.Drawing.Point(126, 212);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(200, 22);
            this.tb_peso.TabIndex = 9;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(183, 251);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(143, 35);
            this.btn_consultar.TabIndex = 10;
            this.btn_consultar.Text = "Consultar BD";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(12, 251);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(143, 35);
            this.btn_novo.TabIndex = 11;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // Pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 298);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.tb_altura);
            this.Controls.Add(this.tb_tipo);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_poke);
            this.Name = "Pokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.Pokemon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_poke;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_peso;
        public System.Windows.Forms.TextBox tb_numero;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.TextBox tb_tipo;
        public System.Windows.Forms.TextBox tb_altura;
        public System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_novo;
    }
}