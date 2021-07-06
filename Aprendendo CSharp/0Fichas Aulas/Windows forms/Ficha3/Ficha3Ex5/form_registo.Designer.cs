
namespace Ficha3Ex5 {
    partial class form_registo {
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lbl_portugues = new System.Windows.Forms.Label();
            this.lbl_matematica = new System.Windows.Forms.Label();
            this.lbl_tic = new System.Windows.Forms.Label();
            this.nud_portugues = new System.Windows.Forms.NumericUpDown();
            this.nud_matematica = new System.Windows.Forms.NumericUpDown();
            this.nud_tic = new System.Windows.Forms.NumericUpDown();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_portugues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_matematica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(31, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(50, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(99, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(252, 27);
            this.tb_nome.TabIndex = 1;
            // 
            // lbl_portugues
            // 
            this.lbl_portugues.AutoSize = true;
            this.lbl_portugues.Location = new System.Drawing.Point(31, 88);
            this.lbl_portugues.Name = "lbl_portugues";
            this.lbl_portugues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_portugues.Size = new System.Drawing.Size(74, 20);
            this.lbl_portugues.TabIndex = 2;
            this.lbl_portugues.Text = "Português";
            // 
            // lbl_matematica
            // 
            this.lbl_matematica.AutoSize = true;
            this.lbl_matematica.Location = new System.Drawing.Point(31, 125);
            this.lbl_matematica.Name = "lbl_matematica";
            this.lbl_matematica.Size = new System.Drawing.Size(88, 20);
            this.lbl_matematica.TabIndex = 3;
            this.lbl_matematica.Text = "Matemática";
            this.lbl_matematica.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_tic
            // 
            this.lbl_tic.AutoSize = true;
            this.lbl_tic.Location = new System.Drawing.Point(31, 161);
            this.lbl_tic.Name = "lbl_tic";
            this.lbl_tic.Size = new System.Drawing.Size(30, 20);
            this.lbl_tic.TabIndex = 4;
            this.lbl_tic.Text = "TIC";
            // 
            // nud_portugues
            // 
            this.nud_portugues.Location = new System.Drawing.Point(138, 88);
            this.nud_portugues.Name = "nud_portugues";
            this.nud_portugues.Size = new System.Drawing.Size(54, 27);
            this.nud_portugues.TabIndex = 5;
            this.nud_portugues.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nud_matematica
            // 
            this.nud_matematica.Location = new System.Drawing.Point(138, 125);
            this.nud_matematica.Name = "nud_matematica";
            this.nud_matematica.Size = new System.Drawing.Size(54, 27);
            this.nud_matematica.TabIndex = 6;
            // 
            // nud_tic
            // 
            this.nud_tic.Location = new System.Drawing.Point(138, 161);
            this.nud_tic.Name = "nud_tic";
            this.nud_tic.Size = new System.Drawing.Size(54, 27);
            this.nud_tic.TabIndex = 7;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(227, 88);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(124, 29);
            this.btn_inserir.TabIndex = 8;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(227, 125);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(124, 29);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(227, 161);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(124, 29);
            this.btn_consultar.TabIndex = 10;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.button3_Click);
            // 
            // form_registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 215);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.nud_tic);
            this.Controls.Add(this.nud_matematica);
            this.Controls.Add(this.nud_portugues);
            this.Controls.Add(this.lbl_tic);
            this.Controls.Add(this.lbl_matematica);
            this.Controls.Add(this.lbl_portugues);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "form_registo";
            this.Text = "Registo";
            ((System.ComponentModel.ISupportInitialize)(this.nud_portugues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_matematica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lbl_portugues;
        private System.Windows.Forms.Label lbl_matematica;
        private System.Windows.Forms.Label lbl_tic;
        private System.Windows.Forms.NumericUpDown nud_portugues;
        private System.Windows.Forms.NumericUpDown nud_matematica;
        private System.Windows.Forms.NumericUpDown nud_tic;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_consultar;
    }
}