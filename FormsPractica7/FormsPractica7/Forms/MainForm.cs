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

namespace FormsPractica7.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadPersonaData();
            LoadNacionalidadData();
            LoadGeneroData();
        }

        private void LoadGeneroData()
        {
            GeneroBussines generoBussines = new GeneroBussines();
            GeneroGridView.DataSource = generoBussines.GetGenero();
        }

        private void LoadNacionalidadData()
        {
            NacionalidadBussines nacionalidadBussines = new NacionalidadBussines();
            NacionalidadGridView.DataSource = nacionalidadBussines.GetNacionalidad();
        }

        private void LoadPersonaData()
        {
            PersonaBussines personaBussines = new PersonaBussines();
            PersonaGridView.DataSource= personaBussines.GetPersona();
        }
    }
}
