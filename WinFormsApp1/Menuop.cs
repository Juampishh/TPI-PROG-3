using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp1.Mesas;

namespace WinFormsApp1
{
    public partial class Menuop : Form
    {
        private List<ControlState> estadoControles;
        private const string archivo = "Controles.json";
        public Menuop()
        {
            InitializeComponent();
            btnEdicion.Visible = false;
            btnPrevisualizacion.Visible = false;
            estadoControles = new List<ControlState>();
            CargarControles();
        }

        private void CargarControles()
        {
            if (estadoControles == null || estadoControles.Count == 0)
            {
                if (!File.Exists(archivo)) return;
                string jsonString = File.ReadAllText(archivo);
                estadoControles = JsonSerializer.Deserialize<List<ControlState>>(jsonString);
            }

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
            PrevisualizacionForm prevForm = new PrevisualizacionForm(ref estadoControles);
            prevForm.Show();
            this.Hide();
        }

        private void Menuop_Load(object sender, EventArgs e)
        {

        }

        private void panelEdicion_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Edicion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(ref estadoControles, archivo);
            form1.Show();
            this.Hide();
        }
    }
    public class ControlState
    {
        public string Tipo { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public string ColorFondo { get; set; }

        public ControlState() { }
        public ControlState(string tipo, int x, int y)
        {
            Tipo = tipo;
            X = x;
            Y = y;
            
        }
        public ControlState(string tipo, int x, int y, int alto, int ancho, string colorFondo)
        {
            Tipo = tipo;
            X = x;
            Y = y;
            Alto = alto;
            Ancho = ancho;
            ColorFondo = colorFondo;
        }
        

    }
}