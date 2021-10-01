using MasterDetail.DataAccess;
using MasterDetail.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDetail
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            using (var db = new VentasDBContext())
            {
                var colaborador = db.Colaboradores.Find(txt_dni.Text);
                if (colaborador != null)
                {
                    if (colaborador.Clave == txt_password.Text)
                    {
                        var menu = new Menu(colaborador);
                        menu.Show();
                        this.Hide();
                        return;
                    }

                }
                
                ShowMsg("Credenciales incorrectas");
                
                
            }
        }
        void ShowMsg(string msg)
        {
               MessageBox.Show(msg, "Inicio de sesion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            var nuevo = new NuevoColaborador();
            nuevo.ShowDialog();

        }
    }
}
