
namespace Ficha1Ex2 {
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
            this.lblkm = new System.Windows.Forms.Label();
            this.tb_km = new System.Windows.Forms.TextBox();
            this.tb_consumo = new System.Windows.Forms.TextBox();
            this.lbl_consumo = new System.Windows.Forms.Label();
            this.tb_combustivel = new System.Windows.Forms.TextBox();
            this.lbl_combustivel = new System.Windows.Forms.Label();
            this.tbn_calcular = new System.Windows.Forms.Button();
            this.tb_cem = new System.Windows.Forms.TextBox();
            this.lblcem = new System.Windows.Forms.Label();
            this.tb_gasto = new System.Windows.Forms.TextBox();
            this.lblgasto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Location = new System.Drawing.Point(49, 33);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(117, 20);
            this.lblkm.TabIndex = 0;
            this.lblkm.Text = "Kms percorridos";
            // 
            // tb_km
            // 
            this.tb_km.Location = new System.Drawing.Point(218, 33);
            this.tb_km.Name = "tb_km";
            this.tb_km.Size = new System.Drawing.Size(125, 27);
            this.tb_km.TabIndex = 1;
            // 
            // tb_consumo
            // 
            this.tb_consumo.Location = new System.Drawing.Point(218, 91);
            this.tb_consumo.Name = "tb_consumo";
            this.tb_consumo.Size = new System.Drawing.Size(125, 27);
            this.tb_consumo.TabIndex = 3;
            // 
            // lbl_consumo
            // 
            this.lbl_consumo.AutoSize = true;
            this.lbl_consumo.Location = new System.Drawing.Point(49, 91);
            this.lbl_consumo.Name = "lbl_consumo";
            this.lbl_consumo.Size = new System.Drawing.Size(138, 20);
            this.lbl_consumo.TabIndex = 2;
            this.lbl_consumo.Text = "Consumo registado";
            // 
            // tb_combustivel
            // 
            this.tb_combustivel.Location = new System.Drawing.Point(218, 158);
            this.tb_combustivel.Name = "tb_combustivel";
            this.tb_combustivel.Size = new System.Drawing.Size(125, 27);
            this.tb_combustivel.TabIndex = 5;
            // 
            // lbl_combustivel
            // 
            this.lbl_combustivel.AutoSize = true;
            this.lbl_combustivel.Location = new System.Drawing.Point(49, 158);
            this.lbl_combustivel.Name = "lbl_combustivel";
            this.lbl_combustivel.Size = new System.Drawing.Size(130, 20);
            this.lbl_combustivel.TabIndex = 4;
            this.lbl_combustivel.Text = "Preço combustível";
            // 
            // tbn_calcular
            // 
            this.tbn_calcular.Location = new System.Drawing.Point(114, 222);
            this.tbn_calcular.Name = "tbn_calcular";
            this.tbn_calcular.Size = new System.Drawing.Size(212, 29);
            this.tbn_calcular.TabIndex = 6;
            this.tbn_calcular.Text = "Calcular";
            this.tbn_calcular.UseVisualStyleBackColor = true;
            this.tbn_calcular.Click += new System.EventHandler(this.tbn_calcular_Click);
            // 
            // tb_cem
            // 
            this.tb_cem.Location = new System.Drawing.Point(218, 281);
            this.tb_cem.Name = "tb_cem";
            this.tb_cem.ReadOnly = true;
            this.tb_cem.Size = new System.Drawing.Size(125, 27);
            this.tb_cem.TabIndex = 8;
            // 
            // lblcem
            // 
            this.lblcem.AutoSize = true;
            this.lblcem.Location = new System.Drawing.Point(49, 281);
            this.lblcem.Name = "lblcem";
            this.lblcem.Size = new System.Drawing.Size(126, 20);
            this.lblcem.TabIndex = 7;
            this.lblcem.Text = "Consumo aos 100";
            // 
            // tb_gasto
            // 
            this.tb_gasto.Location = new System.Drawing.Point(218, 340);
            this.tb_gasto.Name = "tb_gasto";
            this.tb_gasto.ReadOnly = true;
            this.tb_gasto.Size = new System.Drawing.Size(125, 27);
            this.tb_gasto.TabIndex = 10;
            // 
            // lblgasto
            // 
            this.lblgasto.AutoSize = true;
            this.lblgasto.Location = new System.Drawing.Point(49, 340);
            this.lblgasto.Name = "lblgasto";
            this.lblgasto.Size = new System.Drawing.Size(84, 20);
            this.lblgasto.TabIndex = 9;
            this.lblgasto.Text = "Valor gasto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 393);
            this.Controls.Add(this.tb_gasto);
            this.Controls.Add(this.lblgasto);
            this.Controls.Add(this.tb_cem);
            this.Controls.Add(this.lblcem);
            this.Controls.Add(this.tbn_calcular);
            this.Controls.Add(this.tb_combustivel);
            this.Controls.Add(this.lbl_combustivel);
            this.Controls.Add(this.tb_consumo);
            this.Controls.Add(this.lbl_consumo);
            this.Controls.Add(this.tb_km);
            this.Controls.Add(this.lblkm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.TextBox tb_km;
        private System.Windows.Forms.TextBox tb_consumo;
        private System.Windows.Forms.Label lbl_consumo;
        private System.Windows.Forms.TextBox tb_combustivel;
        private System.Windows.Forms.Label lbl_combustivel;
        private System.Windows.Forms.Button tbn_calcular;
        private System.Windows.Forms.TextBox tb_cem;
        private System.Windows.Forms.Label lblcem;
        private System.Windows.Forms.TextBox tb_gasto;
        private System.Windows.Forms.Label lblgasto;
    }
}

