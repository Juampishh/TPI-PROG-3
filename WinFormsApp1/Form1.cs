namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            button1.MouseDown += new MouseEventHandler(button1_MouseDown);
            button1.MouseMove += new MouseEventHandler(button1_MouseMove);
            button1.MouseUp += new MouseEventHandler(button1_MouseUp);
            
            agregarMesaButton.Click += new EventHandler(AgregarMesaButton_Click);
            
        }
        private void AgregarMesaButton_Click(object sender, EventArgs e)
        {
            AgregarMesa();
        }
        private void AgregarMesa()
        {
            Mesa nuevaMesa = new Mesa();
            nuevaMesa.Location = new Point(10, 10); // Puedes ajustar la ubicación inicial según sea necesario
            panel3.Controls.Add(nuevaMesa);
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            // Iniciar el arrastre
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Mover el botón con el ratón
                Point p = PointToClient(MousePosition);
                button1.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            // Finalizar el arrastre
            isDragging = false;
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
}
