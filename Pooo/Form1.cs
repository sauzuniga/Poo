using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pooo
{
    public partial class cargar : Form
    {
        public cargar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.setIdaccount("armada_1000");
            cuenta.setpassword("azulado36000");
            cuenta.setbirthDate("3/08/2000");
            cuenta.setowner("Armando Hector Dario");
            cuenta._email = "Armando604@gmail.com";
           
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.setIdaccount(txtID.Text);
            cuenta.setpassword(txtPassword.Text);
            cuenta.setbirthDate(txtBirthday.Text);
            cuenta.setowner(txtOwner.Text);
            cuenta._email = txtEmail.Text;
            lstDatos.Items.Add(cuenta.getCuentainfo());
            lstDatos.Items.Add(cuenta.getIdinfo());
            lstDatos.Items.Add(cuenta.getPasswordinfo());
            lstDatos.Items.Add(cuenta.getBirthDateinfo());
            lstDatos.Items.Add(cuenta.getOwnerinfo());
            lstDatos.Items.Add(cuenta.getEmailinfo());
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCleantxt_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPassword.Clear();
            txtBirthday.Clear();
            txtOwner.Clear();
            txtEmail.Clear();
            lstDatos.Items.Clear();
        }
    }
}
