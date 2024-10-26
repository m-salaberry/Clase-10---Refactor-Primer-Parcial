using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class PeliculaBusiness
    {
		PeliculaDAO peliculaDAO = new PeliculaDAO();

		public void VerificarPelicula(Pelicula nuevaPelicula)
		{
			try
			{
				using(var trx = new TransactionScope())
				{
                    if (String.IsNullOrEmpty(nuevaPelicula.Titulo))
                    {
                        throw new Exception("El titulo no puede estar vacio");
                    }
                    if (nuevaPelicula.Titulo.Length < 5)
                    {
                        throw new Exception("El titulo debe tener al menos 5 caracteres");
                    }
                    if (String.IsNullOrEmpty(nuevaPelicula.Descripcion))
                    {
                        throw new Exception("La descripcion no puede estar vacia");
                    }
                    if (nuevaPelicula.AnioLanzamiento < 1970)
                    {
                        throw new Exception("El año de lanzamiento no puede ser menor a 1970");
                    }
                    if (nuevaPelicula.AnioLanzamiento > DateTime.Now.Year)
                    {
                        throw new Exception("El año de lanzamiento no puede ser mayor al año actual");
                    }
                    if (nuevaPelicula.Duracion < 1 || nuevaPelicula.Duracion > 4)
                    {
                        throw new Exception("La duracion debe ser entre 1 a 4 horas");
                    }
                    if (nuevaPelicula.Calificaion < 0 || nuevaPelicula.Calificaion > 5)
                    {
                        throw new Exception("La calificacion debe ser entre 0 y 5");
                    }
                    if (nuevaPelicula.FechaAlta < DateTime.Now)
                    {
                        throw new Exception("La fecha de alta no puede ser menor a la fecha actual");
                    }
                    peliculaDAO.InsertarPelicula(nuevaPelicula);
                    trx.Complete();
                }
			}
			catch (Exception)
			{

				throw;
			}
		}
        public void DarAltaPelicula(List<Pelicula> listaPelicula)
        {
			try
			{
                using(var trx = new TransactionScope())
                {
                    foreach (Pelicula item in listaPelicula)
                    {
                        VerificarPelicula(item);
                    }
                    trx.Complete();
                }
			}
			catch (Exception)
			{

				throw;
			}
        }

		public List<Pelicula> CargarListaPeliculas()
		{
			try
			{
				return peliculaDAO.GetPeliculas();
			}
			catch (Exception)
			{

				throw;
			}
		}


		public void Eliminar(int id)
		{
			try
			{
				if(peliculaDAO.VerificarPelicula(id) == false)
				{
					throw new Exception("La pelicula con ese ID no existe");
				}
				peliculaDAO.EliminarPelicula(id);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void ModificarCalificacionPelicula(int id, int nCalificacion)
		{
            try
            {
                if (peliculaDAO.VerificarPelicula(id) == false)
                {
                    throw new Exception("La pelicula con ese ID no existe");
                }
                peliculaDAO.ModificarCalificacion(id, nCalificacion);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
