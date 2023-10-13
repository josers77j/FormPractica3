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

namespace PresentationLayer.Forms
{
    public partial class ManagerForm : Form
    {

       
        public ManagerForm()
        {
            InitializeComponent();
            LoadManagerData();
        }
        private void LoadManagerData()
        {
            ManagerBussines managerbussines = new ManagerBussines();
            dataGridViewManagers.DataSource = managerbussines.GetManagers();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            ManagerBussines managerbussines = new ManagerBussines();
            string firstName = TextBoxNombre.Text;
            string lastName = TextBoxApellido.Text;

            managerbussines.AddManager(firstName, lastName);
            LoadManagerData();
            ClearForm();

        }

        private void ClearForm()
        {
            TextBoxNombre.Clear();
            TextBoxApellido.Clear();   
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewManagers.SelectedRows.Count>0)
            {
                int managerId = int.Parse(dataGridViewManagers.CurrentRow.Cells[0].Value.ToString());


                ManagerBussines managerbussines = new ManagerBussines();
                managerbussines.DeleteManager(managerId);
                LoadManagerData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridViewManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow selectedRow = dataGridViewManagers.SelectedRows[e.RowIndex];
                string firstName = selectedRow.Cells["firstName"].Value.ToString();
                string lastName = selectedRow.Cells["lastName"].Value.ToString();

                TextBoxNombre.Text = firstName;
                TextBoxApellido.Text = lastName; 
            }
        }
    }
}
