using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDAO
    {

        public List<Categoria> GetCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORIA", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Categoria c = new Categoria
                        {
                            Id = Convert.ToInt32(reader["ID_CATEGORIA"]),
                            Descripcion = reader["DESCRIPCION"].ToString()
                        };
                        listaCategorias.Add(c);
                    }
                }
            }
            return listaCategorias;
        }

    }
}
