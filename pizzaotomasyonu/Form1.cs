using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace pizzaotomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        void griddoldur()
        {
            con = new SqlConnection("Data Source=DESKTOP-2CK0B4F;Initial Catalog=pizzaotomasyonu;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * From tbl_siparisler", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

             cmd = new SqlCommand();
              con.Open();
              cmd.Connection = con;
              cmd.CommandText = "insert into tbl_siparisler (ad,soyad,telefon,adres,pizzaboy,pizzaadet,icecek,icecekadet,ucret,ekstra) Values ('" + txtad.Text.ToString() + "','" + txtsoyad.Text.ToString() + "','" + maskedtxttel.Text.ToString() + "','" + txtadres.Text.ToString() + "','" + cmbxpizzaboy.Text.ToString() + "','" + txtpizzaadet.Text.ToString() + "','" + cmbxicecek.Text.ToString() + "','" + txticecekadet.Text.ToString() + "','" + txtucret.Text.ToString() + "','" + cmbbxpizzatur.Text.ToString() + "')";
              cmd.ExecuteNonQuery();
              con.Close();
              MessageBox.Show("Kaydedildi");
              griddoldur();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            maskedtxttel.Clear();
            txtadres.Clear();
            cmbxpizzaboy.Text = "";
            txtpizzaadet.Clear();
            cmbxicecek.Text = "";
            txticecekadet.Clear();
            txtucret.Clear();
            cmbbxpizzatur.Text = "";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedtxttel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbxpizzaboy.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtpizzaadet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbxicecek.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txticecekadet.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtucret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbbxpizzatur.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kayıtı Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    dataGridView1.Refresh();
                }
            }
        }
    }
}
                                                                       