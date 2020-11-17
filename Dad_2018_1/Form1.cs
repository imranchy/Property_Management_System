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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FillData();
            this.LoadCombo();
        }

        private void FillData()
        {   
            PropertyContextEntities  ctx = new PropertyContextEntities();
            dataGridView1.DataSource = ctx.Client.ToList<Client>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {    




            //entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            //entities.SaveChanges();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            PropertyContextEntities ctx = new PropertyContextEntities();

            Client client = new Client();

            client.Name = txtName.Text;
            client.Address = txtAddress.Text;
            client.ContactNo = txtContactNo.Text;
            client.CityId = Convert.ToInt32( ddlCity.SelectedValue);
            string val = "";
            if(radioFemale.Checked){
                 val = "F";
            }else{

                val = "M";
            }

            client.Gender = val;
            ctx.Client.Add(client);
            ctx.SaveChanges();
            FillData();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtName.Text = Convert.ToString(row.Cells[1].Value);
            txtAddress.Text = Convert.ToString(row.Cells[2].Value);
            txtContactNo.Text = Convert.ToString(row.Cells[3].Value);
            string gender  = Convert.ToString(row.Cells[5].Value);

            if (gender != null && gender != string.Empty)
            {
                if (gender == "M")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }

            }
            else
            {
                radioMale.Checked = false;
                radioFemale.Checked = false;
            }

            lblId.Text = Convert.ToString(row.Cells[0].Value);


        }

        private void button2_Click(object sender, EventArgs e)
        {   
            PropertyContextEntities  context = new PropertyContextEntities();
            int id = Convert.ToInt32(lblId.Text);
            Client client = context.Client.Where(c => c.Id == id).FirstOrDefault<Client>();
            client.Name = txtName.Text;
            client.ContactNo = txtContactNo.Text;
            client.Address = txtAddress.Text;
            context.Entry(client).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            FillData();
            MessageBox.Show("Record updated successfully");
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PropertyContextEntities context = new PropertyContextEntities();
            int id = Convert.ToInt32(lblId.Text);
            Client client = context.Client.Where(c => c.Id == id).FirstOrDefault<Client>();
        
            context.Entry(client).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
            FillData();
            MessageBox.Show("Record deleted successfully");
        }


        private void LoadCombo()
        {
            PropertyContextEntities ctx = new PropertyContextEntities();
            ddlCity.DataSource = ctx.City.ToList<City>();
            ddlCity.DisplayMember = "CityName";
            ddlCity.ValueMember = "Id";
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        

    }
}
