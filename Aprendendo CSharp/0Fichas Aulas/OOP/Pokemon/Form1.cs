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
    public partial class Form1 : Form {
        Pokemon poke = new Pokemon();
        public Form1() {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e) {
            
            string nomePoke = tb_nome.Text;
            bool existe = BasedeDados.ExistePoke(nomePoke);

            if (existe)
            {
                
                string sql = "select p.*, t.nombre as tipo from pokemon as p inner join pokemon_tipo as pt on p.numero_pokedex = pt.numero_pokedex inner join tipo as t on t.id_tipo = pt.id_tipo where p.nombre = '" + nomePoke + "'";

                DataTable dt = new DataTable();
                dt = BasedeDados.LerPokemon(sql);

                poke.tb_numero.Text = dt.Rows[0].ItemArray[0].ToString();
                poke.tb_nome.Text = dt.Rows[0].Field<string>("nombre");
                poke.tb_tipo.Text = dt.Rows[0].Field<string>("tipo");
                poke.tb_altura.Text = dt.Rows[0].ItemArray[3].ToString() + " m";
                poke.tb_peso.Text = dt.Rows[0].ItemArray[2].ToString() + " kg";

                poke.ShowDialog();
                Close();


            } else
            {
                MessageBox.Show("Pokemon não existe");
            }

            
        }
    }
}
