using BLL;
using DAL;
using Entity;
namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        PeliculaBusiness peliculaBusiness = new PeliculaBusiness();
        CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
        List<Pelicula> borrador = new List<Pelicula>();

        private void btnDarDeAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula miPelicula = new Pelicula
                {
                    Categoria = new Categoria { Id = Convert.ToInt32(cmbCategoria.SelectedValue) },
                    Titulo = txtTitulo.Text,
                    Descripcion = txtDescripcion.Text,
                    AnioLanzamiento = Convert.ToInt32(txtAnioLanzamiento.Text),
                    Duracion = Convert.ToDouble(txtDuracion.Text),
                    Calificaion = Convert.ToInt32(nudCalificacion.Text),
                    FechaAlta = dtpFechaAlta.Value
                };
                borrador.Add(miPelicula);
                MessageBox.Show("Pelicula guardada en borrador");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                CargarGrillaPeliculas();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrillaPeliculas();
            CargarCategorias();
        }

        public void CargarGrillaPeliculas()
        {
            try
            {
                dvgPeliculas.DataSource = null;
                dvgPeliculas.DataSource = peliculaBusiness.CargarListaPeliculas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void CargarCategorias()
        {
            try
            {
                cmbCategoria.DataSource = null;
                cmbCategoria.DataSource = categoriaBusiness.ObtenerListaCategorias();
                cmbCategoria.DisplayMember = "Descripcion";
                cmbCategoria.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                peliculaBusiness.Eliminar(Convert.ToInt32(txtIdEliminar.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                CargarGrillaPeliculas();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                peliculaBusiness.ModificarCalificacionPelicula(Convert.ToInt32(txtIdModificar.Text), Convert.ToInt32(nudNuevaCalificacion.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                CargarGrillaPeliculas();
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                peliculaBusiness.DarAltaPelicula(borrador);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CargarGrillaPeliculas();
            }
        }
    }
}
