using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoFinal {
    public partial class Form1 : Form {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1() {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pn_sideMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void Form1_Load(object sender, EventArgs e) {
            FormBorderStyle = FormBorderStyle.None;


        }

        private struct RGBColors {
            public static Color color1 = Color.FromArgb(203, 232, 150);
            public static Color color2 = Color.FromArgb(55, 63, 81);
            public static Color color3 = Color.FromArgb(233, 210, 244);
            public static Color color4 = Color.FromArgb(202, 60, 37);
            public static Color color5 = Color.FromArgb(243, 193, 120);
            public static Color color6 = Color.FromArgb(161, 94, 73);
            public static Color color7 = Color.FromArgb(246, 45, 174);
        }

        private void AtivarBotao(object senderBtn, Color color) {

            if (senderBtn != null)
            {
                DesativarBotao();
                //botão
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(159, 164, 169);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //lista esquerda botão
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }

        private void DesativarBotao() {

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(55, 63, 81);
                currentBtn.ForeColor = Color.FromArgb(169, 188, 208);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(169, 188, 208);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        public void OpenChildForm(Form childForm) {
            //abrir form filho
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //fim
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btn_procurar_Click(object sender, EventArgs e) {

            AtivarBotao(sender, RGBColors.color4);
            OpenChildForm(new Procurar());
        }

        private void btn_marcas_Click(object sender, EventArgs e) {

            AtivarBotao(sender, RGBColors.color4);
            OpenChildForm(new Marcas());
        }

        private void btn_modelo_Click(object sender, EventArgs e) {

            AtivarBotao(sender, RGBColors.color4);
            OpenChildForm(new Modelos());
        }

        private void btn_registo_Click(object sender, EventArgs e) {

            AtivarBotao(sender, RGBColors.color4);
            OpenChildForm(new Registar());
            if (Sessao.logado == false)
            {
                Login login = new Login();
                login.ShowDialog();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e) {

            AtivarBotao(sender, RGBColors.color4);
            OpenChildForm(new Alterar());

            if (Sessao.logado == false)
            {
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void btn_ajuda_Click(object sender, EventArgs e) {

            AtivarBotao(sender, RGBColors.color4);
            OpenChildForm(new Ajuda());
        }


        private void btnHome_Click(object sender, EventArgs e) {

            currentChildForm.Close();
            lblTitleChildForm.Text = "Home";
            Reset();


        }

        private void Reset() {
            DesativarBotao();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(202, 60, 37); ;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {

            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e) {

            WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void iconButton2_Click(object sender, EventArgs e) {

            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void horadata_Tick(object sender, EventArgs e) {

            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_data.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void btn_entrar_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_registarse_Click(object sender, EventArgs e) {
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }
    }
}
