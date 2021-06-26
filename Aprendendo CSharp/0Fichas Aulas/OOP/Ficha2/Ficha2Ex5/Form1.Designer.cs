
namespace Ficha2Ex5 {
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
            this.lbl_ladox = new System.Windows.Forms.Label();
            this.lbl_ladoy = new System.Windows.Forms.Label();
            this.lbl_ladoz = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.lbl_mostra = new System.Windows.Forms.Label();
            this.tb_ladox = new System.Windows.Forms.TextBox();
            this.tb_ladoz = new System.Windows.Forms.TextBox();
            this.tb_ladoy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_ladox
            // 
            this.lbl_ladox.AutoSize = true;
            this.lbl_ladox.Location = new System.Drawing.Point(94, 23);
            this.lbl_ladox.Name = "lbl_ladox";
            this.lbl_ladox.Size = new System.Drawing.Size(53, 20);
            this.lbl_ladox.TabIndex = 0;
            this.lbl_ladox.Text = "Lado x";
            // 
            // lbl_ladoy
            // 
            this.lbl_ladoy.AutoSize = true;
            this.lbl_ladoy.Location = new System.Drawing.Point(94, 71);
            this.lbl_ladoy.Name = "lbl_ladoy";
            this.lbl_ladoy.Size = new System.Drawing.Size(53, 20);
            this.lbl_ladoy.TabIndex = 1;
            this.lbl_ladoy.Text = "Lado y";
            // 
            // lbl_ladoz
            // 
            this.lbl_ladoz.AutoSize = true;
            this.lbl_ladoz.Location = new System.Drawing.Point(94, 125);
            this.lbl_ladoz.Name = "lbl_ladoz";
            this.lbl_ladoz.Size = new System.Drawing.Size(53, 20);
            this.lbl_ladoz.TabIndex = 2;
            this.lbl_ladoz.Text = "Lado z";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(157, 188);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(94, 29);
            this.btn_mostrar.TabIndex = 3;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // lbl_mostra
            // 
            this.lbl_mostra.AutoSize = true;
            this.lbl_mostra.Location = new System.Drawing.Point(2, 263);
            this.lbl_mostra.Name = "lbl_mostra";
            this.lbl_mostra.Size = new System.Drawing.Size(55, 20);
            this.lbl_mostra.TabIndex = 4;
            this.lbl_mostra.Text = "mostra";
            this.lbl_mostra.Visible = false;
            this.lbl_mostra.Click += new System.EventHandler(this.lbl_mostra_Click);
            // 
            // tb_ladox
            // 
            this.tb_ladox.Location = new System.Drawing.Point(232, 16);
            this.tb_ladox.Name = "tb_ladox";
            this.tb_ladox.Size = new System.Drawing.Size(125, 27);
            this.tb_ladox.TabIndex = 5;
            // 
            // tb_ladoz
            // 
            this.tb_ladoz.Location = new System.Drawing.Point(232, 118);
            this.tb_ladoz.Name = "tb_ladoz";
            this.tb_ladoz.Size = new System.Drawing.Size(125, 27);
            this.tb_ladoz.TabIndex = 6;
            // 
            // tb_ladoy
            // 
            this.tb_ladoy.Location = new System.Drawing.Point(232, 64);
            this.tb_ladoy.Name = "tb_ladoy";
            this.tb_ladoy.Size = new System.Drawing.Size(125, 27);
            this.tb_ladoy.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 338);
            this.Controls.Add(this.tb_ladoy);
            this.Controls.Add(this.tb_ladoz);
            this.Controls.Add(this.tb_ladox);
            this.Controls.Add(this.lbl_mostra);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.lbl_ladoz);
            this.Controls.Add(this.lbl_ladoy);
            this.Controls.Add(this.lbl_ladox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ladox;
        private System.Windows.Forms.Label lbl_ladoy;
        private System.Windows.Forms.Label lbl_ladoz;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label lbl_mostra;
        private System.Windows.Forms.TextBox tb_ladox;
        private System.Windows.Forms.TextBox tb_ladoz;
        private System.Windows.Forms.TextBox tb_ladoy;
    }
}

