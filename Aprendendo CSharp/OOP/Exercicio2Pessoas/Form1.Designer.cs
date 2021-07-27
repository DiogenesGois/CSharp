
namespace Exercicio2Pessoas {
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
            this.lbl_idade = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.lbl_velho = new System.Windows.Forms.Label();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(70, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(45, 17);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(70, 64);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(43, 17);
            this.lbl_idade.TabIndex = 1;
            this.lbl_idade.Text = "Idade";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(123, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 22);
            this.tb_nome.TabIndex = 2;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(166, 141);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(102, 35);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // lbl_velho
            // 
            this.lbl_velho.AutoSize = true;
            this.lbl_velho.Location = new System.Drawing.Point(28, 127);
            this.lbl_velho.Name = "lbl_velho";
            this.lbl_velho.Size = new System.Drawing.Size(46, 17);
            this.lbl_velho.TabIndex = 5;
            this.lbl_velho.Text = "label1";
            this.lbl_velho.Visible = false;
            // 
            // tb_idade
            // 
            this.tb_idade.Location = new System.Drawing.Point(123, 61);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(100, 22);
            this.tb_idade.TabIndex = 3;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(166, 103);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(102, 32);
            this.btn_adicionar.TabIndex = 6;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 188);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lbl_velho);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label lbl_velho;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Button btn_adicionar;
    }
}

