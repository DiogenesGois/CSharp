using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            for (int i = 1; i < 10; i++)
            {
                cb_numero.Items.Add(i);
            }
        }

        private void cb_numero_SelectedIndexChanged(object sender, EventArgs e) {

            lstb_tabuada.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lstb_tabuada.Items.Add($"{cb_numero.SelectedItem} x {i} = {(int.Parse(cb_numero.SelectedItem.ToString()) * i)}") ;
            }
        }
    }
}
