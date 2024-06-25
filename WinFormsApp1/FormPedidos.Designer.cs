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
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.listaCategorias = new System.Windows.Forms.ListBox();
            this.listaProductos = new System.Windows.Forms.ListBox();
            this.listaPedido = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.panelBienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(173)))));
            this.panelBienvenida.Controls.Add(this.lblBienvenida);
            this.panelBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBienvenida.Location = new System.Drawing.Point(0, 0);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(984, 100);
            this.panelBienvenida.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBienvenida.Location = new System.Drawing.Point(339, 25);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(306, 54);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "¡Haz tu pedido!";
            // 
            // listaCategorias
            // 
            this.listaCategorias.BackColor = System.Drawing.Color.Linen;
            this.listaCategorias.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaCategorias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaCategorias.FormattingEnabled = true;
            this.listaCategorias.ItemHeight = 28;
            this.listaCategorias.Location = new System.Drawing.Point(0, 100);
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.Size = new System.Drawing.Size(200, 440);
            this.listaCategorias.TabIndex = 1;
            // 
            // listaProductos
            // 
            this.listaProductos.BackColor = System.Drawing.Color.SeaShell;
            this.listaProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaProductos.FormattingEnabled = true;
            this.listaProductos.ItemHeight = 28;
            this.listaProductos.Location = new System.Drawing.Point(200, 100);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.Size = new System.Drawing.Size(300, 440);
            this.listaProductos.TabIndex = 2;
            // 
            // listaPedido
            // 
            this.listaPedido.BackColor = System.Drawing.Color.MintCream;
            this.listaPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaPedido.FormattingEnabled = true;
            this.listaPedido.ItemHeight = 28;
            this.listaPedido.Location = new System.Drawing.Point(500, 100);
            this.listaPedido.Name = "listaPedido";
            this.listaPedido.Size = new System.Drawing.Size(484, 390);
            this.listaPedido.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(0, 540);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(984, 50);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar al pedido";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.BackColor = System.Drawing.Color.LightYellow;
            this.lblMontoTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMontoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontoTotal.Location = new System.Drawing.Point(500, 490);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(484, 50);
            this.lblMontoTotal.TabIndex = 5;
            this.lblMontoTotal.Text = "Monto Total: $0.00";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 590);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.listaPedido);
            this.Controls.Add(this.listaProductos);
            this.Controls.Add(this.listaCategorias);
            this.Controls.Add(this.panelBienvenida);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormPedidos";
            this.Text = "Menú del Restaurante";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.panelBienvenida.ResumeLayout(false);
            this.panelBienvenida.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.ListBox listaCategorias;
        private System.Windows.Forms.ListBox listaProductos;
        private System.Windows.Forms.ListBox listaPedido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMontoTotal;
    }
}