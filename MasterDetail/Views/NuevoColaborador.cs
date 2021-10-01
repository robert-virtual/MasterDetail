using MasterDetail.DataAccess;
using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace MasterDetail.Views
{
    public partial class NuevoColaborador : Form
    {
        public NuevoColaborador()
        {
            InitializeComponent();
            loadPuestos();
        }
        void loadPuestos()
        {
            using (var db = new VentasDBContext())
            {
                cb_puesto.DataSource = db.Puestos.ToList();
                cb_puesto.ValueMember = "Id";
                cb_puesto.DisplayMember = "Nombre";

            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new VentasDBContext())
                {
                    var puesto = new Puesto()
                    {
                        Nombre = txt_puesto.Text
                    };
                    var colaborador = new Colaborador()
                    {
                        DNI = txt_dni.Text,
                        Clave = txt_clave.Text,
                        Puesto = puesto
                    };
                    db.Colaboradores.Add(colaborador);
                    db.SaveChanges();
                    MessageBox.Show("Colaborador guardado correctamente","Guardar Colaborador");
                }

            }
            catch (Exception error)
            {

                MessageBox.Show($"Error: {error}", "Guardar Colaborador",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
