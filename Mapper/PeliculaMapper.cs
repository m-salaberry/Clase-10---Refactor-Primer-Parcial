using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;


namespace Mapper
{
    public class PeliculaMapper
    {

        public static List<Pelicula> Map(DataSet dataset)
        {
            try
            {
                List<Pelicula> listaPeliculas = new List<Pelicula>();
                foreach(DataRow fila in dataset.Tables[0].Rows)
                {
                    Pelicula p = new Pelicula
                    {
                        Id = Convert.ToInt32(fila["ID_PELICULA"]),
                        Titulo = fila["TITULO"].ToString(),
                        Descripcion = fila["DESCRIPCION"].ToString(),
                        AnioLanzamiento = Convert.ToInt32(fila["ANIO_LANZAMIENTO"]),
                        Duracion = Convert.ToDouble(fila["DURACION"]),
                        Calificaion = Convert.ToInt32(fila["CALIFICACION"]),
                        FechaAlta = Convert.ToDateTime(fila["FECHA_ALTA"]),
                        Categoria = new Categoria
                        {
                            Id = Convert.ToInt32(fila["ID_CATEGORIA"])
                        }
                    };
                    listaPeliculas.Add(p);
                }
                return listaPeliculas;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
