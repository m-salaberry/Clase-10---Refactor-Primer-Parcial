using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pelicula
    {

        private int id;
        private string titulo;
        private string descripcion;
        private int anioLanzamiento;
        private double duracion;
        private int calificaion;
        private DateTime fechaAlta;
        private Categoria categoria;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int AnioLanzamiento { get => anioLanzamiento; set => anioLanzamiento = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public int Calificaion { get => calificaion; set => calificaion = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }

        public Pelicula()
        {
        }
    }
}
