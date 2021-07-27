
namespace Ficha5Ex1 {
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
            this.lbl_tamanho = new System.Windows.Forms.Label();
            this.lbl_massa = new System.Windows.Forms.Label();
            this.lbl_ingredientes = new System.Windows.Forms.Label();
            this.cboTamanho = new System.Windows.Forms.ComboBox();
            this.cboIngredientes = new System.Windows.Forms.ComboBox();
            this.cboMassa = new System.Windows.Forms.ComboBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lb_ingredientes = new System.Windows.Forms.ListBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_repor = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_tamanho
            // 
            this.lbl_tamanho.AutoSize = true;
            this.lbl_tamanho.Location = new System.Drawing.Point(64, 46);
            this.lbl_tamanho.Name = "lbl_tamanho";
            this.lbl_tamanho.Size = new System.Drawing.Size(69, 20);
            this.lbl_tamanho.TabIndex = 0;
            this.lbl_tamanho.Text = "Tamanho";
            // 
            // lbl_massa
            // 
            this.lbl_massa.AutoSize = true;
            this.lbl_massa.Location = new System.Drawing.Point(83, 80);
            this.lbl_massa.Name = "lbl_massa";
            this.lbl_massa.Size = new System.Drawing.Size(50, 20);
            this.lbl_massa.TabIndex = 1;
            this.lbl_massa.Text = "Massa";
            // 
            // lbl_ingredientes
            // 
            this.lbl_ingredientes.AutoSize = true;
            this.lbl_ingredientes.Location = new System.Drawing.Point(42, 114);
            this.lbl_ingredientes.Name = "lbl_ingredientes";
            this.lbl_ingredientes.Size = new System.Drawing.Size(91, 20);
            this.lbl_ingredientes.TabIndex = 2;
            this.lbl_ingredientes.Text = "Ingredientes";
            // 
            // cboTamanho
            // 
            this.cboTamanho.FormattingEnabled = true;
            this.cboTamanho.Location = new System.Drawing.Point(151, 46);
            this.cboTamanho.Name = "cboTamanho";
            this.cboTamanho.Size = new System.Drawing.Size(151, 28);
            this.cboTamanho.TabIndex = 3;
            // 
            // cboIngredientes
            // 
            this.cboIngredientes.FormattingEnabled = true;
            this.cboIngredientes.Location = new System.Drawing.Point(151, 114);
            this.cboIngredientes.Name = "cboIngredientes";
            this.cboIngredientes.Size = new System.Drawing.Size(151, 28);
            this.cboIngredientes.TabIndex = 4;
            // 
            // cboMassa
            // 
            this.cboMassa.FormattingEnabled = true;
            this.cboMassa.Location = new System.Drawing.Point(151, 80);
            this.cboMassa.Name = "cboMassa";
            this.cboMassa.Size = new System.Drawing.Size(151, 28);
            this.cboMassa.TabIndex = 5;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Image = global::Ficha5Ex1.Properties.Resources.check;
            this.btn_adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adicionar.Location = new System.Drawing.Point(321, 124);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(118, 37);
            this.btn_adicionar.TabIndex = 6;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lb_ingredientes
            // 
            this.lb_ingredientes.FormattingEnabled = true;
            this.lb_ingredientes.ItemHeight = 20;
            this.lb_ingredientes.Location = new System.Drawing.Point(12, 181);
            this.lb_ingredientes.Name = "lb_ingredientes";
            this.lb_ingredientes.Size = new System.Drawing.Size(427, 184);
            this.lb_ingredientes.TabIndex = 7;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(12, 390);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(104, 38);
            this.btn_finalizar.TabIndex = 8;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_repor
            // 
            this.btn_repor.Location = new System.Drawing.Point(122, 390);
            this.btn_repor.Name = "btn_repor";
            this.btn_repor.Size = new System.Drawing.Size(104, 38);
            this.btn_repor.TabIndex = 9;
            this.btn_repor.Text = "Repor";
            this.btn_repor.UseVisualStyleBackColor = true;
            this.btn_repor.Click += new System.EventHandler(this.btn_repor_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(260, 399);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(42, 20);
            this.lbl_total.TabIndex = 10;
            this.lbl_total.Text = "Total";
            // 
            // tb_total
            // 
            this.tb_total.ForeColor = System.Drawing.Color.Red;
            this.tb_total.Location = new System.Drawing.Point(314, 396);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(125, 27);
            this.tb_total.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_repor);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.lb_ingredientes);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.cboMassa);
            this.Controls.Add(this.cboIngredientes);
            this.Controls.Add(this.cboTamanho);
            this.Controls.Add(this.lbl_ingredientes);
            this.Controls.Add(this.lbl_massa);
            this.Controls.Add(this.lbl_tamanho);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tamanho;
        private System.Windows.Forms.Label lbl_massa;
        private System.Windows.Forms.Label lbl_ingredientes;
        private System.Windows.Forms.ComboBox cboTamanho;
        private System.Windows.Forms.ComboBox cboIngredientes;
        private System.Windows.Forms.ComboBox cboMassa;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ListBox lb_ingredientes;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_repor;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox tb_total;
    }
}

