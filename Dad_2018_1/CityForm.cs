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
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            this.FillData();

        }

        private void FillData()
        {
            PropertyContextEntities ctx = new PropertyContextEntities();
            dataGridView1.DataSource = ctx.City.ToList<City>();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            PropertyContextEntities ctx = new PropertyContextEntities();

            City cit = new City();
            cit.CityName = txtName.Text;

            ctx.City.Add(cit);
            ctx.SaveChanges();
            FillData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            lblId.Text = Convert.ToString(row.Cells[0].Value);
            txtName.Text = Convert.ToString(row.Cells[1].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PropertyContextEntities context = new PropertyContextEntities();
            int id = Convert.ToInt32(lblId.Text);
            City cit = context.City.Where(c => c.Id == id).FirstOrDefault<City>();
            cit.CityName = txtName.Text;
            
            context.Entry(cit).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            FillData();
            MessageBox.Show("Record updated successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PropertyContextEntities context = new PropertyContextEntities();
            int id = Convert.ToInt32(lblId.Text);
            City cit = context.City.Where(c => c.Id == id).FirstOrDefault<City>();

            context.Entry(cit).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
            FillData();
            MessageBox.Show("Record deleted successfully");
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
