using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon {
    class BasedeDados {

        private static SqlConnection conn;


        // Conexão bd

        public static SqlConnection LigarBase() {

            string connString = "server = (LocalDB)\\MSSQLLocalDB; Database = Pokemon; Integrated Security = true";
            conn = new SqlConnection(connString);
            conn.Open();
            return conn;

        }

        //consulta à bd pokemon individual

        public static DataTable LerPokemon(string sql) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            using (var cmd = LigarBase().CreateCommand())
            {
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, LigarBase());
                da.Fill(dt);
                LigarBase().Close();
                return dt;
            }
        }

        //confirma se pokemon existe

        public static bool ExistePoke (string nome) {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "select * from pokemon where nombre = '" + nome + "'";
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

        //consulta bd

        public static DataTable Consulta() {

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = LigarBase().CreateCommand();
            cmd.CommandText = "select p.*, t.nombre as tipo from pokemon as p inner join pokemon_tipo as pt on p.numero_pokedex = pt.numero_pokedex inner join tipo as t on t.id_tipo = pt.id_tipo";
            da = new SqlDataAdapter(cmd.CommandText, LigarBase());
            da.Fill(dt);
            LigarBase().Close();
            return dt;
        }
    }
}
