
namespace Exercicio3Animais {
    partial class Form1 {
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
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lbl_cachorro = new System.Windows.Forms.Label();
            this.lbl_gato = new System.Windows.Forms.Label();
            this.lbl_peixes = new System.Windows.Forms.Label();
            this.tb_cachorro = new System.Windows.Forms.TextBox();
            this.tb_gato = new System.Windows.Forms.TextBox();
            this.tb_peixe = new System.Windows.Forms.TextBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(51, 30);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(45, 17);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(50, 75);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(36, 17);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Tipo";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(114, 30);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(169, 22);
            this.tb_nome.TabIndex = 2;
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(114, 75);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(169, 22);
            this.tb_tipo.TabIndex = 3;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(53, 141);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lbl_cachorro
            // 
            this.lbl_cachorro.AutoSize = true;
            this.lbl_cachorro.Location = new System.Drawing.Point(26, 221);
            this.lbl_cachorro.Name = "lbl_cachorro";
            this.lbl_cachorro.Size = new System.Drawing.Size(104, 17);
            this.lbl_cachorro.TabIndex = 5;
            this.lbl_cachorro.Text = "Qtd. Cachorros";
            // 
            // lbl_gato
            // 
            this.lbl_gato.AutoSize = true;
            this.lbl_gato.Location = new System.Drawing.Point(53, 268);
            this.lbl_gato.Name = "lbl_gato";
            this.lbl_gato.Size = new System.Drawing.Size(77, 17);
            this.lbl_gato.TabIndex = 6;
            this.lbl_gato.Text = "Qtd. Gatos";
            // 
            // lbl_peixes
            // 
            this.lbl_peixes.AutoSize = true;
            this.lbl_peixes.Location = new System.Drawing.Point(50, 318);
            this.lbl_peixes.Name = "lbl_peixes";
            this.lbl_peixes.Size = new System.Drawing.Size(80, 17);
            this.lbl_peixes.TabIndex = 7;
            this.lbl_peixes.Text = "Qtd. Peixes";
            // 
            // tb_cachorro
            // 
            this.tb_cachorro.Enabled = false;
            this.tb_cachorro.Location = new System.Drawing.Point(172, 221);
            this.tb_cachorro.Name = "tb_cachorro";
            this.tb_cachorro.Size = new System.Drawing.Size(100, 22);
            this.tb_cachorro.TabIndex = 8;
            // 
            // tb_gato
            // 
            this.tb_gato.Enabled = false;
            this.tb_gato.Location = new System.Drawing.Point(172, 268);
            this.tb_gato.Name = "tb_gato";
            this.tb_gato.Size = new System.Drawing.Size(100, 22);
            this.tb_gato.TabIndex = 9;
            // 
            // tb_peixe
            // 
            this.tb_peixe.Enabled = false;
            this.tb_peixe.Location = new System.Drawing.Point(172, 318);
            this.tb_peixe.Name = "tb_peixe";
            this.tb_peixe.Size = new System.Drawing.Size(100, 22);
            this.tb_peixe.TabIndex = 10;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(191, 140);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(75, 23);
            this.btn_finalizar.TabIndex = 11;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 370);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.tb_peixe);
            this.Controls.Add(this.tb_gato);
            this.Controls.Add(this.tb_cachorro);
            this.Controls.Add(this.lbl_peixes);
            this.Controls.Add(this.lbl_gato);
            this.Controls.Add(this.lbl_cachorro);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_tipo);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Animais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label lbl_cachorro;
        private System.Windows.Forms.Label lbl_gato;
        private System.Windows.Forms.Label lbl_peixes;
        private System.Windows.Forms.TextBox tb_cachorro;
        private System.Windows.Forms.TextBox tb_gato;
        private System.Windows.Forms.TextBox tb_peixe;
        private System.Windows.Forms.Button btn_finalizar;
    }
}

