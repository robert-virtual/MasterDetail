using MasterDetail.DataAccess;
using MasterDetail.Views.promps;
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
    public partial class InventarioView : UserControl
    {
        public InventarioView()
        {
            InitializeComponent();
            LoadProductos();
        }
        void LoadProductos()
        {
            using (var db = new VentasDBContext())
            {
                dgv_prods.DataSource = db.Productos.Include("Categoria").ToList();
                
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var addProd = new AgregarProducto();
            addProd.ShowDialog();
            LoadProductos();
        }
    }
}
