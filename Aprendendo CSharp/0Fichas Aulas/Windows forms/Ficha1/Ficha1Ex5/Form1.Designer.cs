
namespace Ficha1Ex5 {
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_nota1 = new System.Windows.Forms.Label();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.tb_nota1 = new System.Windows.Forms.TextBox();
            this.tb_nota2 = new System.Windows.Forms.TextBox();
            this.tb_nota3 = new System.Windows.Forms.TextBox();
            this.lbl_nota3 = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(105, 260);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(184, 29);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_nota1
            // 
            this.lbl_nota1.AutoSize = true;
            this.lbl_nota1.Location = new System.Drawing.Point(48, 58);
            this.lbl_nota1.Name = "lbl_nota1";
            this.lbl_nota1.Size = new System.Drawing.Size(54, 20);
            this.lbl_nota1.TabIndex = 1;
            this.lbl_nota1.Text = "Nota 1";
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.Location = new System.Drawing.Point(48, 121);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(54, 20);
            this.lbl_nota2.TabIndex = 2;
            this.lbl_nota2.Text = "Nota 2";
            // 
            // tb_nota1
            // 
            this.tb_nota1.Location = new System.Drawing.Point(183, 58);
            this.tb_nota1.Name = "tb_nota1";
            this.tb_nota1.Size = new System.Drawing.Size(125, 27);
            this.tb_nota1.TabIndex = 3;
            // 
            // tb_nota2
            // 
            this.tb_nota2.Location = new System.Drawing.Point(183, 121);
            this.tb_nota2.Name = "tb_nota2";
            this.tb_nota2.Size = new System.Drawing.Size(125, 27);
            this.tb_nota2.TabIndex = 4;
            // 
            // tb_nota3
            // 
            this.tb_nota3.Location = new System.Drawing.Point(183, 187);
            this.tb_nota3.Name = "tb_nota3";
            this.tb_nota3.Size = new System.Drawing.Size(125, 27);
            this.tb_nota3.TabIndex = 6;
            // 
            // lbl_nota3
            // 
            this.lbl_nota3.AutoSize = true;
            this.lbl_nota3.Location = new System.Drawing.Point(48, 187);
            this.lbl_nota3.Name = "lbl_nota3";
            this.lbl_nota3.Size = new System.Drawing.Size(54, 20);
            this.lbl_nota3.TabIndex = 5;
            this.lbl_nota3.Text = "Nota 3";
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(48, 336);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(54, 20);
            this.lbl_media.TabIndex = 7;
            this.lbl_media.Text = "Média:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(160, 336);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(50, 20);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Text = "label5";
            this.lbl_resultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.tb_nota3);
            this.Controls.Add(this.lbl_nota3);
            this.Controls.Add(this.tb_nota2);
            this.Controls.Add(this.tb_nota1);
            this.Controls.Add(this.lbl_nota2);
            this.Controls.Add(this.lbl_nota1);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_nota1;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.TextBox tb_nota1;
        private System.Windows.Forms.TextBox tb_nota2;
        private System.Windows.Forms.TextBox tb_nota3;
        private System.Windows.Forms.Label lbl_nota3;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

