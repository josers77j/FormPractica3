using BussinesLayer.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPractica8.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cargarDatosEstudiante();
        }

        private void cargarDatosEstudiante()
        {
            EstudianteBussines estudianteBussines = new EstudianteBussines();
            estudianteGridView.DataSource = estudianteBussines.getEstudiante();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            EstudianteBussines estudianteBussines = new EstudianteBussines();

            try
            {
                if (validarParametros())
                {
                    string nombreEstudiante = nombreTextBox.Text;
                    string apellidoEstudiante = apellidoTextBox.Text;
                    string telefonoEstudiante = telefonoTextBox.Text;
                    string ciudadEstudiante = ciudadTextBox.Text;
                    estudianteBussines.addEstudiante(nombreEstudiante, apellidoEstudiante, telefonoEstudiante, ciudadEstudiante);
                    cargarDatosEstudiante();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Es necesario llenar todo el formulario.");
                    return;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void ClearForm()
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            telefonoTextBox.Clear();
            ciudadTextBox.Clear();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (validarFilaSeleccionada())
            {
               int codigoEstudiante = int.Parse(estudianteGridView.CurrentRow.Cells[0].Value.ToString());
                EstudianteBussines estudianteBussines = new EstudianteBussines();
                estudianteBussines.deleteEstudiante(codigoEstudiante);
                cargarDatosEstudiante();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para eliminar un parametro");
            }

        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (validarFilaSeleccionada() && validarParametros())
            {
              
                    int codigoEstudiante = int.Parse(estudianteGridView.CurrentRow.Cells[0].Value.ToString());
                    string nombreEstudiante = nombreTextBox.Text;
                    string apellidoEstudiante = apellidoTextBox.Text;
                    string telefonoEstudiante = telefonoTextBox.Text;
                    string ciudadEstudiante = ciudadTextBox.Text;

                    EstudianteBussines estudianteBussines = new EstudianteBussines();
                    estudianteBussines.updateEstudiante(codigoEstudiante, nombreEstudiante, apellidoEstudiante, telefonoEstudiante, ciudadEstudiante);
                    cargarDatosEstudiante();
                    ClearForm();
                
                
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para eliminar un parametro");
            }
        }

        public bool validarParametros()
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text) ||
               string.IsNullOrEmpty(apellidoTextBox.Text) ||
               string.IsNullOrEmpty(telefonoTextBox.Text) ||
               string.IsNullOrEmpty(ciudadTextBox.Text))
            { 
                return false;
            }
            
            return true;
        }
        
        public bool validarFilaSeleccionada()
        {
            if (estudianteGridView.SelectedRows.Count>0)
            {
                return true;
            }
            return false;
        }

        private void estudianteGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (estudianteGridView.SelectedRows.Count>0)
            {
                nombreTextBox.Text = estudianteGridView.CurrentRow.Cells[1].Value.ToString();
                apellidoTextBox.Text = estudianteGridView.CurrentRow.Cells[2].Value.ToString();
                telefonoTextBox.Text = estudianteGridView.CurrentRow.Cells[3].Value.ToString();
                ciudadTextBox.Text = estudianteGridView.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
