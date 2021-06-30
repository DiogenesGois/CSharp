
namespace Ficha3Ex2 {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lbl_escrita = new System.Windows.Forms.Label();
            this.lbl_oral = new System.Windows.Forms.Label();
            this.lbl_fisica = new System.Windows.Forms.Label();
            this.cb_escrita = new System.Windows.Forms.ComboBox();
            this.cb_oral = new System.Windows.Forms.ComboBox();
            this.cb_fisica = new System.Windows.Forms.ComboBox();
            this.gb_linguas = new System.Windows.Forms.GroupBox();
            this.ckb_russo = new System.Windows.Forms.CheckBox();
            this.ckb_portugues = new System.Windows.Forms.CheckBox();
            this.ckb_frances = new System.Windows.Forms.CheckBox();
            this.ckb_espanhol = new System.Windows.Forms.CheckBox();
            this.ckb_alemao = new System.Windows.Forms.CheckBox();
            this.ckb_ingles = new System.Windows.Forms.CheckBox();
            this.btn_submeter = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.dgv_registo = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escrita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linguas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_linguas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(3, 27);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(53, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(85, 27);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(154, 27);
            this.tb_nome.TabIndex = 1;
            // 
            // lbl_escrita
            // 
            this.lbl_escrita.AutoSize = true;
            this.lbl_escrita.Location = new System.Drawing.Point(3, 76);
            this.lbl_escrita.Name = "lbl_escrita";
            this.lbl_escrita.Size = new System.Drawing.Size(52, 20);
            this.lbl_escrita.TabIndex = 2;
            this.lbl_escrita.Text = "Escrita";
            // 
            // lbl_oral
            // 
            this.lbl_oral.AutoSize = true;
            this.lbl_oral.Location = new System.Drawing.Point(3, 125);
            this.lbl_oral.Name = "lbl_oral";
            this.lbl_oral.Size = new System.Drawing.Size(78, 20);
            this.lbl_oral.TabIndex = 3;
            this.lbl_oral.Text = "Prova Oral";
            // 
            // lbl_fisica
            // 
            this.lbl_fisica.AutoSize = true;
            this.lbl_fisica.Location = new System.Drawing.Point(3, 177);
            this.lbl_fisica.Name = "lbl_fisica";
            this.lbl_fisica.Size = new System.Drawing.Size(103, 20);
            this.lbl_fisica.TabIndex = 4;
            this.lbl_fisica.Text = "Aptidão Física";
            this.lbl_fisica.Click += new System.EventHandler(this.label4_Click);
            // 
            // cb_escrita
            // 
            this.cb_escrita.FormattingEnabled = true;
            this.cb_escrita.Location = new System.Drawing.Point(136, 76);
            this.cb_escrita.Name = "cb_escrita";
            this.cb_escrita.Size = new System.Drawing.Size(103, 28);
            this.cb_escrita.TabIndex = 5;
            // 
            // cb_oral
            // 
            this.cb_oral.FormattingEnabled = true;
            this.cb_oral.Location = new System.Drawing.Point(136, 125);
            this.cb_oral.Name = "cb_oral";
            this.cb_oral.Size = new System.Drawing.Size(103, 28);
            this.cb_oral.TabIndex = 6;
            // 
            // cb_fisica
            // 
            this.cb_fisica.FormattingEnabled = true;
            this.cb_fisica.Location = new System.Drawing.Point(136, 177);
            this.cb_fisica.Name = "cb_fisica";
            this.cb_fisica.Size = new System.Drawing.Size(103, 28);
            this.cb_fisica.TabIndex = 7;
            // 
            // gb_linguas
            // 
            this.gb_linguas.Controls.Add(this.ckb_russo);
            this.gb_linguas.Controls.Add(this.ckb_portugues);
            this.gb_linguas.Controls.Add(this.ckb_frances);
            this.gb_linguas.Controls.Add(this.ckb_espanhol);
            this.gb_linguas.Controls.Add(this.ckb_alemao);
            this.gb_linguas.Controls.Add(this.ckb_ingles);
            this.gb_linguas.Location = new System.Drawing.Point(3, 239);
            this.gb_linguas.Name = "gb_linguas";
            this.gb_linguas.Size = new System.Drawing.Size(254, 188);
            this.gb_linguas.TabIndex = 8;
            this.gb_linguas.TabStop = false;
            this.gb_linguas.Text = "Conhecimento de Línguas";
            // 
            // ckb_russo
            // 
            this.ckb_russo.AutoSize = true;
            this.ckb_russo.Location = new System.Drawing.Point(133, 136);
            this.ckb_russo.Name = "ckb_russo";
            this.ckb_russo.Size = new System.Drawing.Size(69, 24);
            this.ckb_russo.TabIndex = 5;
            this.ckb_russo.Text = "Russo";
            this.ckb_russo.UseVisualStyleBackColor = true;
            // 
            // ckb_portugues
            // 
            this.ckb_portugues.AutoSize = true;
            this.ckb_portugues.Location = new System.Drawing.Point(135, 87);
            this.ckb_portugues.Name = "ckb_portugues";
            this.ckb_portugues.Size = new System.Drawing.Size(96, 24);
            this.ckb_portugues.TabIndex = 4;
            this.ckb_portugues.Text = "Português";
            this.ckb_portugues.UseVisualStyleBackColor = true;
            // 
            // ckb_frances
            // 
            this.ckb_frances.AutoSize = true;
            this.ckb_frances.Location = new System.Drawing.Point(135, 39);
            this.ckb_frances.Name = "ckb_frances";
            this.ckb_frances.Size = new System.Drawing.Size(80, 24);
            this.ckb_frances.TabIndex = 3;
            this.ckb_frances.Text = "Francês";
            this.ckb_frances.UseVisualStyleBackColor = true;
            // 
            // ckb_espanhol
            // 
            this.ckb_espanhol.AutoSize = true;
            this.ckb_espanhol.Location = new System.Drawing.Point(17, 136);
            this.ckb_espanhol.Name = "ckb_espanhol";
            this.ckb_espanhol.Size = new System.Drawing.Size(91, 24);
            this.ckb_espanhol.TabIndex = 2;
            this.ckb_espanhol.Text = "Espanhol";
            this.ckb_espanhol.UseVisualStyleBackColor = true;
            // 
            // ckb_alemao
            // 
            this.ckb_alemao.AutoSize = true;
            this.ckb_alemao.Location = new System.Drawing.Point(17, 87);
            this.ckb_alemao.Name = "ckb_alemao";
            this.ckb_alemao.Size = new System.Drawing.Size(83, 24);
            this.ckb_alemao.TabIndex = 1;
            this.ckb_alemao.Text = "Alemão";
            this.ckb_alemao.UseVisualStyleBackColor = true;
            // 
            // ckb_ingles
            // 
            this.ckb_ingles.AutoSize = true;
            this.ckb_ingles.Location = new System.Drawing.Point(17, 39);
            this.ckb_ingles.Name = "ckb_ingles";
            this.ckb_ingles.Size = new System.Drawing.Size(70, 24);
            this.ckb_ingles.TabIndex = 0;
            this.ckb_ingles.Text = "Inglês";
            this.ckb_ingles.UseVisualStyleBackColor = true;
            // 
            // btn_submeter
            // 
            this.btn_submeter.Location = new System.Drawing.Point(3, 433);
            this.btn_submeter.Name = "btn_submeter";
            this.btn_submeter.Size = new System.Drawing.Size(130, 41);
            this.btn_submeter.TabIndex = 9;
            this.btn_submeter.Text = "Submeter";
            this.btn_submeter.UseVisualStyleBackColor = true;
            this.btn_submeter.Click += new System.EventHandler(this.btn_submeter_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(139, 433);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(118, 40);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // dgv_registo
            // 
            this.dgv_registo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.escrita,
            this.oral,
            this.fisica,
            this.linguas,
            this.situacao});
            this.dgv_registo.Location = new System.Drawing.Point(263, 27);
            this.dgv_registo.Name = "dgv_registo";
            this.dgv_registo.RowHeadersVisible = false;
            this.dgv_registo.RowHeadersWidth = 51;
            this.dgv_registo.RowTemplate.Height = 29;
            this.dgv_registo.Size = new System.Drawing.Size(494, 457);
            this.dgv_registo.TabIndex = 11;
            // 
            // Nome
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 125;
            // 
            // escrita
            // 
            this.escrita.HeaderText = "Escrita";
            this.escrita.MinimumWidth = 6;
            this.escrita.Name = "escrita";
            this.escrita.Width = 60;
            // 
            // oral
            // 
            this.oral.HeaderText = "Oral";
            this.oral.MinimumWidth = 6;
            this.oral.Name = "oral";
            this.oral.Width = 60;
            // 
            // fisica
            // 
            this.fisica.HeaderText = "Apt. Física";
            this.fisica.MinimumWidth = 6;
            this.fisica.Name = "fisica";
            this.fisica.Width = 60;
            // 
            // linguas
            // 
            this.linguas.HeaderText = "Línguas";
            this.linguas.MinimumWidth = 6;
            this.linguas.Name = "linguas";
            this.linguas.Width = 60;
            // 
            // situacao
            // 
            this.situacao.HeaderText = "Situação";
            this.situacao.MinimumWidth = 6;
            this.situacao.Name = "situacao";
            this.situacao.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 496);
            this.Controls.Add(this.dgv_registo);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_submeter);
            this.Controls.Add(this.gb_linguas);
            this.Controls.Add(this.cb_fisica);
            this.Controls.Add(this.cb_oral);
            this.Controls.Add(this.cb_escrita);
            this.Controls.Add(this.lbl_fisica);
            this.Controls.Add(this.lbl_oral);
            this.Controls.Add(this.lbl_escrita);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_linguas.ResumeLayout(false);
            this.gb_linguas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lbl_escrita;
        private System.Windows.Forms.Label lbl_oral;
        private System.Windows.Forms.Label lbl_fisica;
        private System.Windows.Forms.ComboBox cb_escrita;
        private System.Windows.Forms.ComboBox cb_oral;
        private System.Windows.Forms.ComboBox cb_fisica;
        private System.Windows.Forms.GroupBox gb_linguas;
        private System.Windows.Forms.CheckBox ckb_russo;
        private System.Windows.Forms.CheckBox ckb_portugues;
        private System.Windows.Forms.CheckBox ckb_frances;
        private System.Windows.Forms.CheckBox ckb_espanhol;
        private System.Windows.Forms.CheckBox ckb_alemao;
        private System.Windows.Forms.CheckBox ckb_ingles;
        private System.Windows.Forms.Button btn_submeter;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.DataGridView dgv_registo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn escrita;
        private System.Windows.Forms.DataGridViewTextBoxColumn oral;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn linguas;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}

