
namespace Ficha2Ex4 {
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
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.lsb_numeros = new System.Windows.Forms.ListBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(108, 43);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(125, 27);
            this.tb_numero.TabIndex = 0;
            // 
            // lsb_numeros
            // 
            this.lsb_numeros.FormattingEnabled = true;
            this.lsb_numeros.ItemHeight = 20;
            this.lsb_numeros.Location = new System.Drawing.Point(92, 187);
            this.lsb_numeros.Name = "lsb_numeros";
            this.lsb_numeros.Size = new System.Drawing.Size(169, 184);
            this.lsb_numeros.TabIndex = 1;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(126, 117);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(94, 29);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(2, 414);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(50, 20);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "label1";
            this.lbl_resultado.Visible = false;
            this.lbl_resultado.Click += new System.EventHandler(this.lbl_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 481);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lsb_numeros);
            this.Controls.Add(this.tb_numero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.ListBox lsb_numeros;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

