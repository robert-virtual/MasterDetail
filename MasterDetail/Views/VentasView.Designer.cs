
namespace MasterDetail.Views
{
    partial class VentasView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dni_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tel_cliente = new System.Windows.Forms.TextBox();
            this.dgv_prods = new System.Windows.Forms.DataGridView();
            this.lb_prods_venta = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_terminar_venta = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.n_decuento = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.n_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.n_precio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_decuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_precio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // txt_dni_cliente
            // 
            this.txt_dni_cliente.Location = new System.Drawing.Point(63, 230);
            this.txt_dni_cliente.MaxLength = 13;
            this.txt_dni_cliente.Name = "txt_dni_cliente";
            this.txt_dni_cliente.Size = new System.Drawing.Size(250, 27);
            this.txt_dni_cliente.TabIndex = 1;
            this.txt_dni_cliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dni_cliente_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datos del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre ";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Location = new System.Drawing.Point(340, 230);
            this.txt_nombre_cliente.MaxLength = 100;
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(250, 27);
            this.txt_nombre_cliente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefono";
            // 
            // txt_tel_cliente
            // 
            this.txt_tel_cliente.Location = new System.Drawing.Point(629, 230);
            this.txt_tel_cliente.MaxLength = 8;
            this.txt_tel_cliente.Name = "txt_tel_cliente";
            this.txt_tel_cliente.Size = new System.Drawing.Size(250, 27);
            this.txt_tel_cliente.TabIndex = 1;
            // 
            // dgv_prods
            // 
            this.dgv_prods.AllowUserToAddRows = false;
            this.dgv_prods.AllowUserToDeleteRows = false;
            this.dgv_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prods.Location = new System.Drawing.Point(63, 368);
            this.dgv_prods.Name = "dgv_prods";
            this.dgv_prods.ReadOnly = true;
            this.dgv_prods.RowHeadersWidth = 51;
            this.dgv_prods.RowTemplate.Height = 29;
            this.dgv_prods.Size = new System.Drawing.Size(816, 296);
            this.dgv_prods.TabIndex = 2;
            this.dgv_prods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prods_CellClick);
            // 
            // lb_prods_venta
            // 
            this.lb_prods_venta.FormattingEnabled = true;
            this.lb_prods_venta.ItemHeight = 20;
            this.lb_prods_venta.Location = new System.Drawing.Point(991, 368);
            this.lb_prods_venta.Name = "lb_prods_venta";
            this.lb_prods_venta.Size = new System.Drawing.Size(315, 304);
            this.lb_prods_venta.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(991, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Agregado a al venta";
            // 
            // btn_terminar_venta
            // 
            this.btn_terminar_venta.Location = new System.Drawing.Point(1147, 697);
            this.btn_terminar_venta.Name = "btn_terminar_venta";
            this.btn_terminar_venta.Size = new System.Drawing.Size(159, 29);
            this.btn_terminar_venta.TabIndex = 4;
            this.btn_terminar_venta.Text = "Terminar Venta";
            this.btn_terminar_venta.UseVisualStyleBackColor = true;
            this.btn_terminar_venta.Click += new System.EventHandler(this.btn_terminar_venta_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(681, 697);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(198, 29);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar  a la Venta";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // n_decuento
            // 
            this.n_decuento.Location = new System.Drawing.Point(440, 697);
            this.n_decuento.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.n_decuento.Name = "n_decuento";
            this.n_decuento.Size = new System.Drawing.Size(150, 27);
            this.n_decuento.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 672);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Descuento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 672);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cantidad";
            // 
            // n_cantidad
            // 
            this.n_cantidad.Location = new System.Drawing.Point(270, 697);
            this.n_cantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.n_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_cantidad.Name = "n_cantidad";
            this.n_cantidad.Size = new System.Drawing.Size(150, 27);
            this.n_cantidad.TabIndex = 5;
            this.n_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 671);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Precio";
            // 
            // n_precio
            // 
            this.n_precio.Enabled = false;
            this.n_precio.Location = new System.Drawing.Point(100, 696);
            this.n_precio.Name = "n_precio";
            this.n_precio.Size = new System.Drawing.Size(150, 27);
            this.n_precio.TabIndex = 5;
            // 
            // VentasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.n_precio);
            this.Controls.Add(this.n_cantidad);
            this.Controls.Add(this.n_decuento);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_terminar_venta);
            this.Controls.Add(this.lb_prods_venta);
            this.Controls.Add(this.dgv_prods);
            this.Controls.Add(this.txt_tel_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dni_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "VentasView";
            this.Size = new System.Drawing.Size(1339, 791);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_decuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dni_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tel_cliente;
        private System.Windows.Forms.DataGridView dgv_prods;
        private System.Windows.Forms.ListBox lb_prods_venta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_terminar_venta;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.NumericUpDown n_decuento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown n_cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown n_precio;
    }
}
