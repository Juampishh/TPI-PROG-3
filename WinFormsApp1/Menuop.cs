using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp1.Mesas;
using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class Menuop : Form
    {
        private List<ControlState> estadoControles;
        private const string archivo = "Controles.json";
        public Form1 formDiseño;
        public PrevisualizacionForm formPrevisualizacion;

        public Menuop()
        {
            InitializeComponent();
            btnEdicion.Visible = false;
            btnPrevisualizacion.Visible = false;
            estadoControles = new List<ControlState>();
            formDiseño= new Form1(ref estadoControles, archivo);
            formPrevisualizacion = new PrevisualizacionForm(ref estadoControles);
        }

        private void CargarControlesDesdeArchivo()
        {
            if (File.Exists(archivo))
            {
                string jsonString = File.ReadAllText(archivo);
                estadoControles = JsonSerializer.Deserialize<List<ControlState>>(jsonString);
            }
            else
            {
                estadoControles = new List<ControlState>();
            }
        }

        public void ActualizarEstadoControles(List<ControlState> nuevosControles)
        {
            estadoControles = nuevosControles;
            string jsonString = JsonSerializer.Serialize(estadoControles, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivo, jsonString);

            formDiseño.ActualizarControles(estadoControles);
            formPrevisualizacion.ActualizarControles(estadoControles);
        }

        private void panelEdicion_MouseEnter(object sender, EventArgs e)
        {
            panelEdicion.BackColor = Color.LightBlue;
            btnEdicion.Visible = true;
        }

        private void panelEdicion_MouseLeave(object sender, EventArgs e)
        {
            panelEdicion.BackColor = Color.WhiteSmoke;
            btnEdicion.Visible = false;
        }

        private void panelPrevisualizacion_MouseEnter(object sender, EventArgs e)
        {
            panelPrevisualizacion.BackColor = Color.LightGreen;
            btnPrevisualizacion.Visible = true;
        }

        private void panelPrevisualizacion_MouseLeave(object sender, EventArgs e)
        {
            panelPrevisualizacion.BackColor = Color.WhiteSmoke;
            btnPrevisualizacion.Visible = false;
        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ir a la pantalla de Edición");
            // Here you can add code to open a new form for editing
        }

        private void btnPrevisualizacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ir a la pantalla de Previsualización");
            // Here you can add code to open a new form for preview
        }

        private void panelPrevisualizacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ingresoPrev_Click(object sender, EventArgs e)
        {
            formPrevisualizacion.Owner = this;
            formPrevisualizacion.ActualizarControles(estadoControles);
            formPrevisualizacion.ShowDialog();
            
        }

        private void Menuop_Load(object sender, EventArgs e)
        {

        }

        private void panelEdicion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Edicion_Click(object sender, EventArgs e)
        {
            formDiseño.Owner = this;
            formDiseño.ActualizarControles(estadoControles);
            formDiseño.ShowDialog();
            
        }

        private void Menuop_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Menuop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
   
    
}