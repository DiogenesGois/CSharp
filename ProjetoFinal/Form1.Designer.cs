
namespace ProjetoFinal {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pn_sideMenu = new System.Windows.Forms.Panel();
            this.btn_alterar = new FontAwesome.Sharp.IconButton();
            this.btn_registo = new FontAwesome.Sharp.IconButton();
            this.btn_ajuda = new FontAwesome.Sharp.IconButton();
            this.btn_modelo = new FontAwesome.Sharp.IconButton();
            this.btn_marcas = new FontAwesome.Sharp.IconButton();
            this.btn_procurar = new FontAwesome.Sharp.IconButton();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_registarse = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horadata = new System.Windows.Forms.Timer(this.components);
            this.pn_sideMenu.SuspendLayout();
            this.pn_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_sideMenu
            // 
            this.pn_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.pn_sideMenu.Controls.Add(this.btn_alterar);
            this.pn_sideMenu.Controls.Add(this.btn_registo);
            this.pn_sideMenu.Controls.Add(this.btn_ajuda);
            this.pn_sideMenu.Controls.Add(this.btn_modelo);
            this.pn_sideMenu.Controls.Add(this.btn_marcas);
            this.pn_sideMenu.Controls.Add(this.btn_procurar);
            this.pn_sideMenu.Controls.Add(this.pn_logo);
            this.pn_sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_sideMenu.Location = new System.Drawing.Point(0, 0);
            this.pn_sideMenu.Name = "pn_sideMenu";
            this.pn_sideMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pn_sideMenu.Size = new System.Drawing.Size(213, 594);
            this.pn_sideMenu.TabIndex = 0;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_alterar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_alterar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_alterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(10, 380);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_alterar.Size = new System.Drawing.Size(183, 60);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_registo
            // 
            this.btn_registo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_registo.FlatAppearance.BorderSize = 0;
            this.btn_registo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_registo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btn_registo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_registo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_registo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registo.Location = new System.Drawing.Point(10, 320);
            this.btn_registo.Name = "btn_registo";
            this.btn_registo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_registo.Size = new System.Drawing.Size(183, 60);
            this.btn_registo.TabIndex = 6;
            this.btn_registo.Text = "Registar";
            this.btn_registo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registo.UseVisualStyleBackColor = true;
            this.btn_registo.Click += new System.EventHandler(this.btn_registo_Click);
            // 
            // btn_ajuda
            // 
            this.btn_ajuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ajuda.FlatAppearance.BorderSize = 0;
            this.btn_ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_ajuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btn_ajuda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_ajuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ajuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajuda.Location = new System.Drawing.Point(10, 534);
            this.btn_ajuda.Name = "btn_ajuda";
            this.btn_ajuda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_ajuda.Size = new System.Drawing.Size(183, 60);
            this.btn_ajuda.TabIndex = 5;
            this.btn_ajuda.Text = "Ajuda";
            this.btn_ajuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ajuda.UseVisualStyleBackColor = true;
            this.btn_ajuda.Click += new System.EventHandler(this.btn_ajuda_Click);
            // 
            // btn_modelo
            // 
            this.btn_modelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_modelo.FlatAppearance.BorderSize = 0;
            this.btn_modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_modelo.IconChar = FontAwesome.Sharp.IconChar.Monero;
            this.btn_modelo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_modelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_modelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modelo.Location = new System.Drawing.Point(10, 260);
            this.btn_modelo.Name = "btn_modelo";
            this.btn_modelo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_modelo.Size = new System.Drawing.Size(183, 60);
            this.btn_modelo.TabIndex = 3;
            this.btn_modelo.Text = "Modelos";
            this.btn_modelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modelo.UseVisualStyleBackColor = true;
            this.btn_modelo.Click += new System.EventHandler(this.btn_modelo_Click);
            // 
            // btn_marcas
            // 
            this.btn_marcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_marcas.FlatAppearance.BorderSize = 0;
            this.btn_marcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_marcas.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.btn_marcas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_marcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_marcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_marcas.Location = new System.Drawing.Point(10, 200);
            this.btn_marcas.Name = "btn_marcas";
            this.btn_marcas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_marcas.Size = new System.Drawing.Size(183, 60);
            this.btn_marcas.TabIndex = 2;
            this.btn_marcas.Text = "Marcas";
            this.btn_marcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_marcas.UseVisualStyleBackColor = true;
            this.btn_marcas.Click += new System.EventHandler(this.btn_marcas_Click);
            // 
            // btn_procurar
            // 
            this.btn_procurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_procurar.FlatAppearance.BorderSize = 0;
            this.btn_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_procurar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_procurar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_procurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_procurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procurar.Location = new System.Drawing.Point(10, 140);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_procurar.Size = new System.Drawing.Size(183, 60);
            this.btn_procurar.TabIndex = 1;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // pn_logo
            // 
            this.pn_logo.Controls.Add(this.btnHome);
            this.pn_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_logo.Location = new System.Drawing.Point(10, 0);
            this.pn_logo.Name = "pn_logo";
            this.pn_logo.Size = new System.Drawing.Size(183, 140);
            this.pn_logo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(190, 140);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.panelTitleBar.Controls.Add(this.btn_registarse);
            this.panelTitleBar.Controls.Add(this.btn_entrar);
            this.panelTitleBar.Controls.Add(this.iconButton2);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(213, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(733, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_registarse
            // 
            this.btn_registarse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registarse.FlatAppearance.BorderSize = 0;
            this.btn_registarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.btn_registarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.btn_registarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registarse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_registarse.Location = new System.Drawing.Point(528, 34);
            this.btn_registarse.Name = "btn_registarse";
            this.btn_registarse.Size = new System.Drawing.Size(95, 40);
            this.btn_registarse.TabIndex = 6;
            this.btn_registarse.Text = "Registar-se";
            this.btn_registarse.UseVisualStyleBackColor = true;
            this.btn_registarse.Click += new System.EventHandler(this.btn_registarse_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.btn_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.btn_entrar.Location = new System.Drawing.Point(629, 34);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 40);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(663, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(37, 30);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(629, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "---";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(697, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(87, 34);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(50, 19);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(28, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelShadow.Location = new System.Drawing.Point(213, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(733, 3);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.panelDesktop.Controls.Add(this.lbl_data);
            this.panelDesktop.Controls.Add(this.lbl_hora);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(213, 83);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(733, 511);
            this.panelDesktop.TabIndex = 3;
            // 
            // lbl_data
            // 
            this.lbl_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.lbl_data.Location = new System.Drawing.Point(263, 348);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(58, 29);
            this.lbl_data.TabIndex = 3;
            this.lbl_data.Text = "data";
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(60)))), ((int)(((byte)(37)))));
            this.lbl_hora.Location = new System.Drawing.Point(250, 294);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(104, 53);
            this.lbl_hora.TabIndex = 2;
            this.lbl_hora.Text = "hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // horadata
            // 
            this.horadata.Enabled = true;
            this.horadata.Tick += new System.EventHandler(this.horadata_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 594);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.pn_sideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn_sideMenu.ResumeLayout(false);
            this.pn_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_sideMenu;
        private FontAwesome.Sharp.IconButton btn_procurar;
        private System.Windows.Forms.Panel pn_logo;
        private FontAwesome.Sharp.IconButton btn_ajuda;
        private FontAwesome.Sharp.IconButton btn_modelo;
        private FontAwesome.Sharp.IconButton btn_marcas;
        private FontAwesome.Sharp.IconButton btn_registo;
        private FontAwesome.Sharp.IconButton btn_alterar;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Timer horadata;
        public System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_registarse;
    }
}

