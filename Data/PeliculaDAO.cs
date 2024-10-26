using Entity;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Mapper;

namespace DAL
{
    public class PeliculaDAO
    {


        public void InsertarPelicula(Pelicula nuevaPelicula)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO PELICULA (ID_CATEGORIA,TITULO,DESCRIPCION,ANIO_LANZAMIENTO,DURACION,CALIFICACION,FECHA_ALTA) VALUES (@idCat,@titulo,@descripcion,@anioLanzamiento,@duracion,@calificacion,@fechaAlta)", connection))
                    {

                        connection.Open();
                        cmd.Parameters.AddWithValue("@idCat", nuevaPelicula.Categoria.Id);
                        cmd.Parameters.AddWithValue("@titulo", nuevaPelicula.Titulo);
                        cmd.Parameters.AddWithValue("@descripcion", nuevaPelicula.Descripcion);
                        cmd.Parameters.AddWithValue("@anioLanzamiento", nuevaPelicula.AnioLanzamiento);
                        cmd.Parameters.AddWithValue("@duracion", nuevaPelicula.Duracion);
                        cmd.Parameters.AddWithValue("@calificacion", nuevaPelicula.Calificaion);
                        cmd.Parameters.AddWithValue("@fechaAlta", nuevaPelicula.FechaAlta);
                        cmd.ExecuteNonQuery();
                        
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public List<Pelicula> GetPeliculas()
        {
            try
            {
                List<Pelicula> listaPeliculas = new List<Pelicula>();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT* FROM PELICULA", connection))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        listaPeliculas = PeliculaMapper.Map(dataSet);
                        return listaPeliculas;
                    }
                }
                return listaPeliculas;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void EliminarPelicula(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM PELICULA WHERE ID_PELICULA = @idPelicula", connection))
                    {

                        connection.Open();
                        cmd.Parameters.AddWithValue("@idPelicula", id);
                        cmd.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public bool VerificarPelicula(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM PELICULA WHERE ID_PELICULA = @idPelicula", connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@idPelicula", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public void ModificarCalificacion(int id, int nCalificacion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE PELICULA SET CALIFICACION = @calificacion WHERE ID_PELICULA = @id", connection))
                    {

                        connection.Open();
                        cmd.Parameters.AddWithValue("@calificacion", nCalificacion);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
