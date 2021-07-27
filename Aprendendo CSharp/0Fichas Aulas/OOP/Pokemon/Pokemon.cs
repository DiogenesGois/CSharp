using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon {
    public partial class Pokemon : Form {
        Consulta con = new Consulta();

        public Pokemon() {
            InitializeComponent();

        }

        private void Pokemon_Load(object sender, EventArgs e) {

        }

        private void btn_consultar_Click(object sender, EventArgs e) {
            

            con.dgv_bd.DataSource = BasedeDados.Consulta();
          

            con.ShowDialog();
        }

        private void btn_novo_Click(object sender, EventArgs e) {

            Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }
    }
}
