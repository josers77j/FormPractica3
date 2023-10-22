using BussinesLayer.Crud;
using CommonLayer;
using FormsPractica8.Validations;
using FluentValidation.Results;
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

            Students students = new Students();
            students.nombreEstudiante = nombreTextBox.Text;
            students.apellidoEstudiante = apellidoTextBox.Text;
            students.telefonoEstudiante = telefonoTextBox.Text;
            students.ciudadEstudiante = ciudadTextBox.Text;

            StudentsValidator studentValidator = new StudentsValidator();
            ValidationResult result = studentValidator.Validate(students);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    MessageBox.Show("Error: " + failure.ErrorMessage);
                }
            }
            else
            {
                try
                {
                    if (validarParametros())
                    {

                        estudianteBussines.addEstudiante(students);
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
                Students students = new Students();
                students.codigoEstudiante = int.Parse(estudianteGridView.CurrentRow.Cells[0].Value.ToString());
                EstudianteBussines estudianteBussines = new EstudianteBussines();
                estudianteBussines.deleteEstudiante(students);
                cargarDatosEstudiante();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para eliminar un parametro");
            }

        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (validarFilaSeleccionada())
            {
                    EstudianteBussines estudianteBussines = new EstudianteBussines();
                    
                    Students students = new Students();
                    students.codigoEstudiante = int.Parse(estudianteGridView.CurrentRow.Cells[0].Value.ToString());
                    students.nombreEstudiante = nombreTextBox.Text;
                    students.apellidoEstudiante = apellidoTextBox.Text;
                    students.telefonoEstudiante = telefonoTextBox.Text;
                    students.ciudadEstudiante = ciudadTextBox.Text;

                StudentsValidator studentValidator = new StudentsValidator();
                ValidationResult result = studentValidator.Validate(students);

                if (!result.IsValid)
                {
                    foreach (var failure in result.Errors)
                    {
                        MessageBox.Show("Error: " + failure.ErrorMessage);
                    }
                }
                else
                {                  
                            estudianteBussines.updateEstudiante(students);
                            cargarDatosEstudiante();
                            ClearForm();                                
                }
                
                
                
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para eliminar un parametro");
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EstudianteBussines studentBusiness = new EstudianteBussines();
            estudianteGridView.DataSource = studentBusiness.SearchStudents(txtBuscar.Text);
        }
    }
}
