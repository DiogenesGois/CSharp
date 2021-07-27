using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal {
    public partial class SignUp : Form {
        Utilizadores u = new Utilizadores();
        public SignUp() {
            InitializeComponent();
            

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        private void SignUp_Load(object sender, EventArgs e) {

        }

        private void btn_cancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void tb_nome_Enter(object sender, EventArgs e) {
            if (tb_nome.Text == "NOME")
            {
                tb_nome.Text = "";
            }
        }

        private void tb_nome_Leave(object sender, EventArgs e) {
            if (tb_nome.Text == "")
            {
                tb_nome.Text = "NOME";
            }
        }

        private void tb_usuario_Enter(object sender, EventArgs e) {
            if (tb_usuario.Text == "USUÁRIO")
            {
                tb_usuario.Text = "";
            }
        }

        private void tb_usuario_Leave(object sender, EventArgs e) {
            if (tb_usuario.Text == "")
            {
                tb_usuario.Text = "USUÁRIO";
            }
        }

        private void tb_pass_Enter(object sender, EventArgs e) {
            if (tb_pass.Text == "PASSWORD")
            {
                tb_pass.Text = "";
            }
        }

        private void tb_pass_Leave(object sender, EventArgs e) {
            if (tb_pass.Text == "")
            {
                tb_pass.Text = "PASSWORD";
            }
        }

        private void tb_usuario_Enter_1(object sender, EventArgs e) {
            if (tb_usuario.Text == "USUÁRIO")
            {
                tb_usuario.Text = "";
            }
        }

        private void tb_usuario_Leave_1(object sender, EventArgs e) {
            if (tb_usuario.Text == "")
            {
                tb_usuario.Text = "USUÁRIO";
            }
        }

        private void btn_registar_Click(object sender, EventArgs e) {
            string validacao = "";

            u.Nome = tb_nome.Text;
            u.UserName = tb_usuario.Text;
            u.Password = tb_pass.Text;

            if (rb_sim.Checked == true)
            {
                validacao = "sim";
            } else if (rb_nao.Checked)
            {
                validacao = "nao";
            } else
            {
                MessageBox.Show("Indique o seu estatuto", "Atenção");
            }

            if (validacao == "sim")
            {
                u.Codigo = 2;
            } else
            {
                u.Codigo = 1;
            }

            BaseDeDados.NovoUser(u);

           

            Close();
        }

        private void tb_nome_TextChanged(object sender, EventArgs e) {

        }

        private void SignUp_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
