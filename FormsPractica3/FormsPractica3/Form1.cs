using ItemLibrary;

namespace FormsPractica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(Numero1TextBox.Text);
            int numero2 = int.Parse(Numero2TextBox.Text);

            Calculadora calcular = new Calculadora(numero1, numero2);

            // Mostrar los resultados en etiquetas de texto en el formulario
            MessageBox.Show($"Suma : {calcular.Suma()}");
            MessageBox.Show($"Resta : {calcular.Resta()}");
            MessageBox.Show($"Multiplicacion : {calcular.Multiplicacion()}");

            try
            {
                MessageBox.Show($"Division : {calcular.Division()}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Division : {ex.Message}");

            }
        }

    }
}