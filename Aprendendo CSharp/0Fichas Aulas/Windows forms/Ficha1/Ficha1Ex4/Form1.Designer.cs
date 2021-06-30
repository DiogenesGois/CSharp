
namespace Ficha1Ex4 {
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
            this.lblbrancos = new System.Windows.Forms.Label();
            this.lbl_nulos = new System.Windows.Forms.Label();
            this.lbl_validos = new System.Windows.Forms.Label();
            this.tb_brancos = new System.Windows.Forms.TextBox();
            this.tb_nulos = new System.Windows.Forms.TextBox();
            this.tb_valido = new System.Windows.Forms.TextBox();
            this.tbn_calcular = new System.Windows.Forms.Button();
            this.lbl_percBrancos = new System.Windows.Forms.Label();
            this.lbl_percNulos = new System.Windows.Forms.Label();
            this.lbl_percValidos = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_resultTotal = new System.Windows.Forms.Label();
            this.lbl_resultValido = new System.Windows.Forms.Label();
            this.lbl_resultNulos = new System.Windows.Forms.Label();
            this.lbl_resultBrancos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblbrancos
            // 
            this.lblbrancos.AutoSize = true;
            this.lblbrancos.Location = new System.Drawing.Point(34, 39);
            this.lblbrancos.Name = "lblbrancos";
            this.lblbrancos.Size = new System.Drawing.Size(102, 20);
            this.lblbrancos.TabIndex = 0;
            this.lblbrancos.Text = "Votos brancos";
            // 
            // lbl_nulos
            // 
            this.lbl_nulos.AutoSize = true;
            this.lbl_nulos.Location = new System.Drawing.Point(34, 84);
            this.lbl_nulos.Name = "lbl_nulos";
            this.lbl_nulos.Size = new System.Drawing.Size(85, 20);
            this.lbl_nulos.TabIndex = 1;
            this.lbl_nulos.Text = "Votos nulos";
            // 
            // lbl_validos
            // 
            this.lbl_validos.AutoSize = true;
            this.lbl_validos.Location = new System.Drawing.Point(34, 138);
            this.lbl_validos.Name = "lbl_validos";
            this.lbl_validos.Size = new System.Drawing.Size(97, 20);
            this.lbl_validos.TabIndex = 2;
            this.lbl_validos.Text = "Votos válidos";
            // 
            // tb_brancos
            // 
            this.tb_brancos.Location = new System.Drawing.Point(142, 32);
            this.tb_brancos.Name = "tb_brancos";
            this.tb_brancos.Size = new System.Drawing.Size(125, 27);
            this.tb_brancos.TabIndex = 3;
            // 
            // tb_nulos
            // 
            this.tb_nulos.Location = new System.Drawing.Point(142, 77);
            this.tb_nulos.Name = "tb_nulos";
            this.tb_nulos.Size = new System.Drawing.Size(125, 27);
            this.tb_nulos.TabIndex = 4;
            // 
            // tb_valido
            // 
            this.tb_valido.Location = new System.Drawing.Point(142, 131);
            this.tb_valido.Name = "tb_valido";
            this.tb_valido.Size = new System.Drawing.Size(125, 27);
            this.tb_valido.TabIndex = 5;
            // 
            // tbn_calcular
            // 
            this.tbn_calcular.Location = new System.Drawing.Point(60, 201);
            this.tbn_calcular.Name = "tbn_calcular";
            this.tbn_calcular.Size = new System.Drawing.Size(172, 29);
            this.tbn_calcular.TabIndex = 6;
            this.tbn_calcular.Text = "Calcular";
            this.tbn_calcular.UseVisualStyleBackColor = true;
            this.tbn_calcular.Click += new System.EventHandler(this.tbn_calcular_Click);
            // 
            // lbl_percBrancos
            // 
            this.lbl_percBrancos.AutoSize = true;
            this.lbl_percBrancos.Location = new System.Drawing.Point(53, 266);
            this.lbl_percBrancos.Name = "lbl_percBrancos";
            this.lbl_percBrancos.Size = new System.Drawing.Size(118, 20);
            this.lbl_percBrancos.TabIndex = 7;
            this.lbl_percBrancos.Text = "Votos brancos %";
            // 
            // lbl_percNulos
            // 
            this.lbl_percNulos.AutoSize = true;
            this.lbl_percNulos.Location = new System.Drawing.Point(53, 319);
            this.lbl_percNulos.Name = "lbl_percNulos";
            this.lbl_percNulos.Size = new System.Drawing.Size(101, 20);
            this.lbl_percNulos.TabIndex = 8;
            this.lbl_percNulos.Text = "Votos nulos %";
            // 
            // lbl_percValidos
            // 
            this.lbl_percValidos.AutoSize = true;
            this.lbl_percValidos.Location = new System.Drawing.Point(53, 369);
            this.lbl_percValidos.Name = "lbl_percValidos";
            this.lbl_percValidos.Size = new System.Drawing.Size(113, 20);
            this.lbl_percValidos.TabIndex = 9;
            this.lbl_percValidos.Text = "Votos válidos %";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(53, 430);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(103, 20);
            this.lbl_total.TabIndex = 10;
            this.lbl_total.Text = "Total de votos";
            // 
            // lbl_resultTotal
            // 
            this.lbl_resultTotal.AutoSize = true;
            this.lbl_resultTotal.Location = new System.Drawing.Point(174, 430);
            this.lbl_resultTotal.Name = "lbl_resultTotal";
            this.lbl_resultTotal.Size = new System.Drawing.Size(50, 20);
            this.lbl_resultTotal.TabIndex = 14;
            this.lbl_resultTotal.Text = "label8";
            this.lbl_resultTotal.Visible = false;
            // 
            // lbl_resultValido
            // 
            this.lbl_resultValido.AutoSize = true;
            this.lbl_resultValido.Location = new System.Drawing.Point(174, 369);
            this.lbl_resultValido.Name = "lbl_resultValido";
            this.lbl_resultValido.Size = new System.Drawing.Size(50, 20);
            this.lbl_resultValido.TabIndex = 13;
            this.lbl_resultValido.Text = "label9";
            this.lbl_resultValido.Visible = false;
            // 
            // lbl_resultNulos
            // 
            this.lbl_resultNulos.AutoSize = true;
            this.lbl_resultNulos.Location = new System.Drawing.Point(174, 319);
            this.lbl_resultNulos.Name = "lbl_resultNulos";
            this.lbl_resultNulos.Size = new System.Drawing.Size(58, 20);
            this.lbl_resultNulos.TabIndex = 12;
            this.lbl_resultNulos.Text = "lable12";
            this.lbl_resultNulos.Visible = false;
            // 
            // lbl_resultBrancos
            // 
            this.lbl_resultBrancos.AutoSize = true;
            this.lbl_resultBrancos.Location = new System.Drawing.Point(174, 266);
            this.lbl_resultBrancos.Name = "lbl_resultBrancos";
            this.lbl_resultBrancos.Size = new System.Drawing.Size(58, 20);
            this.lbl_resultBrancos.TabIndex = 11;
            this.lbl_resultBrancos.Text = "label11";
            this.lbl_resultBrancos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 492);
            this.Controls.Add(this.lbl_resultTotal);
            this.Controls.Add(this.lbl_resultValido);
            this.Controls.Add(this.lbl_resultNulos);
            this.Controls.Add(this.lbl_resultBrancos);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_percValidos);
            this.Controls.Add(this.lbl_percNulos);
            this.Controls.Add(this.lbl_percBrancos);
            this.Controls.Add(this.tbn_calcular);
            this.Controls.Add(this.tb_valido);
            this.Controls.Add(this.tb_nulos);
            this.Controls.Add(this.tb_brancos);
            this.Controls.Add(this.lbl_validos);
            this.Controls.Add(this.lbl_nulos);
            this.Controls.Add(this.lblbrancos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbrancos;
        private System.Windows.Forms.Label lbl_nulos;
        private System.Windows.Forms.Label lbl_validos;
        private System.Windows.Forms.TextBox tb_brancos;
        private System.Windows.Forms.TextBox tb_nulos;
        private System.Windows.Forms.TextBox tb_valido;
        private System.Windows.Forms.Button tbn_calcular;
        private System.Windows.Forms.Label lbl_percBrancos;
        private System.Windows.Forms.Label lbl_percNulos;
        private System.Windows.Forms.Label lbl_percValidos;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_resultTotal;
        private System.Windows.Forms.Label lbl_resultValido;
        private System.Windows.Forms.Label lbl_resultNulos;
        private System.Windows.Forms.Label lbl_resultBrancos;
    }
}

