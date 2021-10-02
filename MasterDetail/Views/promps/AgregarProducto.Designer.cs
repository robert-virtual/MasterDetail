
namespace MasterDetail.Views.promps
{
    partial class AgregarProducto
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.n_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n_precio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.n_impuesto = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nuevaCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_impuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(98, 60);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(234, 27);
            this.txt_nombre.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(381, 279);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(234, 29);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // n_cantidad
            // 
            this.n_cantidad.Location = new System.Drawing.Point(98, 133);
            this.n_cantidad.Name = "n_cantidad";
            this.n_cantidad.Size = new System.Drawing.Size(234, 27);
            this.n_cantidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // n_precio
            // 
            this.n_precio.Location = new System.Drawing.Point(98, 204);
            this.n_precio.Name = "n_precio";
            this.n_precio.Size = new System.Drawing.Size(234, 27);
            this.n_precio.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // n_impuesto
            // 
            this.n_impuesto.Location = new System.Drawing.Point(98, 279);
            this.n_impuesto.Name = "n_impuesto";
            this.n_impuesto.Size = new System.Drawing.Size(234, 27);
            this.n_impuesto.TabIndex = 2;
            this.n_impuesto.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "%";
            // 
            // cb_categoria
            // 
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(381, 59);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(234, 28);
            this.cb_categoria.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Categoria";
            // 
            // txt_nuevaCategoria
            // 
            this.txt_nuevaCategoria.Location = new System.Drawing.Point(381, 132);
            this.txt_nuevaCategoria.Name = "txt_nuevaCategoria";
            this.txt_nuevaCategoria.PlaceholderText = "Nueva Categoria";
            this.txt_nuevaCategoria.Size = new System.Drawing.Size(234, 27);
            this.txt_nuevaCategoria.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nueva Categoria";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_impuesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_precio);
            this.Controls.Add(this.n_cantidad);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_nuevaCategoria);
            this.Controls.Add(this.txt_nombre);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.n_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_impuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown n_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown n_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown n_impuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nuevaCategoria;
        private System.Windows.Forms.Label label7;
    }
}