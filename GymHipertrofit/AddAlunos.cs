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
    public partial class AddAlunos : Form
    {
        public AddAlunos()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UT3K1PR\SQLEXPRESS;Initial Catalog=GymHipertrofitDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void AddAlunos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtname.Text == "" || txtlastname.Text ==  "" || txtcpf.Text == "" || txtage.Text == "" || txtemail.Text == "" || txtaddress.Text == "" || txtfone.Text == "")
            
            {    
             MessageBox.Show("Está faltando informação");
            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into MemberTbl (Nome,Sobrenome,CPF,Genero,Idade,Email,Endereco,Contrato,Horario,Tel)values('" + txtname.Text + "' ,'" + txtlastname.Text + "', '" + txtcpf.Text + "', '" + txtgender.SelectedItem.ToString() + "','" + txtage.Text + "', '" + txtemail.Text + "', '" + txtaddress.Text + "', '" + txttime.SelectedItem.ToString() + "', '" + txttiming.SelectedItem.ToString() + "', '" + txtfone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adicionado com sucesso");
                    Con.Close();
                    txtname.Text = "";
                    txtlastname.Text = "";
                    txtcpf.Text = "";
                    txtgender.Text = "";
                    txtemail.Text = "";
                    txtaddress.Text = "";
                    txttime.Text = "";
                    txttiming.Text = "";
                    txtfone.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtlastname.Text = "";
            txtcpf.Text = "";
            txtgender.Text = "";
            txtage.Text = "";
            txtemail.Text = "";
            txtaddress.Text = "";
            txttime.Text = "";
            txttiming.Text = "";
            txtfone.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtage_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}







