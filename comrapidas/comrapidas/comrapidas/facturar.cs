using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comrapidas
{
    public partial class password : Form
        {
        
        public password()
        {
            InitializeComponent();
        }

        
        private void facturar_Load(object sender, EventArgs e)
        {

        }

        private void btncrrar_Click(object sender, EventArgs e)
        {
            if(this.txtusu.Text == "jowi" && this.txtcontra.Text == "cr7")
            {
                Form1 llamar = new Form1();
                llamar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR usuario o contraseña incorrectos, intente de nuevo");
            }
        }
    }
}
