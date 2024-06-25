namespace WinFormsApp1
{
    partial class FormPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBienvenida = new Panel();
            lblBienvenida = new Label();
            listaCategorias = new ListBox();
            listaProductos = new ListBox();
            listaPedido = new ListBox();
            btnAgregar = new Button();
            lblMontoTotal = new Label();
            panel1 = new Panel();
            btCancelarPedido = new Button();
            btAceptarPedido = new Button();
            panelBienvenida.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBienvenida
            // 
            panelBienvenida.BackColor = Color.FromArgb(255, 222, 173);
            panelBienvenida.Controls.Add(lblBienvenida);
            panelBienvenida.Dock = DockStyle.Top;
            panelBienvenida.Location = new Point(0, 0);
            panelBienvenida.Margin = new Padding(3, 2, 3, 2);
            panelBienvenida.Name = "panelBienvenida";
            panelBienvenida.Size = new Size(851, 75);
            panelBienvenida.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.SaddleBrown;
            lblBienvenida.Location = new Point(292, 19);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(251, 38);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Haz tu pedido!";
            // 
            // listaCategorias
            // 
            listaCategorias.BackColor = Color.Linen;
            listaCategorias.Dock = DockStyle.Left;
            listaCategorias.Font = new Font("Century Gothic", 12F);
            listaCategorias.FormattingEnabled = true;
            listaCategorias.ItemHeight = 21;
            listaCategorias.Location = new Point(0, 75);
            listaCategorias.Margin = new Padding(3, 2, 3, 2);
            listaCategorias.Name = "listaCategorias";
            listaCategorias.Size = new Size(176, 335);
            listaCategorias.TabIndex = 1;
            // 
            // listaProductos
            // 
            listaProductos.BackColor = Color.SeaShell;
            listaProductos.Dock = DockStyle.Left;
            listaProductos.Font = new Font("Century Gothic", 12F);
            listaProductos.FormattingEnabled = true;
            listaProductos.ItemHeight = 21;
            listaProductos.Location = new Point(176, 75);
            listaProductos.Margin = new Padding(3, 2, 3, 2);
            listaProductos.Name = "listaProductos";
            listaProductos.Size = new Size(263, 335);
            listaProductos.TabIndex = 2;
            // 
            // listaPedido
            // 
            listaPedido.BackColor = Color.MintCream;
            listaPedido.Dock = DockStyle.Fill;
            listaPedido.Font = new Font("Century Gothic", 12F);
            listaPedido.FormattingEnabled = true;
            listaPedido.ItemHeight = 21;
            listaPedido.Location = new Point(439, 75);
            listaPedido.Margin = new Padding(3, 2, 3, 2);
            listaPedido.Name = "listaPedido";
            listaPedido.Size = new Size(412, 335);
            listaPedido.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.Dock = DockStyle.Bottom;
            btnAgregar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(0, 410);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(851, 38);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar al pedido";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.BackColor = Color.LightYellow;
            lblMontoTotal.Dock = DockStyle.Bottom;
            lblMontoTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblMontoTotal.Location = new Point(439, 372);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(412, 38);
            lblMontoTotal.TabIndex = 5;
            lblMontoTotal.Text = "Monto Total: $0.00";
            lblMontoTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(btCancelarPedido);
            panel1.Controls.Add(btAceptarPedido);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(707, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 297);
            panel1.TabIndex = 6;
            // 
            // btCancelarPedido
            // 
            btCancelarPedido.FlatStyle = FlatStyle.Flat;
            btCancelarPedido.Location = new Point(16, 169);
            btCancelarPedido.Name = "btCancelarPedido";
            btCancelarPedido.Size = new Size(116, 23);
            btCancelarPedido.TabIndex = 1;
            btCancelarPedido.Text = "Cancelar Pedido";
            btCancelarPedido.UseVisualStyleBackColor = true;
            btCancelarPedido.Click += btCancelarPedido_Click;
            // 
            // btAceptarPedido
            // 
            btAceptarPedido.FlatStyle = FlatStyle.Flat;
            btAceptarPedido.Location = new Point(16, 78);
            btAceptarPedido.Name = "btAceptarPedido";
            btAceptarPedido.Size = new Size(116, 23);
            btAceptarPedido.TabIndex = 0;
            btAceptarPedido.Text = "Aceptar pedido";
            btAceptarPedido.UseVisualStyleBackColor = true;
            btAceptarPedido.Click += btAceptarPedido_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(851, 448);
            Controls.Add(panel1);
            Controls.Add(lblMontoTotal);
            Controls.Add(listaPedido);
            Controls.Add(listaProductos);
            Controls.Add(listaCategorias);
            Controls.Add(panelBienvenida);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPedidos";
            Text = "Menú del Restaurante";
            Load += FormPedidos_Load;
            panelBienvenida.ResumeLayout(false);
            panelBienvenida.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.ListBox listaCategorias;
        private System.Windows.Forms.ListBox listaProductos;
        private System.Windows.Forms.ListBox listaPedido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMontoTotal;
        private Panel panel1;
        private Button btCancelarPedido;
        private Button btAceptarPedido;
    }
}