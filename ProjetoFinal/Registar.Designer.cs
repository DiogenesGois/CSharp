
namespace ProjetoFinal {
    partial class Registar {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar));
            this.tb_modeloRegistar = new System.Windows.Forms.TextBox();
            this.tb_codModeloRegistar = new System.Windows.Forms.TextBox();
            this.tb_marcaRegistar = new System.Windows.Forms.TextBox();
            this.tb_codMarcaRegistar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_idmarca = new System.Windows.Forms.NumericUpDown();
            this.tt_dica = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_idmarca)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_modeloRegistar
            // 
            this.tb_modeloRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.tb_modeloRegistar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_modeloRegistar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modeloRegistar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.tb_modeloRegistar.Location = new System.Drawing.Point(266, 122);
            this.tb_modeloRegistar.Name = "tb_modeloRegistar";
            this.tb_modeloRegistar.Size = new System.Drawing.Size(184, 25);
            this.tb_modeloRegistar.TabIndex = 13;
            this.tb_modeloRegistar.Text = "Modelo";
            this.tb_modeloRegistar.TextChanged += new System.EventHandler(this.tb_modeloRegistar_TextChanged);
            this.tb_modeloRegistar.Enter += new System.EventHandler(this.tb_modeloRegistar_Enter);
            // 
            // tb_codModeloRegistar
            // 
            this.tb_codModeloRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.tb_codModeloRegistar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_codModeloRegistar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codModeloRegistar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.tb_codModeloRegistar.Location = new System.Drawing.Point(31, 122);
            this.tb_codModeloRegistar.Name = "tb_codModeloRegistar";
            this.tb_codModeloRegistar.Size = new System.Drawing.Size(193, 25);
            this.tb_codModeloRegistar.TabIndex = 12;
            this.tb_codModeloRegistar.Text = "Código do Modelo";
            this.tb_codModeloRegistar.Enter += new System.EventHandler(this.tb_codModeloRegistar_Enter);
            // 
            // tb_marcaRegistar
            // 
            this.tb_marcaRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.tb_marcaRegistar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_marcaRegistar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_marcaRegistar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.tb_marcaRegistar.Location = new System.Drawing.Point(266, 45);
            this.tb_marcaRegistar.Name = "tb_marcaRegistar";
            this.tb_marcaRegistar.Size = new System.Drawing.Size(184, 25);
            this.tb_marcaRegistar.TabIndex = 11;
            this.tb_marcaRegistar.Text = "Marca";
            this.tb_marcaRegistar.TextChanged += new System.EventHandler(this.tb_marcaRegistar_TextChanged);
            this.tb_marcaRegistar.Enter += new System.EventHandler(this.tb_marcaRegistar_Enter);
            // 
            // tb_codMarcaRegistar
            // 
            this.tb_codMarcaRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.tb_codMarcaRegistar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_codMarcaRegistar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codMarcaRegistar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.tb_codMarcaRegistar.Location = new System.Drawing.Point(31, 45);
            this.tb_codMarcaRegistar.Name = "tb_codMarcaRegistar";
            this.tb_codMarcaRegistar.Size = new System.Drawing.Size(193, 25);
            this.tb_codMarcaRegistar.TabIndex = 10;
            this.tb_codMarcaRegistar.Text = "Código da Marca";
            this.tb_codMarcaRegistar.Enter += new System.EventHandler(this.tb_codMarcaRegistar_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 1);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(263, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 1);
            this.label2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(31, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 1);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(266, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 1);
            this.label4.TabIndex = 17;
            // 
            // pb_logo
            // 
            this.pb_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(278, 211);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(408, 291);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 18;
            this.pb_logo.TabStop = false;
            // 
            // btn_inserir
            // 
            this.btn_inserir.FlatAppearance.BorderSize = 0;
            this.btn_inserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.btn_inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_inserir.Location = new System.Drawing.Point(521, 98);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 29);
            this.btn_inserir.TabIndex = 19;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(31, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 1);
            this.label5.TabIndex = 21;
            // 
            // nud_idmarca
            // 
            this.nud_idmarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.nud_idmarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_idmarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_idmarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.nud_idmarca.Location = new System.Drawing.Point(31, 192);
            this.nud_idmarca.Name = "nud_idmarca";
            this.nud_idmarca.Size = new System.Drawing.Size(193, 28);
            this.nud_idmarca.TabIndex = 22;
            this.tt_dica.SetToolTip(this.nud_idmarca, "Para saber a sequencia correta consulte o menu Marcas.");
            // 
            // Registar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(946, 594);
            this.Controls.Add(this.nud_idmarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_modeloRegistar);
            this.Controls.Add(this.tb_codModeloRegistar);
            this.Controls.Add(this.tb_marcaRegistar);
            this.Controls.Add(this.tb_codMarcaRegistar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registar";
            this.Text = "Registar";
            this.Load += new System.EventHandler(this.Registar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_idmarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_modeloRegistar;
        private System.Windows.Forms.TextBox tb_codModeloRegistar;
        private System.Windows.Forms.TextBox tb_marcaRegistar;
        private System.Windows.Forms.TextBox tb_codMarcaRegistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_idmarca;
        private System.Windows.Forms.ToolTip tt_dica;
    }
}