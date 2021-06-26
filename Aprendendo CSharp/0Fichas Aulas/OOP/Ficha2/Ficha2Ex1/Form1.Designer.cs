
namespace WinFormsApp1 {
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
            this.components = new System.ComponentModel.Container();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cb_numero = new System.Windows.Forms.ComboBox();
            this.lstb_tabuada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(64, 37);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(67, 20);
            this.lbl_num1.TabIndex = 0;
            this.lbl_num1.Text = "Número ";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cb_numero
            // 
            this.cb_numero.FormattingEnabled = true;
            this.cb_numero.Location = new System.Drawing.Point(185, 34);
            this.cb_numero.Name = "cb_numero";
            this.cb_numero.Size = new System.Drawing.Size(151, 28);
            this.cb_numero.TabIndex = 1;
            this.cb_numero.SelectedIndexChanged += new System.EventHandler(this.cb_numero_SelectedIndexChanged);
            // 
            // lstb_tabuada
            // 
            this.lstb_tabuada.FormattingEnabled = true;
            this.lstb_tabuada.ItemHeight = 20;
            this.lstb_tabuada.Location = new System.Drawing.Point(93, 145);
            this.lstb_tabuada.Name = "lstb_tabuada";
            this.lstb_tabuada.Size = new System.Drawing.Size(215, 224);
            this.lstb_tabuada.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 479);
            this.Controls.Add(this.lstb_tabuada);
            this.Controls.Add(this.cb_numero);
            this.Controls.Add(this.lbl_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cb_numero;
        private System.Windows.Forms.ListBox lstb_tabuada;
    }
}

