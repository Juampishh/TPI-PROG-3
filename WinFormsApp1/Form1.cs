using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp1.Clases;
using WinFormsApp1.Mesas;
using static System.Windows.Forms.AxHost;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private List<ControlState> estadoControles;
        
        private string archivo;

        public Form1(ref List<ControlState> estadoControles, string archivo)
        {
            InitializeComponent();

            agregarMesaButton.Click += new EventHandler(AgregarMesaButton_Click);
            btnSalir.Click += new EventHandler(btnSalir_Click);
            agregarMesaButton.Visible = true;
            btnAddPared.Visible = true;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            btnBaño.Visible = true;
            btnBarra.Visible = true;
            this.estadoControles = estadoControles; //recibe los controles de la lista
            this.archivo = archivo;
            
            CargarControles();
        }

        private void AgregarMesaButton_Click(object sender, EventArgs e)
        {
            ElegirMesa elegirMesa = new ElegirMesa();

            if (elegirMesa.ShowDialog() == DialogResult.OK)
            {
                switch (elegirMesa.opcionElegida)
                {
                    case 2:
                        Mesa_para_2 mesa_para_2 = new Mesa_para_2();
                        mesa_para_2.Location = new Point(10, 10);
                        panelPlano.Controls.Add(mesa_para_2);
                        

                        break;
                    case 4:
                        Mesa_para_4 mesa_para_4 = new Mesa_para_4();
                        mesa_para_4.Location = new Point(10, 10);
                        panelPlano.Controls.Add(mesa_para_4);
                        

                        break;
                    case 6:
                        Mesa_para_6 mesa_para_6 = new Mesa_para_6();
                        mesa_para_6.Location = new Point(10, 10);
                        panelPlano.Controls.Add(mesa_para_6);
                        
                        break;
                    default: break;
                }
            }

        }

        //Metodo para serializar los controles
        private void GuardarControles()
        {
            estadoControles.Clear();
            foreach (Control control in panelPlano.Controls)
            {
                if (control is Pared pared)
                {
                    ControlState estado = new ControlState(pared.GetType().Name,
                        pared.Location.X,
                        pared.Location.Y,
                        pared.Height,
                        pared.Width,
                        pared.BackColor.Name);
                    estadoControles.Add(estado);
                }
                else if (control is Mesa_para_2 || control is Mesa_para_4 || control is Mesa_para_6)
                {
                    ControlState estado = new ControlState(control.GetType().Name,
                        control.Location.X,
                        control.Location.Y);
                    estadoControles.Add(estado);
                }
                else if(control is Barra || control is Baño)
                {
                    ControlState estado = new ControlState(control.GetType().Name,
                        control.Location.X,
                        control.Location.Y,
                        control.Height,
                        control.Width);
                    estadoControles.Add(estado);
                }

            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(estadoControles, options);
            File.WriteAllText(archivo, jsonString);
        }

        //Metodo para deserializar los controles
        private void CargarControles()
        {
            if (estadoControles == null || estadoControles.Count == 0)
            {
                if (!File.Exists(archivo)) return;
                string jsonString = File.ReadAllText(archivo);
                estadoControles = JsonSerializer.Deserialize<List<ControlState>>(jsonString);
            }


            panelPlano.Controls.Clear();
            

            foreach (ControlState estado in estadoControles)
            {
                Control control = null;
                if (estado.Tipo == nameof(Pared))
                {
                    control = new Pared();
                    control.Location = new Point(estado.X, estado.Y);
                    control.Width = estado.Ancho;
                    control.Height = estado.Alto;
                    control.BackColor = Color.FromName(estado.ColorFondo);


                }
                else if (estado.Tipo == nameof(Mesa_para_2))
                {
                    control = new Mesa_para_2();
                    control.Location = new Point(estado.X, estado.Y);
                }
                else if (estado.Tipo == nameof(Mesa_para_4))
                {
                    control = new Mesa_para_4();
                    control.Location = new Point(estado.X, estado.Y);
                }
                else if (estado.Tipo == nameof(Mesa_para_6))
                {
                    control = new Mesa_para_6();
                    control.Location = new Point(estado.X, estado.Y);
                }
                else if (estado.Tipo == nameof(Baño))
                {
                    control = new Baño();
                    control.Location = new Point(estado.X, estado.Y);
                    control.Width = estado.Ancho;
                    control.Height = estado.Alto;

                }
                else if (estado.Tipo == nameof(Barra))
                {
                    control = new Barra();
                    control.Location = new Point(estado.X, estado.Y);
                    control.Width = estado.Ancho;
                    control.Height = estado.Alto;
                }

                if (control != null)
                {
                    panelPlano.Controls.Add(control);
                    
                }

            }

            foreach(Control control in panelPlano.Controls)
            {
                if (control is IEventos eventos)
                {
                    eventos.ModoEdicion();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPared_Click(object sender, EventArgs e)
        {
            agregarPared();

        }

        private void agregarPared()
        {
            Pared nuevaPared = new Pared();
            nuevaPared.Location = new Point(10, 10);
            nuevaPared.MouseDown += new MouseEventHandler(Pared_MouseDown);
            panelPlano.Controls.Add(nuevaPared);
            
        }

        // Evento para mostrar el menú contextual al hacer clic derecho
        private void Pared_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Pared pared = sender as Pared;
                if (pared != null)
                {
                    pared.ContextMenuStrip.Show(pared, e.Location);
                }
            }
        }
        // Evento para salir de la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        

        private void VolverButtom_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            /*if (e.CloseReason == CloseReason.UserClosing)
            {
                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea salir? Sus cambios no están guardados.",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // El usuario confirmó que quiere salir
                    Menuop menuop = new Menuop();
                    menuop.Show();
                    this.Hide();
                }
                else
                {
                    // El usuario decidió no salir
                    e.Cancel = true;
                }
            }*/
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarControles();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void agregrarBaño()
        {
            Baño nuevoBaño = new Baño();
            nuevoBaño.Location = new Point(15, 15);
            nuevoBaño.MouseDown += new MouseEventHandler(Baño_MouseDown);
            panelPlano.Controls.Add(nuevoBaño);
           
            
        }
        private void Baño_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Baño baño = sender as Baño;
                if (baño != null)
                {
                    baño.ContextMenuStrip.Show(baño, e.Location);
                }
            }
        }
        private void btnBaño_Click(object sender, EventArgs e)
        {
            agregrarBaño();
        }

        private void agregrarBarra()
        {
            Barra nuevaBarra = new Barra();
            nuevaBarra.Location = new Point(15, 15);
            nuevaBarra.MouseDown += new MouseEventHandler(Barra_MouseDown);
            panelPlano.Controls.Add(nuevaBarra);
           
        }
        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Barra barra = sender as Barra;
                if (barra != null)
                {
                    barra.ContextMenuStrip.Show(barra, e.Location);
                }
            }
        }
        private void btnBarra_Click(object sender, EventArgs e)
        {
            agregrarBarra();
        }
    }


    
}
