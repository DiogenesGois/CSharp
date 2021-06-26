
namespace Ficha1Ex7 {
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
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.lbl_operacao = new System.Windows.Forms.Label();
            this.cb_operacao = new System.Windows.Forms.ComboBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(27, 41);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(120, 20);
            this.lbl_num1.TabIndex = 0;
            this.lbl_num1.Text = "Primeiro número";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(27, 99);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(126, 20);
            this.lbl_num2.TabIndex = 1;
            this.lbl_num2.Text = "Segundo Número";
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(186, 41);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(167, 27);
            this.tb_num1.TabIndex = 2;
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(186, 99);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(167, 27);
            this.tb_num2.TabIndex = 3;
            // 
            // lbl_operacao
            // 
            this.lbl_operacao.AutoSize = true;
            this.lbl_operacao.Location = new System.Drawing.Point(27, 161);
            this.lbl_operacao.Name = "lbl_operacao";
            this.lbl_operacao.Size = new System.Drawing.Size(74, 20);
            this.lbl_operacao.TabIndex = 4;
            this.lbl_operacao.Text = "Operação";
            // 
            // cb_operacao
            // 
            this.cb_operacao.FormattingEnabled = true;
            this.cb_operacao.Items.AddRange(new object[] {
            "Soma",
            "Subtração",
            "Multiplicação",
            "Divisão"});
            this.cb_operacao.Location = new System.Drawing.Point(186, 161);
            this.cb_operacao.Name = "cb_operacao";
            this.cb_operacao.Size = new System.Drawing.Size(167, 28);
            this.cb_operacao.TabIndex = 5;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(43, 223);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(94, 29);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(238, 222);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(94, 29);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 287);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.cb_operacao);
            this.Controls.Add(this.lbl_operacao);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Label lbl_operacao;
        private System.Windows.Forms.ComboBox cb_operacao;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
    }
}

