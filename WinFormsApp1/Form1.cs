using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp1.Mesas;
using static System.Windows.Forms.AxHost;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private List<ControlState> estadoControles;
        private List<Control> controles;
        private string archivo;

        public Form1(ref List<ControlState> estadoControles, string archivo)
        {
            InitializeComponent();

            agregarMesaButton.Click += new EventHandler(AgregarMesaButton_Click);
            btnSalir.Click += new EventHandler(btnSalir_Click);
            agregarMesaButton.Visible = false;
            btnAddPared.Visible = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            btnBaño.Visible = false;
            btnBarra.Visible = false;
            this.estadoControles = estadoControles; //recibe los controles de la lista
            this.archivo = archivo;
            controles = new List<Control>();
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
                        controles.Add(mesa_para_2);

                        break;
                    case 4:
                        Mesa_para_4 mesa_para_4 = new Mesa_para_4();
                        mesa_para_4.Location = new Point(10, 10);
                        panelPlano.Controls.Add(mesa_para_4);
                        controles.Add(mesa_para_4);

                        break;
                    case 6:
                        Mesa_para_6 mesa_para_6 = new Mesa_para_6();
                        mesa_para_6.Location = new Point(10, 10);
                        panelPlano.Controls.Add(mesa_para_6);
                        controles.Add(mesa_para_6);
                        break;
                    default: break;
                }
            }

        }

        //Metodo para serializar los controles
        private void GuardarControles()
        {
            estadoControles.Clear();
            foreach (Control control in controles)
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
                else
                {
                    ControlState estado = new ControlState(control.GetType().Name,
                        control.Location.X,
                        control.Location.Y);
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
            controles.Clear();

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

                if (control != null)
                {
                    panelPlano.Controls.Add(control);
                    controles.Add(control);
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
            controles.Add(nuevaPared);
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
        //Evento para cambiar a modo de modificación
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAddPared.Visible = true;
            agregarMesaButton.Visible = true;
            btnBaño.Visible = true;
            btnBarra.Visible = true;
        }

        private void VolverButtom_Click(object sender, EventArgs e)
        {
            Menuop menuop = new Menuop();
            menuop.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
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
                    this.Hide();
                    Application.Exit();
                }
                else
                {
                    // El usuario decidió no salir
                    e.Cancel = true;
                }
            }
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
            controles.Add(nuevoBaño);
            //panel3.Controls.Add(nuevoBaño);
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
            controles.Add(nuevaBarra);
            //panel3.Controls.Add(nuevaBarra);
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



    public class Pared : Button
    {
        // Variables para arrastrar y redimensionar
        private bool isDragging = false;
        private bool isResizing = false;
        private Point startPoint = new Point(0, 0);
        private const int gripSize = 10;

        // Constructor
        public Pared()
        {
            this.BackColor = Color.Black;
            this.Width = 30;
            this.Height = 100;
            this.MouseDown += new MouseEventHandler(Pared_MouseDown);
            this.MouseMove += new MouseEventHandler(Pared_MouseMove);
            this.MouseUp += new MouseEventHandler(Pared_MouseUp);
            this.ContextMenuStrip = new ContextMenuStrip();
            this.ContextMenuStrip.Items.Add("Cambiar Color").Click += new EventHandler(CambiarColor_Click);
            this.ContextMenuStrip.Items.Add("Eliminar Pared").Click += new EventHandler(EliminarPared_Click);
        }
        // Eventos para arrastrar y redimensionar
        private void Pared_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X >= this.Width - gripSize && e.Y >= this.Height - gripSize)
            {
                isResizing = true;
            }
            else
            {
                isDragging = true;
            }
            startPoint = new Point(e.X, e.Y);
        }
        // Evento para arrastrar y redimensionar
        private void Pared_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = ((Control)sender).Parent.PointToClient(MousePosition);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
            else if (isResizing)
            {
                this.Width = e.X;
                this.Height = e.Y;
            }
        }
        // Evento para arrastrar y redimensionar
        private void Pared_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }
        // Evento para cambiar el color de la pared
        private void CambiarColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
        // Evento para eliminar la pared
        private void EliminarPared_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        // Método para dibujar el tamaño de la pared
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawSizeGrip(pe.Graphics, this.BackColor, this.Width - gripSize, this.Height - gripSize, gripSize, gripSize);
        }
    }
    public class Baño : Button
    {
        // Variables para arrastrar y redimensionar
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        private bool isDragging = false;
        private bool isResizing = false;
        private Point startPoint = new Point(10, 10);
        private const int gripSize = 10;


        public Baño()
        {
            this.Width = 150;
            this.Height = 150;
            this.BackgroundImage = (Image)resources.GetObject("btnBaño.BackgroundImage");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            this.MouseDown += new MouseEventHandler(Baño_MouseDown);
            this.MouseMove += new MouseEventHandler(Baño_MouseMove);
            this.MouseUp += new MouseEventHandler(Baño_MouseUp);
            this.ContextMenuStrip = new ContextMenuStrip();
            this.ContextMenuStrip.Items.Add("Eliminar Baño").Click += new EventHandler(EliminarBaño_Click);
        }

        private void EliminarBaño_Click(object? sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void Baño_MouseUp(object? sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }

        private void Baño_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = ((Control)sender).Parent.PointToClient(MousePosition);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
            else if (isResizing)
            {
                this.Width = e.X;
                this.Height = e.Y;
            }
        }

        private void Baño_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.X >= this.Width - gripSize && e.Y >= this.Height - gripSize)
            {
                isResizing = true;
            }
            else
            {
                isDragging = true;
            }
            startPoint = new Point(e.X, e.Y);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawSizeGrip(pe.Graphics, this.BackColor, this.Width - gripSize, this.Height - gripSize, gripSize, gripSize);
        }
    }

    public class Barra : Button
    {
        // Variables para arrastrar y redimensionar
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        private bool isDragging = false;
        private bool isResizing = false;
        private Point startPoint = new Point(10, 10);
        private const int gripSize = 10;
        //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        public Barra()
        {
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Width = 150;
            this.Height = 150;
            this.BackgroundImage = (Image)resources.GetObject("btnBarra.BackgroundImage");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //this.BackgroundImage = (Image)resources.GetObject("btnBaño.BackgroundImage");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.MouseDown += new MouseEventHandler(Barra_MouseDown);
            this.MouseMove += new MouseEventHandler(Barra_MouseMove);
            this.MouseUp += new MouseEventHandler(Barra_MouseUp);
            this.ContextMenuStrip = new ContextMenuStrip();
            this.ContextMenuStrip.Items.Add("Eliminar Barra").Click += new EventHandler(EliminarBarra_Click);
        }

        private void EliminarBarra_Click(object? sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void Barra_MouseUp(object? sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }

        private void Barra_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = ((Control)sender).Parent.PointToClient(MousePosition);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
            else if (isResizing)
            {
                this.Width = e.X;
                this.Height = e.Y;
            }
        }

        private void Barra_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.X >= this.Width - gripSize && e.Y >= this.Height - gripSize)
            {
                isResizing = true;
            }
            else
            {
                isDragging = true;
            }
            startPoint = new Point(e.X, e.Y);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawSizeGrip(pe.Graphics, this.BackColor, this.Width - gripSize, this.Height - gripSize, gripSize, gripSize);
        }
    }
}
