using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoFinal {
    public partial class Login : Form {
        private DataTable dt = new DataTable();
        private Alterar alt = new Alterar();
        public Login() {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void tb_usuario_Enter(object sender, EventArgs e) {
            if (tb_usuario.Text == "USUÁRIO")
            {
                tb_usuario.Text = "";
                tb_usuario.ForeColor = Color.FromArgb(169, 188, 208);
            }
        }

        private void tb_usuario_Leave(object sender, EventArgs e) {
            if (tb_usuario.Text == "")
            {
                tb_usuario.Text = "USUÁRIO";

            }
        }

        private void textBox1_Enter(object sender, EventArgs e) {
            if (tb_pass.Text == "PASSWORD")
            {
                tb_pass.Text = "";
                tb_pass.ForeColor = Color.FromArgb(169, 188, 208);
                tb_pass.UseSystemPasswordChar = true;
            }
        }

        private void tb_pass_Leave(object sender, EventArgs e) {

            if (tb_pass.Text == "")
            {
                tb_pass.Text = "PASSWORD";
                tb_pass.UseSystemPasswordChar = false;


            }
        }

        private void btn_exit_Click(object sender, EventArgs e) {
            Form1 form1 = new Form1();
            Close();
            form1.lblTitleChildForm.Text = "Home";

        }

        private void Login_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void pb_logo_Click(object sender, EventArgs e) {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pb_logo_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_entrar_Click(object sender, EventArgs e) {
            string user = tb_usuario.Text;
            string pass = tb_pass.Text;


            string sqlUser = "select * from users where UserName = '" + user + "' and Password = '" + pass + "'";

            if (BaseDeDados.ExisteUser(sqlUser))
            {
                dt = BaseDeDados.Consulta(sqlUser);

                Sessao.logado = true;
                Sessao.Codigo = int.Parse(dt.Rows[0][3].ToString());

                Close();

            } else
            {
                MessageBox.Show("Credenciais Inválidas", "Autenticação Falhada");
            }


        }

        private void Login_Load(object sender, EventArgs e) {

        }
    }
}
