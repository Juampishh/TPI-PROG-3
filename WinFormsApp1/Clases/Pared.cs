using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public class Pared : Button, IEventos
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
            ModoEdicion();
        }

        public void ModoEdicion()
        {
            this.MouseDown += new MouseEventHandler(Pared_MouseDown);
            this.MouseMove += new MouseEventHandler(Pared_MouseMove);
            this.MouseUp += new MouseEventHandler(Pared_MouseUp);
            this.ContextMenuStrip = new ContextMenuStrip();
            this.ContextMenuStrip.Items.Add("Cambiar Color").Click += new EventHandler(CambiarColor_Click);
            this.ContextMenuStrip.Items.Add("Eliminar Pared").Click += new EventHandler(EliminarPared_Click);
            this.ContextMenuStrip.Items.Add("Agregar Texto").Click += new EventHandler(AgregarTexto_Click);

        }



        public void ModoPrevisualizacion()
        {
            this.MouseDown -= new MouseEventHandler(Pared_MouseDown);
            this.MouseMove -= new MouseEventHandler(Pared_MouseMove);
            this.MouseUp -= new MouseEventHandler(Pared_MouseUp);
            this.ContextMenuStrip = null;

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
        // Evento para cambiar el color de la eventos
        private void CambiarColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
        // Evento para eliminar la eventos
        private void EliminarPared_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        //Evento para agregar Texto
        private void AgregarTexto_Click(object sender, EventArgs e)
        {
            string texto = InputBox("Ingrese el texto para la pared:", "Agregar Texto");
            if (!string.IsNullOrEmpty(texto))
            {
                this.Text = texto;
            }
        }

        //Clase para el inputBox, para agregar texto.
        public static string InputBox(string prompt, string title)
        {
            Form inputBox = new Form();
            inputBox.Width = 400;
            inputBox.Height = 150;
            inputBox.Text = title;

            Label label = new Label() { Left = 10, Top = 20, Text = prompt };
            TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 360 };

            Button okButton = new Button() { Text = "OK", Left = 300, Width = 70, Top = 80, DialogResult = DialogResult.OK };
            okButton.Click += (sender, e) => { inputBox.Close(); };

            inputBox.Controls.Add(label);
            inputBox.Controls.Add(textBox);
            inputBox.Controls.Add(okButton);
            inputBox.AcceptButton = okButton;

            return inputBox.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        // Método para dibujar el tamaño de la eventos
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawSizeGrip(pe.Graphics, this.BackColor, this.Width - gripSize, this.Height - gripSize, gripSize, gripSize);
        }
    }
}
