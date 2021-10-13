using MasterDetail.DataAccess;
using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MasterDetail.Views
{
    public partial class ClientesView : UserControl
    {
        List<Cliente> Clientes = new List<Cliente>();
        public ClientesView()
        {
            InitializeComponent();
            LoadClientes();
        }
        void LoadClientes()
        {
            using (var db = new VentasDBContext())
            {
                Clientes = db.Clientes.ToList();
            }
            dgv_clientes.DataSource = Clientes;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadClientes();
        }
    }
}
