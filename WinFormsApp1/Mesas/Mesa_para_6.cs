using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Mesas
{
    public class Mesa_para_6 : PictureBox , IEventos
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private int mesaNumber = 1; // Número de mesa inicial

        public Mesa_para_6()
        {
            //Grafico
            this.BackColor = Color.Transparent;
            this.Width = 100;
            this.Height = 100;
            this.BackgroundImage = Image.FromFile("Resources/Mesa-6-verde.png");
            this.BackgroundImageLayout = ImageLayout.Zoom;
            //Opciones de click derecho
            this.ContextMenuStrip = new ContextMenuStrip();
            ModoEdicion();
            

        }


        //-----------------------------------------------------------------------------------
        //Metodo para escribir dentro de un pictureBox.
        private void Mesa_Numero(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para ingresar el nuevo número de mesa
            string newNumber = Interaction.InputBox("Ingrese el nuevo número de mesa:", "Modificar Número de Mesa", mesaNumber.ToString());
            if (!string.IsNullOrEmpty(newNumber))
            {
                if (int.TryParse(newNumber, out int result))
                {
                    mesaNumber = result;
                    this.Invalidate(); // Redibujar la PictureBox para reflejar el cambio
                }
                else
                {
                    MessageBox.Show("Número de mesa inválido. Ingrese un número entero válido.");
                }
            }
        }

        //-----------------------------------------------------------------------------------
        //Metodo para elegir el estado de la mesa
        private void CambiarColorMesa(string color)
        {
            switch (color)
            {
                case "Libre":
                    this.BackgroundImage = Image.FromFile("Resources/Mesa-6-verde.png");

                    break;
                case "Ocupado":
                    this.BackgroundImage = Image.FromFile("Resources/Mesa-6-Rojo.png");

                    break;
                case "Reservado":
                    this.BackgroundImage = Image.FromFile("Resources/Mesa-6-amarillo.png");

                    break;
            }
        }

        //-----------------------------------------------------------------------------------
        //Metodo para eliminar Mesa
        private void EliminarMesa(object sender, EventArgs e)
        {
            // Lógica para eliminar la mesa
            this.Parent.Controls.Remove(this);
        }


        //-----------------------------------------------------------------------------------
        //MOVER EL PICTUREBOX
        //Evento cuando hacemos click en el pictureBox para moverlo
        private void Mesa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        //Evento que detecta si estamos moviendo el mouse haciendo click en el PictureBox
        private void Mesa_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = ((Control)sender).Parent.PointToClient(MousePosition);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        //Evento que detecta cuando soltamos el pictureBox
        private void Mesa_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        //-----------------------------------------------------------------------------------
        //Metodo para dibujar(Escribir) dentro de un pictureBox
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Dibujar texto centrado en la PictureBox
            string text = $"#{mesaNumber}";
            Font font = new Font("Arial", 10, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);

            SizeF textSize = pe.Graphics.MeasureString(text, font);
            float x = (this.Width - textSize.Width) / 2;
            float y = (this.Height - textSize.Height) / 2;

            pe.Graphics.DrawString(text, font, brush, x, y);
        }

        public void ModoEdicion()
        {
            this.ContextMenuStrip.Items.Clear();
            this.MouseDown += new MouseEventHandler(Mesa_MouseDown);
            this.MouseMove += new MouseEventHandler(Mesa_MouseMove);
            this.MouseUp += new MouseEventHandler(Mesa_MouseUp);

            //Opciones de click derecho
            this.ContextMenuStrip.Items.Add("Asignar numero de mesa").Click += new EventHandler(Mesa_Numero);
            this.ContextMenuStrip.Items.Add("Eliminar mesa").Click += new EventHandler(EliminarMesa);

        }



        public void ModoPrevisualizacion()
        {
            this.ContextMenuStrip.Items.Clear();
            this.MouseDown -= new MouseEventHandler(Mesa_MouseDown);
            this.MouseMove -= new MouseEventHandler(Mesa_MouseMove);
            this.MouseUp -= new MouseEventHandler(Mesa_MouseUp);

            //SubMenu dentro del click derecho(Elegir estado de la mesa)
            ToolStripMenuItem CambiarColor = new ToolStripMenuItem("Cambiar estado de mesa");
            ToolStripMenuItem colorVerdeItem = new ToolStripMenuItem("Libre");
            colorVerdeItem.Click += (sender, e) => CambiarColorMesa("Libre");
            ToolStripMenuItem colorRojoItem = new ToolStripMenuItem("Ocupado");
            colorRojoItem.Click += (sender, e) => CambiarColorMesa("Ocupado");
            ToolStripMenuItem colorAmarilloItem = new ToolStripMenuItem("Reservado");
            colorAmarilloItem.Click += (sender, e) => CambiarColorMesa("Reservado");
            CambiarColor.DropDownItems.Add(colorVerdeItem);
            CambiarColor.DropDownItems.Add(colorRojoItem);
            CambiarColor.DropDownItems.Add(colorAmarilloItem);
            this.ContextMenuStrip.Items.Add(CambiarColor);

        }
    }
}
