
namespace MasterDetail.Views
{
    partial class HistorialVentas
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
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.cb_show = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AllowUserToAddRows = false;
            this.dgv_ventas.AllowUserToDeleteRows = false;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Location = new System.Drawing.Point(94, 192);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.ReadOnly = true;
            this.dgv_ventas.RowHeadersWidth = 51;
            this.dgv_ventas.RowTemplate.Height = 29;
            this.dgv_ventas.Size = new System.Drawing.Size(1029, 459);
            this.dgv_ventas.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1029, 157);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 29);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cb_show
            // 
            this.cb_show.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_show.FormattingEnabled = true;
            this.cb_show.Items.AddRange(new object[] {
            "Resumen",
            "Detalles"});
            this.cb_show.Location = new System.Drawing.Point(94, 157);
            this.cb_show.Name = "cb_show";
            this.cb_show.Size = new System.Drawing.Size(229, 28);
            this.cb_show.TabIndex = 2;
            this.cb_show.SelectionChangeCommitted += new System.EventHandler(this.cb_show_SelectionChangeCommitted);
            // 
            // HistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_show);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dgv_ventas);
            this.Name = "HistorialVentas";
            this.Size = new System.Drawing.Size(1243, 782);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cb_show;
    }
}
