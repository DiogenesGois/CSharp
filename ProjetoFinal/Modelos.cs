using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal {
    public partial class Modelos : Form {

        public Modelos() {
            InitializeComponent();
            this.dgv_modelo.ScrollBars = ScrollBars.None;
            this.dgv_modelo.MouseWheel += new MouseEventHandler(mousewheel);
        }

        private void mousewheel(object sender, MouseEventArgs e) {
            if (e.Delta > 0 && dgv_modelo.FirstDisplayedScrollingRowIndex > 0)
            {
                dgv_modelo.FirstDisplayedScrollingRowIndex--;
            } else if (e.Delta < 0)
            {
                dgv_modelo.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void Modelos_Load(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            string sql = "select id as Número, make_id as 'ID da Marca', code as Código, title as Modelo from model";
            dt = BaseDeDados.Consulta(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_modelo.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
            }

            //dgv_modelo.DataSource = BaseDeDados.Consulta(sql);
            //dgv_modelo.Columns[0].Width = 100;
            //dgv_modelo.Columns[1].Width = 100;
            //dgv_modelo.Columns[2].Width = 200;
            //dgv_modelo.Columns[3].Width = 200;
            dgv_modelo.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 27, 30);
            dgv_modelo.ForeColor = Color.FromArgb(169, 188, 208);

            
        }

        private void dgv_modelo_Scroll(object sender, ScrollEventArgs e) {
           

        }
    }
}
