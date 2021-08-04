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
    public partial class Marcas : Form {
        public Marcas() {
            InitializeComponent();
            this.dgv_marcas.ScrollBars = ScrollBars.None;
            this.dgv_marcas.MouseWheel += new MouseEventHandler(mousewheel);
        }

        private void mousewheel(object sender, MouseEventArgs e) {
            if (e.Delta > 0 && dgv_marcas.FirstDisplayedScrollingRowIndex > 0)
            {
                dgv_marcas.FirstDisplayedScrollingRowIndex--;
            } else if (e.Delta < 0)
            {
                dgv_marcas.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void Marcas_Load(object sender, EventArgs e) {
            DataTable dt = new DataTable();            
            string sql = "select id ,code ,title from make";
            dt = BaseDeDados.Consulta(sql);

            //dgv_marcas.DataSource = BaseDeDados.Consulta(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_marcas.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);

            }

            //dgv_marcas.Columns[0].Width = 200;
            //dgv_marcas.Columns[1].Width = 200;
            //dgv_marcas.Columns[2].Width = 200;
            dgv_marcas.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 27, 30);
            dgv_marcas.ForeColor = Color.FromArgb(169, 188, 208);

            
        }
    }
}
