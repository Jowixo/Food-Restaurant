namespace comrapidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcmb1.Checked == true)
                MessageBox.Show("El valor del combo 1 es 30$");
        }

        private void chkcmb2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcmb2.Checked == true)
                MessageBox.Show("El valor del combo 2 es 30$");
        }

        private void chkcmb3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcmb3.Checked == true)
                MessageBox.Show("El valor del combo 3 es 25$");
        }

        private void chkcmb4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcmb4.Checked == true)
                MessageBox.Show("El valor del combo 4 es 20$");
        }

        private void chkagpap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkagpap.Checked == true)
                MessageBox.Show("El valor de agrandar tus papas es 4$");
        }

        private void chkagbeb_CheckedChanged(object sender, EventArgs e)
        {
            if (chkagbeb.Checked == true)
                MessageBox.Show("El valor de agrandar tu bebida es 4$");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbeb.Checked == true)
                MessageBox.Show("El valor de una bebida adicional es 4$");
        }

        private void clin_Click(object sender, EventArgs e)
        {
            if (chkcmb1.Checked == true)
                chkcmb1.Checked = false;

            if (chkcmb2.Checked == true)
                chkcmb2.Checked = false;

            if (chkcmb3.Checked == true)
                chkcmb3.Checked = false;

            if (chkcmb4.Checked == true)
                chkcmb4.Checked = false;

            if (chkagpap.Checked == true)
                chkagpap.Checked = false;

            if (chkagbeb.Checked == true)
                chkagbeb.Checked = false;

            if (chkbeb.Checked == true)
                chkbeb.Checked = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btpags_Click(object sender, EventArgs e)
        {
            pagar miforma=new pagar();
            miforma.ShowDialog();
        }
    }
}