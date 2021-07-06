
namespace Ficha3Ex5 {
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
            this.dgw_consulta = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_consulta
            // 
            this.dgw_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.port,
            this.mat,
            this.tic,
            this.media,
            this.situacao});
            this.dgw_consulta.Location = new System.Drawing.Point(3, 3);
            this.dgw_consulta.Name = "dgw_consulta";
            this.dgw_consulta.RowHeadersVisible = false;
            this.dgw_consulta.RowHeadersWidth = 51;
            this.dgw_consulta.RowTemplate.Height = 29;
            this.dgw_consulta.Size = new System.Drawing.Size(501, 188);
            this.dgw_consulta.TabIndex = 0;
            this.dgw_consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_consulta_CellContentClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // port
            // 
            this.port.HeaderText = "Port";
            this.port.MinimumWidth = 6;
            this.port.Name = "port";
            this.port.ReadOnly = true;
            this.port.Width = 60;
            // 
            // mat
            // 
            this.mat.HeaderText = "Mat";
            this.mat.MinimumWidth = 6;
            this.mat.Name = "mat";
            this.mat.ReadOnly = true;
            this.mat.Width = 60;
            // 
            // tic
            // 
            this.tic.HeaderText = "TIC";
            this.tic.MinimumWidth = 6;
            this.tic.Name = "tic";
            this.tic.ReadOnly = true;
            this.tic.Width = 60;
            // 
            // media
            // 
            this.media.HeaderText = "Média";
            this.media.MinimumWidth = 6;
            this.media.Name = "media";
            this.media.ReadOnly = true;
            this.media.Width = 90;
            // 
            // situacao
            // 
            this.situacao.HeaderText = "Situação";
            this.situacao.MinimumWidth = 6;
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 273);
            this.Controls.Add(this.dgw_consulta);
            this.Name = "Form1";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgw_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tic;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}

