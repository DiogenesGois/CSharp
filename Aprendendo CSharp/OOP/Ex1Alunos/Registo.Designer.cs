
namespace Ex1Alunos {
    partial class Registo {
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
            this.dgv_registo = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_registo
            // 
            this.dgv_registo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.matricula,
            this.nota1,
            this.nota2,
            this.trabalho,
            this.media,
            this.final});
            this.dgv_registo.Location = new System.Drawing.Point(12, 12);
            this.dgv_registo.Name = "dgv_registo";
            this.dgv_registo.RowHeadersVisible = false;
            this.dgv_registo.RowHeadersWidth = 51;
            this.dgv_registo.RowTemplate.Height = 29;
            this.dgv_registo.Size = new System.Drawing.Size(696, 214);
            this.dgv_registo.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 125;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula";
            this.matricula.MinimumWidth = 6;
            this.matricula.Name = "matricula";
            this.matricula.Width = 125;
            // 
            // nota1
            // 
            this.nota1.HeaderText = "Nota 1";
            this.nota1.MinimumWidth = 6;
            this.nota1.Name = "nota1";
            this.nota1.Width = 88;
            // 
            // nota2
            // 
            this.nota2.HeaderText = "Nota 2";
            this.nota2.MinimumWidth = 6;
            this.nota2.Name = "nota2";
            this.nota2.Width = 88;
            // 
            // trabalho
            // 
            this.trabalho.HeaderText = "Trabalho";
            this.trabalho.MinimumWidth = 6;
            this.trabalho.Name = "trabalho";
            this.trabalho.Width = 88;
            // 
            // media
            // 
            this.media.HeaderText = "Média";
            this.media.MinimumWidth = 6;
            this.media.Name = "media";
            this.media.Width = 88;
            // 
            // final
            // 
            this.final.HeaderText = "Final";
            this.final.MinimumWidth = 6;
            this.final.Name = "final";
            this.final.Width = 88;
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 228);
            this.Controls.Add(this.dgv_registo);
            this.Name = "Registo";
            this.Text = "Registo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabalho;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.DataGridViewTextBoxColumn final;
        public System.Windows.Forms.DataGridView dgv_registo;
    }
}