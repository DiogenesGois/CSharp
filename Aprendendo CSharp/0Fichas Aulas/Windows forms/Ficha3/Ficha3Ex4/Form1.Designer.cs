
namespace Ficha3Ex4 {
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
            this.lbl_numero = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.dgv_matriz = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_coluna = new System.Windows.Forms.Label();
            this.tb_colunas = new System.Windows.Forms.TextBox();
            this.lbl_linhas = new System.Windows.Forms.Label();
            this.tb_linhas = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_diagonal = new System.Windows.Forms.Label();
            this.lbl_pares = new System.Windows.Forms.Label();
            this.lbl_impares = new System.Windows.Forms.Label();
            this.tb_diagonal = new System.Windows.Forms.TextBox();
            this.tb_pares = new System.Windows.Forms.TextBox();
            this.tb_impares = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(30, 34);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(63, 20);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "Número";
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(99, 34);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(87, 27);
            this.tb_numero.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(192, 32);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(49, 29);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dgv_matriz
            // 
            this.dgv_matriz.AllowUserToAddRows = false;
            this.dgv_matriz.AllowUserToDeleteRows = false;
            this.dgv_matriz.AllowUserToResizeColumns = false;
            this.dgv_matriz.AllowUserToResizeRows = false;
            this.dgv_matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matriz.ColumnHeadersVisible = false;
            this.dgv_matriz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_matriz.Location = new System.Drawing.Point(12, 83);
            this.dgv_matriz.Name = "dgv_matriz";
            this.dgv_matriz.RowHeadersVisible = false;
            this.dgv_matriz.RowHeadersWidth = 51;
            this.dgv_matriz.RowTemplate.Height = 29;
            this.dgv_matriz.Size = new System.Drawing.Size(174, 90);
            this.dgv_matriz.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 57;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 57;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 57;
            // 
            // lbl_coluna
            // 
            this.lbl_coluna.AutoSize = true;
            this.lbl_coluna.Location = new System.Drawing.Point(216, 83);
            this.lbl_coluna.Name = "lbl_coluna";
            this.lbl_coluna.Size = new System.Drawing.Size(64, 20);
            this.lbl_coluna.TabIndex = 4;
            this.lbl_coluna.Text = "Colunas:";
            // 
            // tb_colunas
            // 
            this.tb_colunas.Enabled = false;
            this.tb_colunas.Location = new System.Drawing.Point(216, 106);
            this.tb_colunas.Name = "tb_colunas";
            this.tb_colunas.Size = new System.Drawing.Size(61, 27);
            this.tb_colunas.TabIndex = 5;
            this.tb_colunas.TextChanged += new System.EventHandler(this.tb_colunas_TextChanged);
            // 
            // lbl_linhas
            // 
            this.lbl_linhas.AutoSize = true;
            this.lbl_linhas.Location = new System.Drawing.Point(216, 147);
            this.lbl_linhas.Name = "lbl_linhas";
            this.lbl_linhas.Size = new System.Drawing.Size(50, 20);
            this.lbl_linhas.TabIndex = 6;
            this.lbl_linhas.Text = "Linhas";
            // 
            // tb_linhas
            // 
            this.tb_linhas.Enabled = false;
            this.tb_linhas.Location = new System.Drawing.Point(216, 170);
            this.tb_linhas.Name = "tb_linhas";
            this.tb_linhas.Size = new System.Drawing.Size(61, 27);
            this.tb_linhas.TabIndex = 7;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(44, 221);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(222, 31);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular e Apresentar Valores";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_diagonal
            // 
            this.lbl_diagonal.AutoSize = true;
            this.lbl_diagonal.Location = new System.Drawing.Point(12, 274);
            this.lbl_diagonal.Name = "lbl_diagonal";
            this.lbl_diagonal.Size = new System.Drawing.Size(133, 20);
            this.lbl_diagonal.TabIndex = 9;
            this.lbl_diagonal.Text = "Soma da Diagonal";
            // 
            // lbl_pares
            // 
            this.lbl_pares.AutoSize = true;
            this.lbl_pares.Location = new System.Drawing.Point(12, 312);
            this.lbl_pares.Name = "lbl_pares";
            this.lbl_pares.Size = new System.Drawing.Size(165, 20);
            this.lbl_pares.TabIndex = 10;
            this.lbl_pares.Text = "Soma dos Valores Pares";
            // 
            // lbl_impares
            // 
            this.lbl_impares.AutoSize = true;
            this.lbl_impares.Location = new System.Drawing.Point(12, 351);
            this.lbl_impares.Name = "lbl_impares";
            this.lbl_impares.Size = new System.Drawing.Size(184, 20);
            this.lbl_impares.TabIndex = 11;
            this.lbl_impares.Text = "Soma dos Valores Ímpares";
            // 
            // tb_diagonal
            // 
            this.tb_diagonal.Enabled = false;
            this.tb_diagonal.Location = new System.Drawing.Point(216, 274);
            this.tb_diagonal.Name = "tb_diagonal";
            this.tb_diagonal.Size = new System.Drawing.Size(64, 27);
            this.tb_diagonal.TabIndex = 12;
            // 
            // tb_pares
            // 
            this.tb_pares.Enabled = false;
            this.tb_pares.Location = new System.Drawing.Point(216, 312);
            this.tb_pares.Name = "tb_pares";
            this.tb_pares.Size = new System.Drawing.Size(64, 27);
            this.tb_pares.TabIndex = 13;
            // 
            // tb_impares
            // 
            this.tb_impares.Enabled = false;
            this.tb_impares.Location = new System.Drawing.Point(216, 348);
            this.tb_impares.Name = "tb_impares";
            this.tb_impares.Size = new System.Drawing.Size(64, 27);
            this.tb_impares.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 393);
            this.Controls.Add(this.tb_impares);
            this.Controls.Add(this.tb_pares);
            this.Controls.Add(this.tb_diagonal);
            this.Controls.Add(this.lbl_impares);
            this.Controls.Add(this.lbl_pares);
            this.Controls.Add(this.lbl_diagonal);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tb_linhas);
            this.Controls.Add(this.lbl_linhas);
            this.Controls.Add(this.tb_colunas);
            this.Controls.Add(this.lbl_coluna);
            this.Controls.Add(this.dgv_matriz);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.lbl_numero);
            this.Name = "Form1";
            this.Text = "p";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridView dgv_matriz;
        private System.Windows.Forms.Label lbl_coluna;
        private System.Windows.Forms.TextBox tb_colunas;
        private System.Windows.Forms.Label lbl_linhas;
        private System.Windows.Forms.TextBox tb_linhas;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_diagonal;
        private System.Windows.Forms.Label lbl_pares;
        private System.Windows.Forms.Label lbl_impares;
        private System.Windows.Forms.TextBox tb_diagonal;
        private System.Windows.Forms.TextBox tb_pares;
        private System.Windows.Forms.TextBox tb_impares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

