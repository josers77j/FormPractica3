using ProductosLibrary;

namespace FormPractica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Tareas tarea = new Tareas()
            {
                nombre = NombreTextBox.Text,
                descripción = DescripcionTextBox.Text,
                fechaInicio = FechaInicioDateTimePicker.Value,
                fechaFin = FechaFinDateTimePicker.Value

            };
            ProductosDataGridView.Columns.Add("Nombre", "Nombre");
            ProductosDataGridView.Columns.Add("Descripcion", "Descripcion");
            ProductosDataGridView.Columns.Add("Fecha Inicio", "Fecha Inicio");
            ProductosDataGridView.Columns.Add("Fecha Fin", "Fecha Fin");

            ProductosDataGridView.Rows.Add(tarea.nombre, tarea.descripción, tarea.fechaInicio.ToLongDateString(), tarea.fechaFin.ToLongDateString());

        }
    }
}