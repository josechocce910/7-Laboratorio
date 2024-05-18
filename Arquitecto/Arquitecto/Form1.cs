namespace Arquitecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inicializar ComboBoxes
            cmbCondicion.Items.AddRange(new string[] { "Estable", "Contratado" });
            cmbEspecialidad.Items.AddRange(new string[] { "Estructuras", "Recursos Hídricos" });
            cmbSupervision.Items.AddRange(new string[] { "Obras", "Vías" });
            cmbAfiliacion.Items.AddRange(new string[] { "AFP", "SNP" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAfiliacion.SelectedIndex = 0;
            cmbCondicion.SelectedIndex = 0;
            cmbEspecialidad.SelectedIndex = 0;
            cmbSupervision.SelectedIndex = 0;
        }

        private void lblCódigo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            txtCodigo.Clear();
            txtNombres.Clear();
            cmbCondicion.SelectedIndex = -1;
            cmbEspecialidad.SelectedIndex = -1;
            cmbSupervision.SelectedIndex = -1;
            cmbAfiliacion.SelectedIndex = -1;
            txtResumen.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string codigo = txtCodigo.Text;
            string nombres = txtNombres.Text;
            string condicion = cmbCondicion.SelectedItem?.ToString();
            string especialidad = cmbEspecialidad.SelectedItem?.ToString();
            string actividad = cmbSupervision.SelectedItem?.ToString();
            string afiliacion = cmbAfiliacion.SelectedItem?.ToString();

            // Verificar que todos los datos necesarios han sido ingresados
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombres) ||
                string.IsNullOrEmpty(condicion) || string.IsNullOrEmpty(especialidad) ||
                string.IsNullOrEmpty(actividad) || string.IsNullOrEmpty(afiliacion))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear objeto Arquitecto
            Arquitecto arquitecto = new Arquitecto(codigo, nombres, condicion, especialidad, actividad, afiliacion);

            // Mostrar resultados en el formulario
           
           
            txtResumen.Text = arquitecto.ObtenerResumen();
        }
    }
}
