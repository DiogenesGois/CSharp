
namespace Ficha2Ex2 {
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
            this.cb_parImpar = new System.Windows.Forms.ComboBox();
            this.lsb_resultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cb_parImpar
            // 
            this.cb_parImpar.FormattingEnabled = true;
            this.cb_parImpar.Location = new System.Drawing.Point(66, 45);
            this.cb_parImpar.Name = "cb_parImpar";
            this.cb_parImpar.Size = new System.Drawing.Size(151, 28);
            this.cb_parImpar.TabIndex = 0;
            this.cb_parImpar.SelectedIndexChanged += new System.EventHandler(this.cb_parImpar_SelectedIndexChanged);
            // 
            // lsb_resultado
            // 
            this.lsb_resultado.FormattingEnabled = true;
            this.lsb_resultado.ItemHeight = 20;
            this.lsb_resultado.Location = new System.Drawing.Point(66, 107);
            this.lsb_resultado.Name = "lsb_resultado";
            this.lsb_resultado.Size = new System.Drawing.Size(150, 204);
            this.lsb_resultado.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 363);
            this.Controls.Add(this.lsb_resultado);
            this.Controls.Add(this.cb_parImpar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_parImpar;
        private System.Windows.Forms.ListBox lsb_resultado;
    }
}

