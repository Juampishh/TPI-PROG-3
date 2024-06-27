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
        private bool guardado = false;
        private string archivo;

        public Form1(ref List<ControlState> estadoControles, string archivo)
        {
            InitializeComponent();

            agregarMesaButton.Click += new EventHandler(AgregarMesaButton_Click);
            btnSalir.Click += new EventHandler(btnSalir_Click);
            agregarMesaButton.Visible = true;
            btnAddPared.Visible = true;
            btnBaño.Visible = true;
            btnBarra.Visible = true;
            this.estadoControles = estadoControles; //recibe los controles de la lista
            this.archivo = archivo;
            
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
        //METODO PARA ACTUALIZAR CONTROLES

        public void ActualizarControles(List<ControlState> nuevosControles)
        {
            estadoControles = new List<ControlState>(nuevosControles);
            CargarControles();
        }

        //Metodo para serializar los controles
        private void GuardarControles()
        {
            List<ControlState> nuevosControles = new List<ControlState>();
            foreach (Control control in panelPlano.Controls)
            {
                if (control is Pared pared)
                {
                    ControlState estado = ControlState.SerilizarPared(pared);
                    nuevosControles.Add(estado);
                }
                else if (control is Mesa_para_2 mesa2)
                {
                    ControlState estado = ControlState.SerializarMesa2(mesa2);
                    nuevosControles.Add(estado);
                }
                else if (control is Mesa_para_4 mesa4)
                {
                    ControlState estado = ControlState.SerializarMesa4(mesa4);
                    nuevosControles.Add(estado);
                }
                else if (control is Mesa_para_6 mesa6)
                {
                    ControlState estado = ControlState.SerializarMesa6(mesa6);
                    nuevosControles.Add(estado);
                }
                else if (control is Barra barra)
                {
                    ControlState estado = ControlState.SerilizarBarra(barra);
                    nuevosControles.Add(estado);
                }
                else if (control is Baño baño)
                {
                    ControlState estado = ControlState.SerilizarBaño(baño);
                    nuevosControles.Add(estado);
                }
            }

            estadoControles = nuevosControles;
            ((Menuop)this.Owner).ActualizarEstadoControles(estadoControles);
        }

        //Metodo para deserializar los controles
        public void CargarControles()
        {

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
                    control.BackColor = Color.FromArgb(estado.ColorFondoArgb);


                }
                else if (estado.Tipo == nameof(Mesa_para_2))
                {
                    Mesa_para_2 mesa = new Mesa_para_2();

                    mesa.Location = new Point(estado.X, estado.Y);
                    mesa.CambiarColorMesa(estado.Color);
                    mesa.mesaNumber = estado.Numero;
                    mesa.pedidos = estado.Pedidos.Select(p => new Pedidos(p.Producto, p.Cantidad, p.PrecioUnitario, p.Categoria) { Pagado = p.Pagado }).ToList();
                    mesa.montoFinal = estado.Monto;
                    control = mesa;

                }
                else if (estado.Tipo == nameof(Mesa_para_4))
                {
                    Mesa_para_4 mesa = new Mesa_para_4();
                    mesa.Location = new Point(estado.X, estado.Y);
                    mesa.CambiarColorMesa(estado.Color);
                    mesa.mesaNumber = estado.Numero;
                    mesa.pedidos = estado.Pedidos.Select(p => new Pedidos(p.Producto, p.Cantidad, p.PrecioUnitario, p.Categoria) { Pagado = p.Pagado }).ToList();
                    mesa.montoFinal = estado.Monto;
                    control = mesa;

                }
                else if (estado.Tipo == nameof(Mesa_para_6))
                {
                    Mesa_para_6 mesa = new Mesa_para_6();
                    mesa.Location = new Point(estado.X, estado.Y);
                    mesa.CambiarColorMesa(estado.Color);
                    mesa.mesaNumber = estado.Numero;
                    mesa.pedidos = estado.Pedidos.Select(p => new Pedidos(p.Producto, p.Cantidad, p.PrecioUnitario, p.Categoria) { Pagado = p.Pagado }).ToList();
                    mesa.montoFinal = estado.Monto;
                    control = mesa;
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

            foreach (Control control in panelPlano.Controls)
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


        //Evento que permite volver en la aplicacion
        private void VolverButtom_Click(object sender, EventArgs e)
        {
            if (!guardado)
            {
                DialogResult result = MessageBox.Show("Restaurante no guardado, ¿realmente desea salir?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Hide();// Permite cerrar el formulario
                    
                }

            }
            else
            {
                this.Hide();
            }
                
        }


        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarControles();
            MessageBox.Show("Cambios guardados correctamente.");
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

        private void btnGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Restaurante Guardado");
            guardado = true;
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (!guardado)
            {
                DialogResult result = MessageBox.Show("Restaurante no guardado, ¿realmente desea salir?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Hide();// Permite cerrar el formulario

                }
                else
                {
                    e.Cancel = true;
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
