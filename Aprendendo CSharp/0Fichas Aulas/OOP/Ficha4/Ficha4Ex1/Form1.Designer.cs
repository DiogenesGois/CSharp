
namespace Ficha4Ex1 {
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
            this.gb_genero = new System.Windows.Forms.GroupBox();
            this.rb_feminino = new System.Windows.Forms.RadioButton();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.gb_utente = new System.Windows.Forms.GroupBox();
            this.nud_altura = new System.Windows.Forms.NumericUpDown();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.nud_peso = new System.Windows.Forms.NumericUpDown();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.gb_informações = new System.Windows.Forms.GroupBox();
            this.tb_risco = new System.Windows.Forms.TextBox();
            this.tb_classificacao = new System.Windows.Forms.TextBox();
            this.tb_imc = new System.Windows.Forms.TextBox();
            this.lbl_risco = new System.Windows.Forms.Label();
            this.lbl_classificacao = new System.Windows.Forms.Label();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_repor = new System.Windows.Forms.Button();
            this.gb_genero.SuspendLayout();
            this.gb_utente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_peso)).BeginInit();
            this.gb_informações.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_genero
            // 
            this.gb_genero.Controls.Add(this.rb_feminino);
            this.gb_genero.Controls.Add(this.rb_masculino);
            this.gb_genero.Location = new System.Drawing.Point(23, 25);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Size = new System.Drawing.Size(431, 91);
            this.gb_genero.TabIndex = 0;
            this.gb_genero.TabStop = false;
            this.gb_genero.Text = "Género";
            // 
            // rb_feminino
            // 
            this.rb_feminino.AutoSize = true;
            this.rb_feminino.Location = new System.Drawing.Point(246, 39);
            this.rb_feminino.Name = "rb_feminino";
            this.rb_feminino.Size = new System.Drawing.Size(91, 24);
            this.rb_feminino.TabIndex = 1;
            this.rb_feminino.TabStop = true;
            this.rb_feminino.Text = "Feminino";
            this.rb_feminino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Location = new System.Drawing.Point(47, 39);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(97, 24);
            this.rb_masculino.TabIndex = 0;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // gb_utente
            // 
            this.gb_utente.Controls.Add(this.nud_altura);
            this.gb_utente.Controls.Add(this.lbl_altura);
            this.gb_utente.Controls.Add(this.lbl_peso);
            this.gb_utente.Controls.Add(this.nud_peso);
            this.gb_utente.Controls.Add(this.tb_idade);
            this.gb_utente.Controls.Add(this.lbl_idade);
            this.gb_utente.Location = new System.Drawing.Point(23, 138);
            this.gb_utente.Name = "gb_utente";
            this.gb_utente.Size = new System.Drawing.Size(385, 125);
            this.gb_utente.TabIndex = 1;
            this.gb_utente.TabStop = false;
            this.gb_utente.Text = "Dados do Utente";
            // 
            // nud_altura
            // 
            this.nud_altura.DecimalPlaces = 2;
            this.nud_altura.Location = new System.Drawing.Point(254, 87);
            this.nud_altura.Name = "nud_altura";
            this.nud_altura.Size = new System.Drawing.Size(100, 27);
            this.nud_altura.TabIndex = 5;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(199, 88);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(49, 20);
            this.lbl_altura.TabIndex = 4;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(18, 88);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(39, 20);
            this.lbl_peso.TabIndex = 3;
            this.lbl_peso.Text = "Peso";
            // 
            // nud_peso
            // 
            this.nud_peso.Location = new System.Drawing.Point(72, 87);
            this.nud_peso.Name = "nud_peso";
            this.nud_peso.Size = new System.Drawing.Size(86, 27);
            this.nud_peso.TabIndex = 2;
            // 
            // tb_idade
            // 
            this.tb_idade.Location = new System.Drawing.Point(72, 36);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(86, 27);
            this.tb_idade.TabIndex = 1;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(18, 36);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(47, 20);
            this.lbl_idade.TabIndex = 0;
            this.lbl_idade.Text = "Idade";
            // 
            // gb_informações
            // 
            this.gb_informações.Controls.Add(this.tb_risco);
            this.gb_informações.Controls.Add(this.tb_classificacao);
            this.gb_informações.Controls.Add(this.tb_imc);
            this.gb_informações.Controls.Add(this.lbl_risco);
            this.gb_informações.Controls.Add(this.lbl_classificacao);
            this.gb_informações.Controls.Add(this.lbl_imc);
            this.gb_informações.Location = new System.Drawing.Point(23, 286);
            this.gb_informações.Name = "gb_informações";
            this.gb_informações.Size = new System.Drawing.Size(512, 152);
            this.gb_informações.TabIndex = 2;
            this.gb_informações.TabStop = false;
            this.gb_informações.Text = "Informações";
            // 
            // tb_risco
            // 
            this.tb_risco.Enabled = false;
            this.tb_risco.Location = new System.Drawing.Point(176, 105);
            this.tb_risco.Name = "tb_risco";
            this.tb_risco.Size = new System.Drawing.Size(275, 27);
            this.tb_risco.TabIndex = 5;
            // 
            // tb_classificacao
            // 
            this.tb_classificacao.Enabled = false;
            this.tb_classificacao.Location = new System.Drawing.Point(176, 71);
            this.tb_classificacao.Name = "tb_classificacao";
            this.tb_classificacao.Size = new System.Drawing.Size(275, 27);
            this.tb_classificacao.TabIndex = 4;
            // 
            // tb_imc
            // 
            this.tb_imc.Enabled = false;
            this.tb_imc.Location = new System.Drawing.Point(176, 34);
            this.tb_imc.Name = "tb_imc";
            this.tb_imc.Size = new System.Drawing.Size(125, 27);
            this.tb_imc.TabIndex = 3;
            // 
            // lbl_risco
            // 
            this.lbl_risco.AutoSize = true;
            this.lbl_risco.Location = new System.Drawing.Point(42, 105);
            this.lbl_risco.Name = "lbl_risco";
            this.lbl_risco.Size = new System.Drawing.Size(110, 20);
            this.lbl_risco.TabIndex = 2;
            this.lbl_risco.Text = "Risco de Saúde";
            // 
            // lbl_classificacao
            // 
            this.lbl_classificacao.AutoSize = true;
            this.lbl_classificacao.Location = new System.Drawing.Point(0, 71);
            this.lbl_classificacao.Name = "lbl_classificacao";
            this.lbl_classificacao.Size = new System.Drawing.Size(150, 20);
            this.lbl_classificacao.TabIndex = 1;
            this.lbl_classificacao.Text = "Classificação do Peso";
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Location = new System.Drawing.Point(79, 34);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(73, 20);
            this.lbl_imc.TabIndex = 0;
            this.lbl_imc.Text = "Valor IMC";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(414, 147);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(121, 47);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_repor
            // 
            this.btn_repor.Location = new System.Drawing.Point(414, 216);
            this.btn_repor.Name = "btn_repor";
            this.btn_repor.Size = new System.Drawing.Size(121, 47);
            this.btn_repor.TabIndex = 4;
            this.btn_repor.Text = "Repor";
            this.btn_repor.UseVisualStyleBackColor = true;
            this.btn_repor.Click += new System.EventHandler(this.btn_repor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btn_repor);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.gb_informações);
            this.Controls.Add(this.gb_utente);
            this.Controls.Add(this.gb_genero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_genero.ResumeLayout(false);
            this.gb_genero.PerformLayout();
            this.gb_utente.ResumeLayout(false);
            this.gb_utente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_peso)).EndInit();
            this.gb_informações.ResumeLayout(false);
            this.gb_informações.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_genero;
        private System.Windows.Forms.GroupBox gb_utente;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_peso;
        public System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.GroupBox gb_informações;
        public System.Windows.Forms.TextBox tb_risco;
        public System.Windows.Forms.TextBox tb_classificacao;
        public System.Windows.Forms.TextBox tb_imc;
        private System.Windows.Forms.Label lbl_risco;
        private System.Windows.Forms.Label lbl_classificacao;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_repor;
        private System.Windows.Forms.RadioButton rb_feminino;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.NumericUpDown nud_altura;
        private System.Windows.Forms.NumericUpDown nud_peso;
    }
}

