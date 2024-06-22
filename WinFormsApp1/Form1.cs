namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();

            agregarMesaButton.Click += new EventHandler(AgregarMesaButton_Click);
            btnSalir.Click += new EventHandler(btnSalir_Click);
            agregarMesaButton.Visible = false;
            btnAddPared.Visible = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void AgregarMesaButton_Click(object sender, EventArgs e)
        {
            AgregarMesa();
        }

        private void AgregarMesa()
        {
            Mesa nuevaMesa = new Mesa();
            nuevaMesa.Location = new Point(10, 10);
            panel3.Controls.Add(nuevaMesa);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            // Iniciar el arrastre
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        //private void button1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isDragging)
        //    {
        //        // Mover el botón con el ratón
        //        Point p = PointToClient(MousePosition);
        //        button1.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
        //    }
        //}

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

            isDragging = false;
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
            panel3.Controls.Add(nuevaPared);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void agregarMesaButton_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class Mesa : Button
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public Mesa()
        {
            this.BackColor = Color.Red;
            this.Width = 100;
            this.Height = 100;
            this.MouseDown += new MouseEventHandler(Mesa_MouseDown);
            this.MouseMove += new MouseEventHandler(Mesa_MouseMove);
            this.MouseUp += new MouseEventHandler(Mesa_MouseUp);
        }

        private void Mesa_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Mesa_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = ((Control)sender).Parent.PointToClient(MousePosition);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Mesa_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
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

}
