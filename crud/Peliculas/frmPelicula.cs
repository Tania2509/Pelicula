using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Modelo;

namespace Peliculas
{
    public partial class frmPelicula : Form
    {
        public frmPelicula()
        {
            InitializeComponent();
        }


        private void frmPelicula_Load(object sender, EventArgs e)
        {
            MostrarPeliculas();
        }

        private void MostrarPeliculas()
        {
            dgvPeliculas.DataSource = null;
            dgvPeliculas.DataSource = Modelo.Peliculas.CargarPeliculas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDirector.Text))
            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            Modelo.Peliculas p = new Modelo.Peliculas();
            p.Nombre = txtNombre.Text;
            p.Director = txtDirector.Text;
            p.FechaLanzamiento = dtpFecha.Value;
            p.InsetarPeliculas();
            MostrarPeliculas();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {          
            int id = int.Parse(dgvPeliculas.CurrentRow.Cells[0].Value.ToString());
            Modelo.Peliculas P = new Modelo.Peliculas();
            if (P.EliminarPeliculas(id) == true)
            {
                MessageBox.Show("Película eliminada correctamente.", "Éxito");
                MostrarPeliculas();
            }
            else
            {
                               MessageBox.Show("Error al eliminar la película.", "Error");
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDirector.Text))
            {
                MessageBox.Show("No dejes campos vacios", "Campos obligatorios");
                return;
            }

            Modelo.Peliculas p = new Modelo.Peliculas();
            p.Nombre = txtNombre.Text;
            p.Director = txtDirector.Text;
            p.FechaLanzamiento = dtpFecha.Value;
            p.Id = Convert.ToInt32(dgvPeliculas.CurrentRow.Cells[0].Value);
            if (p.ActualizarPeliculas() == true)
            {
                MostrarPeliculas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar la película.", "Error");
            }
        }

        private void dgvPeliculas_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = dgvPeliculas.CurrentRow.Cells[1].Value.ToString();
            txtDirector.Text = dgvPeliculas.CurrentRow.Cells[2].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(dgvPeliculas.CurrentRow.Cells[3].Value);

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDirector.Text = "";
            dtpFecha.Value = DateTime.Now;
        }

       
    }
}
