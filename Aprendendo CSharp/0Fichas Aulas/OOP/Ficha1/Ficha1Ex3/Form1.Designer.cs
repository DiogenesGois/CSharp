
namespace Ficha1Ex3 {
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
            this.lbl_largura = new System.Windows.Forms.Label();
            this.lbl_comprimento = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.tb_largura = new System.Windows.Forms.TextBox();
            this.tb_comprimento = new System.Windows.Forms.TextBox();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_largura
            // 
            this.lbl_largura.AutoSize = true;
            this.lbl_largura.Location = new System.Drawing.Point(48, 46);
            this.lbl_largura.Name = "lbl_largura";
            this.lbl_largura.Size = new System.Drawing.Size(59, 20);
            this.lbl_largura.TabIndex = 0;
            this.lbl_largura.Text = "Largura";
            // 
            // lbl_comprimento
            // 
            this.lbl_comprimento.AutoSize = true;
            this.lbl_comprimento.Location = new System.Drawing.Point(48, 108);
            this.lbl_comprimento.Name = "lbl_comprimento";
            this.lbl_comprimento.Size = new System.Drawing.Size(101, 20);
            this.lbl_comprimento.TabIndex = 1;
            this.lbl_comprimento.Text = "Comprimento";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(105, 173);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(153, 29);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // tb_largura
            // 
            this.tb_largura.Location = new System.Drawing.Point(157, 46);
            this.tb_largura.Name = "tb_largura";
            this.tb_largura.Size = new System.Drawing.Size(125, 27);
            this.tb_largura.TabIndex = 3;
            // 
            // tb_comprimento
            // 
            this.tb_comprimento.Location = new System.Drawing.Point(157, 108);
            this.tb_comprimento.Name = "tb_comprimento";
            this.tb_comprimento.Size = new System.Drawing.Size(125, 27);
            this.tb_comprimento.TabIndex = 4;
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Location = new System.Drawing.Point(67, 249);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(43, 20);
            this.lbl_area.TabIndex = 5;
            this.lbl_area.Text = "Área:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(177, 249);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(71, 20);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "resultado";
            this.lbl_resultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 357);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.tb_comprimento);
            this.Controls.Add(this.tb_largura);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_comprimento);
            this.Controls.Add(this.lbl_largura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_largura;
        private System.Windows.Forms.Label lbl_comprimento;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox tb_largura;
        private System.Windows.Forms.TextBox tb_comprimento;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

