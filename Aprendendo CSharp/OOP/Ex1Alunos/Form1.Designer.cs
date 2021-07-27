
namespace Ex1Alunos {
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_nota1 = new System.Windows.Forms.Label();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_nota1 = new System.Windows.Forms.TextBox();
            this.tb_nota2 = new System.Windows.Forms.TextBox();
            this.btn_registar = new System.Windows.Forms.Button();
            this.tb_trabalho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(67, 37);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(50, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_nota1
            // 
            this.lbl_nota1.AutoSize = true;
            this.lbl_nota1.Location = new System.Drawing.Point(67, 103);
            this.lbl_nota1.Name = "lbl_nota1";
            this.lbl_nota1.Size = new System.Drawing.Size(54, 20);
            this.lbl_nota1.TabIndex = 1;
            this.lbl_nota1.Text = "Nota 1";
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.Location = new System.Drawing.Point(67, 139);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(54, 20);
            this.lbl_nota2.TabIndex = 2;
            this.lbl_nota2.Text = "Nota 2";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(123, 37);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(213, 27);
            this.tb_nome.TabIndex = 3;
            // 
            // tb_nota1
            // 
            this.tb_nota1.Location = new System.Drawing.Point(123, 103);
            this.tb_nota1.Name = "tb_nota1";
            this.tb_nota1.Size = new System.Drawing.Size(125, 27);
            this.tb_nota1.TabIndex = 4;
            // 
            // tb_nota2
            // 
            this.tb_nota2.Location = new System.Drawing.Point(123, 139);
            this.tb_nota2.Name = "tb_nota2";
            this.tb_nota2.Size = new System.Drawing.Size(125, 27);
            this.tb_nota2.TabIndex = 5;
            // 
            // btn_registar
            // 
            this.btn_registar.Location = new System.Drawing.Point(46, 265);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(94, 29);
            this.btn_registar.TabIndex = 6;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = true;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // tb_trabalho
            // 
            this.tb_trabalho.Location = new System.Drawing.Point(123, 172);
            this.tb_trabalho.Name = "tb_trabalho";
            this.tb_trabalho.Size = new System.Drawing.Size(125, 27);
            this.tb_trabalho.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nota trabalho";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(123, 70);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(125, 27);
            this.tb_matricula.TabIndex = 10;
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(46, 70);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(71, 20);
            this.lbl_matricula.TabIndex = 9;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(204, 265);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(94, 29);
            this.btn_consultar.TabIndex = 11;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 316);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.tb_trabalho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.tb_nota2);
            this.Controls.Add(this.tb_nota1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_nota2);
            this.Controls.Add(this.lbl_nota1);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_nota1;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_nota1;
        private System.Windows.Forms.TextBox tb_nota2;
        private System.Windows.Forms.Button btn_registar;
        private System.Windows.Forms.TextBox tb_trabalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Button btn_consultar;
    }
}

