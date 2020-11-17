using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dad_2018_1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cityFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityForm cfr = new CityForm();
            cfr.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PaymentForm pfrm = new PaymentForm();
            pfrm.Show();
        }

        private void propertyTypeFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropType pt = new PropType();
            pt.Show();
        }

        private void propertyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerForm own = new OwnerForm();
            own.Show();
        }

        private void propertyTypeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyForm pf = new PropertyForm();
            pf.Show();
        }

        private void salesDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertySalesForm psf = new PropertySalesForm();
            psf.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentForm rf = new RentForm();
            rf.Show();
        }

        private void salesDetailFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesDetailForm sf = new SalesDetailForm();
            sf.Show();
        }
    }
}
