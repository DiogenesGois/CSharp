using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal {
    class BaseDeDados {

        private static SqlConnection conn;
        

        private static SqlConnection LigarBase() {

            string connString = "server = (LocalDB)\\MSSQLLocalDB; Database = Carros; Integrated Security = true";
            conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        } 

        public static DataTable Consulta(string sqlConsulta) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = sqlConsulta;
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();
            return dt;
        }

        public static DataTable Consulta() {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "select mo.id as Número, mo.code as 'Código do Modelo', mo.title as Modelo, ma.code as 'Código da Marca', ma.title as Marca from make as ma inner join model as mo on mo.make_id = ma.id order by ma.title";
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();
            return dt;
        }

        public static bool ExisteCarro(string sqlCarro) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = sqlCarro;
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();
            
            if (dt.Rows.Count > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public static bool ExisteUser(string sqlUser) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = sqlUser;
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();

            if (dt.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static void AtualizarMarca(Carro car) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "update make set code = '" + car.CodigoMarca1 + "' ," +
                " title = '" + car.Marca1 + "' where id in (select make_id from model where id = " + car.Id + ")";
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();

            MessageBox.Show("Carro atualizado com sucesso", "Sucesso");
        }

        public static void AtualizarModelo(Carro car) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "update model set code = '" + car.CodigoModelo1 + "' ," +
                " title = '" + car.Modelo1 + "' where id = '" + car.Id + "'";
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();

            
        }

        public static DataTable ApagarCarroMarca(string idmodelo) {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "delete from make where id in (select make_id from model where id = " + idmodelo + ")";
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();

            return dt;
        }

        public static DataTable ApagarCarroModelo(string idmodelo) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "delete from model where id = " + idmodelo;
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();

            return dt;
        }


        public static DataTable CarroID(string id) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "select mo.make_id, mo.code, mo.title, ma.code, ma.title from model as mo inner join make as ma on ma.id = mo.make_id where mo.id = " + id;
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();
            return dt;

        }

        //confirmado ## Adiciona o carros na tabela marcas
        public static void NovoCarroMarca(Carro car) {

            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "insert into make (id, code, title) values (@id, @code, @title) ";
            cmd.Parameters.AddWithValue("@id", car.IdMarca);
            cmd.Parameters.AddWithValue("@code", car.CodigoMarca1);
            cmd.Parameters.AddWithValue("@title", car.Marca1);
            cmd.ExecuteNonQuery();
            LigarBase().Close();
        }

        //confirmado ## Adiciona o carro na tabela modelos
        public static void NovoCarroModelo(Carro car) {

            
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "insert into model (make_id, code, title) values (@make_id, @code, @title) ";
            cmd.Parameters.AddWithValue("@make_id", car.IdMarca);
            cmd.Parameters.AddWithValue("@code", car.CodigoModelo1);
            cmd.Parameters.AddWithValue("@title", car.Modelo1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Carro inserido com sucesso", "Sucesso");
            LigarBase().Close();

        }

        public static void NovoUser(Utilizadores u) {

            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "insert into users (Nome, UserName, Codigo, Password) values (@Nome, @UserName, @Codigo, @Password)";
            cmd.Parameters.AddWithValue("@Nome", u.Nome);
            cmd.Parameters.AddWithValue("@UserName", u.UserName);
            cmd.Parameters.AddWithValue("@Codigo", u.Codigo);
            cmd.Parameters.AddWithValue("@Password", u.Password);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuário inserido com sucesso", "Sucesso");
            LigarBase().Close();
        }
    }
}
