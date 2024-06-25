using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public class Barra : Button, IEventos
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

        public void ModoEdicion()
        {
            this.MouseDown += new MouseEventHandler(Barra_MouseDown);
            this.MouseMove += new MouseEventHandler(Barra_MouseMove);
            this.MouseUp += new MouseEventHandler(Barra_MouseUp);
            this.ContextMenuStrip = new ContextMenuStrip();
            this.ContextMenuStrip.Items.Add("Eliminar Barra").Click += new EventHandler(EliminarBarra_Click);
        }

        public void ModoPrevisualizacion()
        {
            this.MouseDown -= new MouseEventHandler(Barra_MouseDown);
            this.MouseMove -= new MouseEventHandler(Barra_MouseMove);
            this.MouseUp -= new MouseEventHandler(Barra_MouseUp);
            this.ContextMenuStrip = null;
        }
    }
}
