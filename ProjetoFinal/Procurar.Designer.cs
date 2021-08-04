
namespace ProjetoFinal {
    partial class Procurar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Procurar));
            this.dgv_procurar = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codmodelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codmarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procurar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_procurar
            // 
            this.dgv_procurar.AllowUserToAddRows = false;
            this.dgv_procurar.AllowUserToDeleteRows = false;
            this.dgv_procurar.AllowUserToResizeColumns = false;
            this.dgv_procurar.AllowUserToResizeRows = false;
            this.dgv_procurar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_procurar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_procurar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.dgv_procurar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_procurar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_procurar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_procurar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_procurar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_procurar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.codmodelo,
            this.modelo,
            this.codmarca,
            this.marca});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_procurar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_procurar.Enabled = false;
            this.dgv_procurar.EnableHeadersVisualStyles = false;
            this.dgv_procurar.Location = new System.Drawing.Point(43, 168);
            this.dgv_procurar.Name = "dgv_procurar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_procurar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_procurar.RowHeadersVisible = false;
            this.dgv_procurar.RowHeadersWidth = 51;
            this.dgv_procurar.RowTemplate.Height = 24;
            this.dgv_procurar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_procurar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_procurar.Size = new System.Drawing.Size(804, 393);
            this.dgv_procurar.TabIndex = 6;
            // 
            // num
            // 
            this.num.HeaderText = "Número";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            // 
            // codmodelo
            // 
            this.codmodelo.HeaderText = "Código do Modelo";
            this.codmodelo.MinimumWidth = 6;
            this.codmodelo.Name = "codmodelo";
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.MinimumWidth = 6;
            this.modelo.Name = "modelo";
            // 
            // codmarca
            // 
            this.codmarca.HeaderText = "Código da Marca";
            this.codmarca.MinimumWidth = 6;
            this.codmarca.Name = "codmarca";
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            // 
            // btn_procurar
            // 
            this.btn_procurar.FlatAppearance.BorderSize = 0;
            this.btn_procurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.btn_procurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.btn_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procurar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_procurar.Location = new System.Drawing.Point(573, 12);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(84, 39);
            this.btn_procurar.TabIndex = 0;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 1);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(332, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 1);
            this.label2.TabIndex = 15;
            // 
            // cb_marca
            // 
            this.cb_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.cb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_marca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(47, 64);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(193, 31);
            this.cb_marca.TabIndex = 16;
            this.cb_marca.Text = "MARCA";
            this.cb_marca.SelectedIndexChanged += new System.EventHandler(this.cb_marca_SelectedIndexChanged);
            // 
            // cb_modelo
            // 
            this.cb_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.cb_modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_modelo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(334, 64);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(182, 31);
            this.cb_modelo.TabIndex = 17;
            this.cb_modelo.Text = "MODELO";
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_limpar.Location = new System.Drawing.Point(566, 108);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(84, 39);
            this.btn_limpar.TabIndex = 19;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.btn_exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_exportar.Location = new System.Drawing.Point(575, 62);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(75, 35);
            this.btn_exportar.TabIndex = 20;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // Procurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(946, 594);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.cb_modelo);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.dgv_procurar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Procurar";
            this.Text = "Procurar";
            this.Load += new System.EventHandler(this.Procurar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgv_procurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmodelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_exportar;
        public System.Windows.Forms.ComboBox cb_marca;
        public System.Windows.Forms.ComboBox cb_modelo;
    }
}