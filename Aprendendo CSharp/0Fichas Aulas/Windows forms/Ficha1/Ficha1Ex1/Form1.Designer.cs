
namespace Ficha1Ex1 {
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
            this.lbl_salario = new System.Windows.Forms.Label();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.tb_irs = new System.Windows.Forms.TextBox();
            this.lbl_irs = new System.Windows.Forms.Label();
            this.tb_segSocial = new System.Windows.Forms.TextBox();
            this.lbl_segSocial = new System.Windows.Forms.Label();
            this.tb_salarioLiquido = new System.Windows.Forms.TextBox();
            this.lbl_salarioLiquido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(85, 70);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(55, 20);
            this.lbl_salario.TabIndex = 0;
            this.lbl_salario.Text = "Salário";
            // 
            // tb_salario
            // 
            this.tb_salario.Location = new System.Drawing.Point(223, 67);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(125, 27);
            this.tb_salario.TabIndex = 1;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(109, 137);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(188, 29);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // tb_irs
            // 
            this.tb_irs.Location = new System.Drawing.Point(223, 212);
            this.tb_irs.Name = "tb_irs";
            this.tb_irs.ReadOnly = true;
            this.tb_irs.Size = new System.Drawing.Size(125, 27);
            this.tb_irs.TabIndex = 4;
            // 
            // lbl_irs
            // 
            this.lbl_irs.AutoSize = true;
            this.lbl_irs.Location = new System.Drawing.Point(74, 215);
            this.lbl_irs.Name = "lbl_irs";
            this.lbl_irs.Size = new System.Drawing.Size(30, 20);
            this.lbl_irs.TabIndex = 3;
            this.lbl_irs.Text = "IRS";
            // 
            // tb_segSocial
            // 
            this.tb_segSocial.Location = new System.Drawing.Point(223, 266);
            this.tb_segSocial.Name = "tb_segSocial";
            this.tb_segSocial.ReadOnly = true;
            this.tb_segSocial.Size = new System.Drawing.Size(125, 27);
            this.tb_segSocial.TabIndex = 6;
            // 
            // lbl_segSocial
            // 
            this.lbl_segSocial.AutoSize = true;
            this.lbl_segSocial.Location = new System.Drawing.Point(74, 273);
            this.lbl_segSocial.Name = "lbl_segSocial";
            this.lbl_segSocial.Size = new System.Drawing.Size(81, 20);
            this.lbl_segSocial.TabIndex = 5;
            this.lbl_segSocial.Text = "Seg. Social";
            // 
            // tb_salarioLiquido
            // 
            this.tb_salarioLiquido.Location = new System.Drawing.Point(223, 324);
            this.tb_salarioLiquido.Name = "tb_salarioLiquido";
            this.tb_salarioLiquido.ReadOnly = true;
            this.tb_salarioLiquido.Size = new System.Drawing.Size(125, 27);
            this.tb_salarioLiquido.TabIndex = 8;
            // 
            // lbl_salarioLiquido
            // 
            this.lbl_salarioLiquido.AutoSize = true;
            this.lbl_salarioLiquido.Location = new System.Drawing.Point(74, 327);
            this.lbl_salarioLiquido.Name = "lbl_salarioLiquido";
            this.lbl_salarioLiquido.Size = new System.Drawing.Size(109, 20);
            this.lbl_salarioLiquido.TabIndex = 7;
            this.lbl_salarioLiquido.Text = "Salário Líquido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 400);
            this.Controls.Add(this.tb_salarioLiquido);
            this.Controls.Add(this.lbl_salarioLiquido);
            this.Controls.Add(this.tb_segSocial);
            this.Controls.Add(this.lbl_segSocial);
            this.Controls.Add(this.tb_irs);
            this.Controls.Add(this.lbl_irs);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.lbl_salario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox tb_irs;
        private System.Windows.Forms.Label lbl_irs;
        private System.Windows.Forms.TextBox tb_segSocial;
        private System.Windows.Forms.Label lbl_segSocial;
        private System.Windows.Forms.TextBox tb_salarioLiquido;
        private System.Windows.Forms.Label lbl_salarioLiquido;
    }
}

