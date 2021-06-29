using System;

namespace Ex2 {
    public partial class calculadora : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_calcular_Click(object sender, EventArgs e) {

            int operador1 = int.Parse(tb_operador1.Text);
            int operador2 = int.Parse(tb_operador2.Text);

            if (operador2 <= 0 && ddl_operacao.SelectedItem.ToString() == "Divisão")
            {
                lbl_resultado.Text = "Operação impossível";
            } else
            {
                if (ddl_operacao.SelectedItem.ToString() == "Soma")
                {
                    lbl_resultado.Text = $"Resultado: {operador1 + operador2}";

                } else if (ddl_operacao.SelectedItem.ToString() == "Subtração")
                {
                    lbl_resultado.Text = $"Resultado: {operador1 - operador2}";

                } else if (ddl_operacao.SelectedItem.ToString() == "Multiplicação")
                {
                    lbl_resultado.Text = $"Resultado: {operador1 * operador2}";

                } else if (ddl_operacao.SelectedItem.ToString() == "Divisão")
                {
                    lbl_resultado.Text = $"Resultado: {operador1 / operador2}";

                }
            }

            lbl_resultado.Visible = true;
        }

        protected void btn_limpar_Click(object sender, EventArgs e) {

            tb_operador1.Text = "";
            tb_operador2.Text = "";

            
            lbl_resultado.Visible = false;
        }
    }
}