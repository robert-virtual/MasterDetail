
namespace MasterDetail.Views
{
    partial class NuevoColaborador
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
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_puesto = new System.Windows.Forms.TextBox();
            this.cb_puesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(232, 131);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.PlaceholderText = "DNI";
            this.txt_dni.Size = new System.Drawing.Size(299, 27);
            this.txt_dni.TabIndex = 0;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(232, 183);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PlaceholderText = "Clave";
            this.txt_clave.Size = new System.Drawing.Size(299, 27);
            this.txt_clave.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(323, 359);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 29);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_puesto
            // 
            this.txt_puesto.Location = new System.Drawing.Point(232, 299);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.PlaceholderText = "Nuevo Puesto";
            this.txt_puesto.Size = new System.Drawing.Size(299, 27);
            this.txt_puesto.TabIndex = 0;
            // 
            // cb_puesto
            // 
            this.cb_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_puesto.FormattingEnabled = true;
            this.cb_puesto.Location = new System.Drawing.Point(232, 250);
            this.cb_puesto.Name = "cb_puesto";
            this.cb_puesto.Size = new System.Drawing.Size(299, 28);
            this.cb_puesto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puesto";
            // 
            // NuevoColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_puesto);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_puesto);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_dni);
            this.Name = "NuevoColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoColaborador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_puesto;
        private System.Windows.Forms.ComboBox cb_puesto;
        private System.Windows.Forms.Label label1;
    }
}