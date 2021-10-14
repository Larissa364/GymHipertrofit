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


namespace GymHipertrofit
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            Link();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UT3K1PR\SQLEXPRESS;Initial Catalog=GymHipertrofitDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void FillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Nome from MemberTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Load(rdr);
            NameTB.ValueMember = "Nome";
            NameTB.DataSource = dt;
            Con.Close();
        }
         private void filterByName()
        {
            Con.Open();
            string query = "select * from PaymentTbl where Aluno='"+SearchName.Text+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttzon3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTB.Text = "";
            ValueTB.Text = "";
        }

        private void Payment_Load(object sender, EventArgs e)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(NameTB.Text == "" || ValueTB.Text =="")
            {
                MessageBox.Show("Está faltando informação");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PaymentTbl (Mes, Aluno, Quantia)values('" + Periode.Text + "' ,'" + NameTB.Text + "', '" + ValueTB.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adicionado com sucesso");
                    Con.Close();
                    Periode.Text = "";
                    NameTB.Text = "";
                    ValueTB.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                Con.Close();
                populate();
            }

        }

        public static void Link()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UT3K1PR\SQLEXPRESS;Initial Catalog=GymHipertrofitDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchName.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

 

        private void Periode_ValueChanged(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void PaymentSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Key = Convert.ToInt32(PaymentSDGV.SelectedRows[0].Cells[0].Value.ToString());
            Periode.Text = PaymentSDGV.SelectedRows[0].Cells[1].Value.ToString();
            NameTB.Text = PaymentSDGV.SelectedRows[0].Cells[2].Value.ToString();
            ValueTB.Text = PaymentSDGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Periode.Text = "";
            NameTB.Text = "";
            ValueTB.Text = "";
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
  

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selecione o membro para ser deletado");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PaymentTbl where ID=" + Key + " ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro deletado com sucesso");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void NameTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValueTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
