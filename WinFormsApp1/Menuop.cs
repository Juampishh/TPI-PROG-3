namespace WinFormsApp1
{
    public partial class Menuop : Form
    {
        public Menuop()
        {
            InitializeComponent();
            btnEdicion.Visible = false;
            btnPrevisualizacion.Visible = false;
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}