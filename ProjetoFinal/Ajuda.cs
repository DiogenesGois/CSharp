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
    public partial class Ajuda : Form {
        public Ajuda() {
            InitializeComponent();
        }

        private void Ajuda_Load(object sender, EventArgs e) {

            lbl_ajuda.Text = "Esta é uma base de dados de marcas e modelos de Carros," +
                " aqui poderá encontrar,\ninserir e modificar todos os modelos de carros existentes." +
                " Os menus são\nauto-explicatórios, porém, para mais ajuda, deixamos esta explicação:";
                

            lbl_menus.Text = "Procurar - No menu \"Procurar\" poderá fazer uma pesquisa personalizada por carros.\n\n\n" +
                "Marcas - No menu \"Marcas\" encontrará todas as marcas de carros disponíveis na nossa base de dados.\n\n\n" +
                "Modelos - No menu \"Modelos\" encontrará todas os modelos de carros disponíveis na nossa\nbase de dados.\n\n\n" +
                "Registar - No menu \"Registar\" poderá registar novas marcas e modelosde carros na nossa\nbase de dados. A sequência correta de registo na base de dados pode ser encontrada no menu \n Marcas ou no menu Procurar \n\n\n" +
                "Alterar - No menu \"Alterar\" poderá alterar ou apagar registos da nossa base de dados,\naconselhamos a usar este menu com precaução.";
        }

        private void lbl_ajuda_Click(object sender, EventArgs e) {

        }
    }
}
