
namespace Ficha3Ex1 {
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
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.lstv_avaliacao = new System.Windows.Forms.ListView();
            this.col_marca = new System.Windows.Forms.ColumnHeader();
            this.col_modelo = new System.Windows.Forms.ColumnHeader();
            this.col_avaliacao = new System.Windows.Forms.ColumnHeader();
            this.gb_avaliacao = new System.Windows.Forms.GroupBox();
            this.cb_preco = new System.Windows.Forms.ComboBox();
            this.cb_extras = new System.Windows.Forms.ComboBox();
            this.cb_consumo = new System.Windows.Forms.ComboBox();
            this.cb_motorizacao = new System.Windows.Forms.ComboBox();
            this.cb_conforto = new System.Windows.Forms.ComboBox();
            this.cb_design = new System.Windows.Forms.ComboBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_extras = new System.Windows.Forms.Label();
            this.lbl_consumo = new System.Windows.Forms.Label();
            this.lbl_motorização = new System.Windows.Forms.Label();
            this.lbl_conforto = new System.Windows.Forms.Label();
            this.tb_design = new System.Windows.Forms.Label();
            this.btn_pontuar = new System.Windows.Forms.Button();
            this.gb_avaliacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(10, 25);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(50, 20);
            this.lbl_marca.TabIndex = 0;
            this.lbl_marca.Text = "Marca";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(10, 67);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(61, 20);
            this.lbl_modelo.TabIndex = 1;
            this.lbl_modelo.Text = "Modelo";
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(89, 25);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(125, 27);
            this.tb_marca.TabIndex = 2;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(89, 67);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(125, 27);
            this.tb_modelo.TabIndex = 3;
            // 
            // lstv_avaliacao
            // 
            this.lstv_avaliacao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_marca,
            this.col_modelo,
            this.col_avaliacao});
            this.lstv_avaliacao.HideSelection = false;
            this.lstv_avaliacao.Location = new System.Drawing.Point(236, 25);
            this.lstv_avaliacao.Name = "lstv_avaliacao";
            this.lstv_avaliacao.Size = new System.Drawing.Size(315, 401);
            this.lstv_avaliacao.TabIndex = 4;
            this.lstv_avaliacao.UseCompatibleStateImageBehavior = false;
            this.lstv_avaliacao.View = System.Windows.Forms.View.Details;
            // 
            // col_marca
            // 
            this.col_marca.Text = "Marca";
            this.col_marca.Width = 100;
            // 
            // col_modelo
            // 
            this.col_modelo.Text = "Modelo";
            this.col_modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_modelo.Width = 100;
            // 
            // col_avaliacao
            // 
            this.col_avaliacao.Text = "Avaliação";
            this.col_avaliacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_avaliacao.Width = 100;
            // 
            // gb_avaliacao
            // 
            this.gb_avaliacao.Controls.Add(this.cb_preco);
            this.gb_avaliacao.Controls.Add(this.cb_extras);
            this.gb_avaliacao.Controls.Add(this.cb_consumo);
            this.gb_avaliacao.Controls.Add(this.cb_motorizacao);
            this.gb_avaliacao.Controls.Add(this.cb_conforto);
            this.gb_avaliacao.Controls.Add(this.cb_design);
            this.gb_avaliacao.Controls.Add(this.lbl_preco);
            this.gb_avaliacao.Controls.Add(this.lbl_extras);
            this.gb_avaliacao.Controls.Add(this.lbl_consumo);
            this.gb_avaliacao.Controls.Add(this.lbl_motorização);
            this.gb_avaliacao.Controls.Add(this.lbl_conforto);
            this.gb_avaliacao.Controls.Add(this.tb_design);
            this.gb_avaliacao.Location = new System.Drawing.Point(12, 115);
            this.gb_avaliacao.Name = "gb_avaliacao";
            this.gb_avaliacao.Size = new System.Drawing.Size(193, 311);
            this.gb_avaliacao.TabIndex = 5;
            this.gb_avaliacao.TabStop = false;
            this.gb_avaliacao.Text = "Avaliação";
            // 
            // cb_preco
            // 
            this.cb_preco.FormattingEnabled = true;
            this.cb_preco.Location = new System.Drawing.Point(108, 263);
            this.cb_preco.Name = "cb_preco";
            this.cb_preco.Size = new System.Drawing.Size(65, 28);
            this.cb_preco.TabIndex = 11;
            // 
            // cb_extras
            // 
            this.cb_extras.FormattingEnabled = true;
            this.cb_extras.Location = new System.Drawing.Point(108, 218);
            this.cb_extras.Name = "cb_extras";
            this.cb_extras.Size = new System.Drawing.Size(66, 28);
            this.cb_extras.TabIndex = 10;
            // 
            // cb_consumo
            // 
            this.cb_consumo.FormattingEnabled = true;
            this.cb_consumo.Location = new System.Drawing.Point(108, 171);
            this.cb_consumo.Name = "cb_consumo";
            this.cb_consumo.Size = new System.Drawing.Size(67, 28);
            this.cb_consumo.TabIndex = 9;
            // 
            // cb_motorizacao
            // 
            this.cb_motorizacao.FormattingEnabled = true;
            this.cb_motorizacao.Location = new System.Drawing.Point(108, 125);
            this.cb_motorizacao.Name = "cb_motorizacao";
            this.cb_motorizacao.Size = new System.Drawing.Size(65, 28);
            this.cb_motorizacao.TabIndex = 8;
            // 
            // cb_conforto
            // 
            this.cb_conforto.FormattingEnabled = true;
            this.cb_conforto.Location = new System.Drawing.Point(108, 77);
            this.cb_conforto.Name = "cb_conforto";
            this.cb_conforto.Size = new System.Drawing.Size(65, 28);
            this.cb_conforto.TabIndex = 7;
            // 
            // cb_design
            // 
            this.cb_design.FormattingEnabled = true;
            this.cb_design.Location = new System.Drawing.Point(108, 32);
            this.cb_design.Name = "cb_design";
            this.cb_design.Size = new System.Drawing.Size(66, 28);
            this.cb_design.TabIndex = 6;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(6, 263);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(46, 20);
            this.lbl_preco.TabIndex = 5;
            this.lbl_preco.Text = "Preço";
            // 
            // lbl_extras
            // 
            this.lbl_extras.AutoSize = true;
            this.lbl_extras.Location = new System.Drawing.Point(6, 218);
            this.lbl_extras.Name = "lbl_extras";
            this.lbl_extras.Size = new System.Drawing.Size(48, 20);
            this.lbl_extras.TabIndex = 4;
            this.lbl_extras.Text = "Extras";
            // 
            // lbl_consumo
            // 
            this.lbl_consumo.AutoSize = true;
            this.lbl_consumo.Location = new System.Drawing.Point(6, 171);
            this.lbl_consumo.Name = "lbl_consumo";
            this.lbl_consumo.Size = new System.Drawing.Size(71, 20);
            this.lbl_consumo.TabIndex = 3;
            this.lbl_consumo.Text = "Consumo";
            // 
            // lbl_motorização
            // 
            this.lbl_motorização.AutoSize = true;
            this.lbl_motorização.Location = new System.Drawing.Point(6, 125);
            this.lbl_motorização.Name = "lbl_motorização";
            this.lbl_motorização.Size = new System.Drawing.Size(93, 20);
            this.lbl_motorização.TabIndex = 2;
            this.lbl_motorização.Text = "Motorização";
            // 
            // lbl_conforto
            // 
            this.lbl_conforto.AutoSize = true;
            this.lbl_conforto.Location = new System.Drawing.Point(6, 77);
            this.lbl_conforto.Name = "lbl_conforto";
            this.lbl_conforto.Size = new System.Drawing.Size(68, 20);
            this.lbl_conforto.TabIndex = 1;
            this.lbl_conforto.Text = "Conforto";
            // 
            // tb_design
            // 
            this.tb_design.AutoSize = true;
            this.tb_design.Location = new System.Drawing.Point(6, 32);
            this.tb_design.Name = "tb_design";
            this.tb_design.Size = new System.Drawing.Size(55, 20);
            this.tb_design.TabIndex = 0;
            this.tb_design.Text = "Design";
            // 
            // btn_pontuar
            // 
            this.btn_pontuar.Location = new System.Drawing.Point(20, 441);
            this.btn_pontuar.Name = "btn_pontuar";
            this.btn_pontuar.Size = new System.Drawing.Size(167, 42);
            this.btn_pontuar.TabIndex = 6;
            this.btn_pontuar.Text = "Pontuar Veículo";
            this.btn_pontuar.UseVisualStyleBackColor = true;
            this.btn_pontuar.Click += new System.EventHandler(this.btn_pontuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 495);
            this.Controls.Add(this.btn_pontuar);
            this.Controls.Add(this.gb_avaliacao);
            this.Controls.Add(this.lstv_avaliacao);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.lbl_marca);
            this.Name = "Form1";
            this.Text = "Avaliação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_avaliacao.ResumeLayout(false);
            this.gb_avaliacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.ListView lstv_avaliacao;
        private System.Windows.Forms.GroupBox gb_avaliacao;
        private System.Windows.Forms.ComboBox cb_preco;
        private System.Windows.Forms.ComboBox cb_extras;
        private System.Windows.Forms.ComboBox cb_consumo;
        private System.Windows.Forms.ComboBox cb_motorizacao;
        private System.Windows.Forms.ComboBox cb_conforto;
        private System.Windows.Forms.ComboBox cb_design;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_extras;
        private System.Windows.Forms.Label lbl_consumo;
        private System.Windows.Forms.Label lbl_motorização;
        private System.Windows.Forms.Label lbl_conforto;
        private System.Windows.Forms.Label tb_design;
        private System.Windows.Forms.ColumnHeader col_marca;
        private System.Windows.Forms.ColumnHeader col_modelo;
        private System.Windows.Forms.ColumnHeader col_avaliacao;
        private System.Windows.Forms.Button btn_pontuar;
    }
}

