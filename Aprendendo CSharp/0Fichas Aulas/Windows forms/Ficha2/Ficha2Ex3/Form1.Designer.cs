
namespace Ficha2Ex3 {
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lbltop = new System.Windows.Forms.Label();
            this.tb_bottom = new System.Windows.Forms.TextBox();
            this.tb_top = new System.Windows.Forms.TextBox();
            this.btn_somar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(137, 250);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(71, 20);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "resultado";
            this.lbl_resultado.Visible = false;
            // 
            // lblBottom
            // 
            this.lblBottom.AutoSize = true;
            this.lblBottom.Location = new System.Drawing.Point(57, 48);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(59, 20);
            this.lblBottom.TabIndex = 3;
            this.lblBottom.Text = "Bottom";
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Location = new System.Drawing.Point(57, 114);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(34, 20);
            this.lbltop.TabIndex = 4;
            this.lbltop.Text = "Top";
            // 
            // tb_bottom
            // 
            this.tb_bottom.Location = new System.Drawing.Point(186, 48);
            this.tb_bottom.Name = "tb_bottom";
            this.tb_bottom.Size = new System.Drawing.Size(125, 27);
            this.tb_bottom.TabIndex = 5;
            // 
            // tb_top
            // 
            this.tb_top.Location = new System.Drawing.Point(186, 114);
            this.tb_top.Name = "tb_top";
            this.tb_top.Size = new System.Drawing.Size(125, 27);
            this.tb_top.TabIndex = 6;
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(137, 188);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(94, 29);
            this.btn_somar.TabIndex = 7;
            this.btn_somar.Text = "somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 309);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.tb_top);
            this.Controls.Add(this.tb_bottom);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lbl_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.TextBox tb_bottom;
        private System.Windows.Forms.TextBox tb_top;
        private System.Windows.Forms.Button btn_somar;
    }
}

